#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

#endregion

namespace ReadingWritingToTextFile
{
   class Tester
   {
      public static void Main()
      {
         // make an instance and run it
         Tester t = new Tester();
         t.Run();
      }

      // Set it running with a directory name
      private void Run()
      {
         // open a file
         FileInfo theSourceFile = new FileInfo(
            @"C:\test\source\test.cs" );

         // create a text reader for that file
         StreamReader reader = theSourceFile.OpenText();

         // create a text writer to the new file
         StreamWriter writer = new StreamWriter(
            @"C:\test\source\test.bak", false );

         // create a text variable to hold each line
         string text;

         // walk the file and read every line
         // writing both to the console
         // and to the file
         do
         {
            text = reader.ReadLine();
            writer.WriteLine( text );
            Console.WriteLine( text );
         } while ( text != null );

         // tidy up
         reader.Close();
         writer.Close();
      }
   }
}
