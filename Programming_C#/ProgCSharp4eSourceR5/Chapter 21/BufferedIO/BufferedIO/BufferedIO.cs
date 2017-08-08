#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace BufferedIO
{
   class Tester
   {
      const int SizeBuff = 1024;

      public static void Main()
      {
         // make an instance and run it
         Tester t = new Tester();
         t.Run();
      }

      // Set it running with a directory name
      private void Run()
      {
         // create binary streams
         Stream inputStream = File.OpenRead(
            @"C:\test\source\folder3.cs" );

         Stream outputStream = File.OpenWrite(
            @"C:\test\source\folder3.bak" );

         // add buffered streams on top of the
         // binary streams
         BufferedStream bufferedInput =
            new BufferedStream( inputStream );

         BufferedStream bufferedOutput =
            new BufferedStream( outputStream );
         byte[] buffer = new Byte[SizeBuff];
         int bytesRead;

         while ( ( bytesRead =
            bufferedInput.Read( buffer, 0, SizeBuff ) ) > 0 )
         {
            bufferedOutput.Write( buffer, 0, bytesRead );
         }

         bufferedOutput.Flush();
         bufferedInput.Close();
         bufferedOutput.Close();

      }
   }
}
