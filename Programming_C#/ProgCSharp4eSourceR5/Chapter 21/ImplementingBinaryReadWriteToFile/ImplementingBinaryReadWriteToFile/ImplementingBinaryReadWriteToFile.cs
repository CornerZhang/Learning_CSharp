#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace ImplementingBinaryReadWriteToFile
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
         // the file to read from
         Stream inputStream = File.OpenRead(
            @"C:\test\source\test1.cs" );

         // the file to write to
         Stream outputStream = File.OpenWrite(
            @"C:\test\source\test1.bak" );

         // create a buffer to hold the bytes 
         byte[] buffer = new Byte[SizeBuff];
         int bytesRead;

         // while the read method returns bytes
         // keep writing them to the output stream
         while ( ( bytesRead =
            inputStream.Read( buffer, 0, SizeBuff ) ) > 0 )
         {
            outputStream.Write( buffer, 0, bytesRead );
         }

         // tidy up before exiting
         inputStream.Close();
         outputStream.Close();
      }
   }
}
