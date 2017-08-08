#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace AsynchronousIO
{
   public class AsynchIOTester
   {
      private Stream inputStream;

      // delegated method
      private AsyncCallback myCallBack;

      // buffer to hold the read data
      private byte[] buffer;

      // the size of the buffer
      const int BufferSize = 256;

      // constructor
      AsynchIOTester()
      {
         // open the input stream
         inputStream =
            File.OpenRead(
            @"C:\test\source\AskTim.txt" );

         // allocate a buffer
         buffer = new byte[BufferSize];

         // assign the call back
         myCallBack =
            new AsyncCallback( this.OnCompletedRead );
      }

      public static void Main()
      {
         // create an instance of AsynchIOTester
         // which invokes the constructor
         AsynchIOTester theApp =
            new AsynchIOTester();

         // call the instance method
         theApp.Run();
      }

      void Run()
      {
         inputStream.BeginRead(
            buffer,             // holds the results
            0,                  // offset
            buffer.Length,      // (BufferSize)
            myCallBack,         // call back delegate
            null );              // local state object

         // do some work while data is read
         for ( long i = 0; i < 500000; i++ )
         {
            if ( i % 1000 == 0 )
            {
               Console.WriteLine( "i: {0}", i );
            }
         }

      }

      // call back method
      void OnCompletedRead( IAsyncResult asyncResult )
      {
         int bytesRead =
            inputStream.EndRead( asyncResult );

         // if we got bytes, make them a string 
         // and display them, then start up again. 
         // Otherwise, we're done.
         if ( bytesRead > 0 )
         {
            String s =
               Encoding.ASCII.GetString( buffer, 0, bytesRead );
            Console.WriteLine( s );
            inputStream.BeginRead(
               buffer, 0, buffer.Length, myCallBack, null );
         }
      }
   }
}
