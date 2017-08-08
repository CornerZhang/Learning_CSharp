#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;

#endregion

namespace WritingToIsolatedStorage
{
   public class Tester
   {

      public static void Main()
      {
         Tester app = new Tester();
         app.Run();
      }

      private void Run()
      {
         // create the configuration file stream
         IsolatedStorageFileStream configFile =
             new IsolatedStorageFileStream
             ( "Tester.cfg", FileMode.Create );

         // create a writer to write to the stream
         StreamWriter writer =
             new StreamWriter( configFile );

         // write some data to the config. file
         String output;
         System.DateTime currentTime = System.DateTime.Now;
         output = "Last access: " + currentTime.ToString();
         writer.WriteLine( output );
         output = "Last position = 27,35";
         writer.WriteLine( output );

         // flush the buffer and clean up
         writer.Flush();
         writer.Close();
         configFile.Close();
      }
/*
      // Reading the configuration file
      private void Run()
      {
         // open the configuration file stream
         IsolatedStorageFileStream configFile =
             new IsolatedStorageFileStream
             ( "Tester.cfg", FileMode.Open );

         // create a standard stream reader
         StreamReader reader =
             new StreamReader( configFile );

         // read through the file and display
         string theEntry;
         do
         {
            theEntry = reader.ReadLine();
            Console.WriteLine( theEntry );
         } while ( theEntry != null );

         reader.Close();
         configFile.Close();
      }
*/
   }
}
