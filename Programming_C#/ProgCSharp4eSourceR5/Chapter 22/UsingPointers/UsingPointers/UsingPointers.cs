#region Using directives

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

#endregion

namespace UsingPointers
{
   class APIFileReader
   {
      const uint GenericRead = 0x80000000;
      const uint OpenExisting = 3;
      const uint UseDefault = 0;
      int fileHandle;

      [DllImport( "kernel32", SetLastError = true )]
      static extern unsafe int CreateFile(
         string filename,
         uint desiredAccess,
         uint shareMode,
         uint attributes,
         uint creationDisposition,
         uint flagsAndAttributes,
         uint templateFile );

      [DllImport( "kernel32", SetLastError = true )]
      static extern unsafe bool ReadFile(
         int hFile,
         void* lpBuffer,
         int nBytesToRead,
         int* nBytesRead,
         int overlapped );

      // constructor opens an existing file
      // and sets the file handle member 
      public APIFileReader( string filename )
      {
         fileHandle = CreateFile(
            filename,      // filename
            GenericRead,   // desiredAccess 
            UseDefault,    // shareMode
            UseDefault,    // attributes
            OpenExisting,  // creationDisposition 
            UseDefault,    // flagsAndAttributes
            UseDefault );   // templateFile
      }


      public unsafe int Read( byte[] buffer, int index, int count )
      {
         int bytesRead = 0;
         fixed ( byte* bytePointer = buffer )
         {
            ReadFile(
               fileHandle,             // hfile
               bytePointer + index,    // lpBuffer
               count,                  // nBytesToRead
               &bytesRead,             // nBytesRead
               0 );                     // overlapped
         }
         return bytesRead;
      }
   }

   class Test
   {
      public static void Main()
      {
         // create an instance of the APIFileReader, 
         // pass in the name of an existing file
         APIFileReader fileReader =
           new APIFileReader( "myTestFile.txt" );

         // create a buffer and an ASCII coder      
      const int BuffSize = 128;
         byte[] buffer = new byte[BuffSize];
         ASCIIEncoding asciiEncoder = new ASCIIEncoding();

         // read the file into the buffer and display to console
         while ( fileReader.Read( buffer, 0, BuffSize ) != 0 )
         {
            Console.Write( "{0}", asciiEncoder.GetString( buffer ) );
         }
      }
   }
}
