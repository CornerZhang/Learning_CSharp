#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

#endregion

namespace AsynchNetworkFileServer
{
   public class AsynchNetworkFileServer
   {

      class ClientHandler
      {
         private const int BufferSize = 256;
         private byte[] buffer;
         private Socket socket;
         private NetworkStream networkStream;
         private Stream inputStream;
         private AsyncCallback callbackRead;
         private AsyncCallback callbackWrite;
         private AsyncCallback myFileCallBack;

         // constructor
         public ClientHandler(
            Socket socketForClient )
         {
            // initialize member variable
            socket = socketForClient;

            // initialize buffer to hold
            // contents of file
            buffer = new byte[256];

            // create the network stream
            networkStream =
               new NetworkStream( socketForClient );

            // set the file callback for reading
            // the file
            myFileCallBack =
               new AsyncCallback( this.OnFileCompletedRead );

            // set the callback for reading from the 
            // network stream
            callbackRead =
               new AsyncCallback( this.OnReadComplete );

            // set the callback for writing to the
            // network stream
            callbackWrite =
               new AsyncCallback( this.OnWriteComplete );
         }

         // begin reading the string from the client
         public void StartRead()
         {
            // read from the network
            // get a filename
            networkStream.BeginRead(
               buffer, 0, buffer.Length,
               callbackRead, null );
         }

         // when called back by the read, display the string
         // and echo it back to the client
         private void OnReadComplete( IAsyncResult ar )
         {
            int bytesRead = networkStream.EndRead( ar );

            // if you got a string
            if ( bytesRead > 0 )
            {
               // turn the string to a file name
               string fileName =
                  System.Text.Encoding.ASCII.GetString(
                  buffer, 0, bytesRead );

               // update the console
               Console.Write(
                  "Opening file {0}", fileName );

               // open the file input stream
               inputStream =
                  File.OpenRead( fileName );

               // begin reading the file
               inputStream.BeginRead(
                  buffer,             // holds the results
                  0,                  // offset
                  buffer.Length,      // BufferSize
                  myFileCallBack,     // call back delegate
                  null );              // local state object

            }
            else
            {
               Console.WriteLine( "Read connection dropped" );
               networkStream.Close();
               socket.Close();
               networkStream = null;
               socket = null;
            }
         }

         // when you have a buffer-full of the file
         void OnFileCompletedRead( IAsyncResult asyncResult )
         {
            int bytesRead =
               inputStream.EndRead( asyncResult );

            // if you read some file
            if ( bytesRead > 0 )
            {
               // write it out to the client
               networkStream.BeginWrite(
                  buffer, 0, bytesRead, callbackWrite, null );
            }
            else
            {
               Console.WriteLine( "Finished." );
               networkStream.Close();
               socket.Close();
               networkStream = null;
               socket = null;
            }
         }


         // after writing the string, get more of the file
         private void OnWriteComplete( IAsyncResult ar )
         {
            networkStream.EndWrite( ar );
            Console.WriteLine( "Write complete" );

            // begin reading more of the file
            inputStream.BeginRead(
               buffer,             // holds the results
               0,                  // offset
               buffer.Length,      // (BufferSize)
               myFileCallBack,         // call back delegate
               null );              // local state object

         }
      }


      public static void Main()
      {
         AsynchNetworkFileServer app =
            new AsynchNetworkFileServer();
         app.Run();
      }

      private void Run()
      {
         // create a new TcpListener and start it up
         // listening on port 65000

         IPAddress localAddr = IPAddress.Parse( "127.0.0.1" );
         TcpListener tcpListener = new TcpListener( localAddr, 65000 );
         tcpListener.Start();

         // keep listening until you send the file
         for ( ; ; )
         {
            // if a client connects, accept the connection
            // and return a new socket named socketForClient
            // while tcpListener keeps listening
            Socket socketForClient =
               tcpListener.AcceptSocket();
            if ( socketForClient.Connected )
            {
               Console.WriteLine( "Client connected" );
               ClientHandler handler =
                  new ClientHandler( socketForClient );
               handler.StartRead();
            }
         }
      }
   }
}