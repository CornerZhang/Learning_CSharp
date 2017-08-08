#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace RecursingDirectories
{
   class Tester
   {

      // static member variables to keep track of totals
      // and indentation level
      static int dirCounter = 1;
      static int indentLevel = -1; // so first push = 0

      public static void Main()
      {
         Tester t = new Tester();

         // choose the initial subdirectory
         string theDirectory =
            Environment.GetEnvironmentVariable( "SystemRoot" );

         // call the method to explore the directory,
         // displaying its access date and all
         // subdirectories

         DirectoryInfo dir = new DirectoryInfo( theDirectory );

         t.ExploreDirectory( dir );


         // completed. print the statistics
         Console.WriteLine(
            "\n\n{0} directories found.\n",
            dirCounter );
      }

      // Set it running with a directoryInfo object
      // for each directory it finds, it will call 
      // itself recursively

      private void ExploreDirectory( DirectoryInfo dir )
      {
         indentLevel++;  // push a directory level

         // create indentation for subdirectories
         for ( int i = 0; i < indentLevel; i++ )
            Console.Write( "  " ); // two spaces per level

         // print the directory and the time last accessed
         Console.WriteLine( "[{0}] {1} [{2}]\n",
            indentLevel, dir.Name, dir.LastAccessTime );

         // get all the directories in the current directory
         // and call this method recursively on each
         DirectoryInfo[] directories = dir.GetDirectories();
         foreach ( DirectoryInfo newDir in directories )
         {
            dirCounter++;  // increment the counter
            ExploreDirectory( newDir );
         }
         indentLevel--; // pop a directory level
      }
   }
}
