#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace CaptureCollection
{
   class Test
   {
      public static void Main()
      {
         // the string to parse
         // note that names appear in both 
         // searchable positions
         string string1 =
            "04:03:27 Jesse 0.0.0.127 Liberty ";

         // regular expression which groups company twice
         Regex theReg = new Regex( @"(?<time>(\d|\:)+)\s" +
            @"(?<company>\S+)\s" +
            @"(?<ip>(\d|\.)+)\s" +
            @"(?<company>\S+)\s" );

         // get the collection of matches
         MatchCollection theMatches =
            theReg.Matches( string1 );

         // iterate through the collection
         foreach ( Match theMatch in theMatches )
         {
            if ( theMatch.Length != 0 )
            {
               Console.WriteLine( "theMatch: {0}",
                  theMatch.ToString() );
               Console.WriteLine( "time: {0}",
                  theMatch.Groups["time"] );
               Console.WriteLine( "ip: {0}",
                  theMatch.Groups["ip"] );
               Console.WriteLine( "Company: {0}",
                  theMatch.Groups["company"] );

               // iterate over the captures collection 
               // in the company group within the 
               // groups collection in the match

               foreach ( Capture cap in
                  theMatch.Groups["company"].Captures )
               {
                  Console.WriteLine( "cap: {0}", cap.ToString() );
               }

            }
         }
      }
   }
}
