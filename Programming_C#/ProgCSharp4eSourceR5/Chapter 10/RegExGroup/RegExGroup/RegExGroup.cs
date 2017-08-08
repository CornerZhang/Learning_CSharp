#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace RegExGroup
{
   class Test
   {
      public static void Main()
      {
         string string1 = "04:03:27 127.0.0.0 LibertyAssociates.com";

         // group time = one or more digits or colons followed by space
         Regex theReg = new Regex( @"(?<time>(\d|\:)+)\s" +
            // ip address = one or more digits or dots followed by  space
            @"(?<ip>(\d|\.)+)\s" +
            // site = one or more characters
            @"(?<site>\S+)" );

         // get the collection of matches
         MatchCollection theMatches = theReg.Matches( string1 );

         // iterate through the collection
         foreach ( Match theMatch in theMatches )
         {
            if ( theMatch.Length != 0 )
            {
               Console.WriteLine( "\ntheMatch: {0}",
                   theMatch.ToString() );
               Console.WriteLine( "time: {0}",
                   theMatch.Groups["time"] );
               Console.WriteLine( "ip: {0}",
                   theMatch.Groups["ip"] );
               Console.WriteLine( "site: {0}",
                   theMatch.Groups["site"] );
            }
         }
      }
   }
}
