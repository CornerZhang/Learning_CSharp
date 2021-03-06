﻿#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

#endregion

namespace UsingPInvoke
{
   class Tester
   {

      // declare the WinAPI method you wish to P/Invoke
      [DllImport( "kernel32.dll", EntryPoint = "MoveFile",
          ExactSpelling = false, CharSet = CharSet.Unicode,
          SetLastError = true )]
      static extern bool MoveFile(
         string sourceFile, string destinationFile );

      public static void Main()
      {
         // make an instance and run it
         Tester t = new Tester();
         string theDirectory = @"c:\test\media";
         DirectoryInfo dir =
            new DirectoryInfo( theDirectory );
         t.ExploreDirectory( dir );
      }

      // Set it running with a directory name
      private void ExploreDirectory( DirectoryInfo dir )
      {

         // make a new subdirectory
         string newDirectory = "newTest";
         DirectoryInfo newSubDir =
            dir.CreateSubdirectory( newDirectory );

         // get all the files in the directory and
         // copy them to the new directory
         FileInfo[] filesInDir = dir.GetFiles();
         foreach ( FileInfo file in filesInDir )
         {
            string fullName = newSubDir.FullName +
               "\\" + file.Name;
            file.CopyTo( fullName );
            Console.WriteLine( "{0} copied to newTest",
               file.FullName );
         }

         // get a collection of the files copied in
         filesInDir = newSubDir.GetFiles();

         // delete some and rename others
         int counter = 0;
         foreach ( FileInfo file in filesInDir )
         {
            string fullName = file.FullName;

            if ( counter++ % 2 == 0 )
            {
               // P/Invoke the Win API
               Tester.MoveFile( fullName, fullName + ".bak" );

               Console.WriteLine( "{0} renamed to {1}",
                  fullName, file.FullName );
            }
            else
            {
               file.Delete();
               Console.WriteLine( "{0} deleted.",
                  fullName );
            }
         }
         // delete the subdirectory 
         newSubDir.Delete( true );
      }
   }
}
