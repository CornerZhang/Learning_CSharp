#region Using directives

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

#endregion

namespace AsynchNetworkFileClient
{
   public class AsynchNetworkClient
   {
      private const int BufferSize = 256;
      private NetworkStream streamToServer;

      static public int Main()
      {

         AsynchNetworkClient client =
            new AsynchNetworkClient();
         return client.Run();
      }

      AsynchNetworkClient()
      {
         string serverName = "localhost";
         Console.WriteLine( "Connecting to {0}", serverName );
         TcpClient tcpSocket = new TcpClient( serverName, 65000 );
         streamToServer = tcpSocket.GetStream();
      }

      private int Run()
      {
         string message = @"C:\test\source\AskTim.txt";
         Console.Write(
            "Sending {0} to server.", message );

         // create a streamWriter and use it to
         // write a string to the server
         System.IO.StreamWriter writer =
            new System.IO.StreamWriter( streamToServer );
         writer.Write( message );
         writer.Flush();

         bool fQuit = false;

         // while there is data coming
         // from the server, keep reading
         while ( !fQuit )
         {
            // buffer to hold the response
            char[] buffer = new char[BufferSize];

            // Read response
            System.IO.StreamReader reader =
               new System.IO.StreamReader( streamToServer );

            // see how many bytes are 
            // retrieved to the buffer
            int bytesRead =
               reader.Read( buffer, 0, BufferSize );
            if ( bytesRead == 0 )  // none? quite
               fQuit = true;
            else                 // got some?
            {
               // display it as a string
               string theString = new String( buffer );
               Console.WriteLine( theString );
            }
         }
         streamToServer.Close(); // tidy up
         return 0;

      }
   }
}
