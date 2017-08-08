#region Using directives

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

#endregion

namespace AsynchNetworkServer
{
   public class AsynchNetworkServer
   {

      class ClientHandler
      {
         private byte[] buffer;
         private Socket socket;
         private NetworkStream networkStream;
         private AsyncCallback callbackRead;
         private AsyncCallback callbackWrite;

         public ClientHandler( Socket socketForClient )
         {
            socket = socketForClient;
            buffer = new byte[256];
            networkStream =
               new NetworkStream( socketForClient );

            callbackRead =
               new AsyncCallback( this.OnReadComplete );

            callbackWrite =
               new AsyncCallback( this.OnWriteComplete );
         }

         // begin reading the string from the client
         public void StartRead()
         {
            networkStream.BeginRead(
               buffer, 0, buffer.Length,
               callbackRead, null );
         }

         // when called back by the read, display the string
         // and echo it back to the client
         private void OnReadComplete( IAsyncResult ar )
         {
            int bytesRead = networkStream.EndRead( ar );

            if ( bytesRead > 0 )
            {
               string s =
                  System.Text.Encoding.ASCII.GetString(
                     buffer, 0, bytesRead );
               Console.Write(
                     "Received {0} bytes from client: {1}",
                      bytesRead, s );
               networkStream.BeginWrite(
                  buffer, 0, bytesRead, callbackWrite, null );
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

         // after writing the string, print a message and resume reading
         private void OnWriteComplete( IAsyncResult ar )
         {
            networkStream.EndWrite( ar );
            Console.WriteLine( "Write complete" );
            networkStream.BeginRead(
               buffer, 0, buffer.Length,
               callbackRead, null );
         }
      }


      public static void Main()
      {
         AsynchNetworkServer app =
            new AsynchNetworkServer();
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
            Console.WriteLine( "Client connected" );
            ClientHandler handler =
                new ClientHandler( socketForClient );
            handler.StartRead();
         }
      }
   }
}
