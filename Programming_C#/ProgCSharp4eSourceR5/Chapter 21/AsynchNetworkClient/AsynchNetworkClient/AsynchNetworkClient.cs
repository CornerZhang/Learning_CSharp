#region Using directives

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

#endregion

namespace AsynchNetworkClient
{
   public class AsynchNetworkClient
   {
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
         string message = "Hello Programming C#";
         Console.WriteLine(
             "Sending {0} to server.", message );

         // create a streamWriter and use it to
         // write a string to the server
         System.IO.StreamWriter writer =
            new System.IO.StreamWriter( streamToServer );
         writer.WriteLine( message );
         writer.Flush();

         // Read response
         System.IO.StreamReader reader =
            new System.IO.StreamReader( streamToServer );
         string strResponse = reader.ReadLine();
         Console.WriteLine( "Received: {0}", strResponse );
         streamToServer.Close();
         return 0;

      }
   }
}
