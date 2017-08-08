#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace UsingMatchCollection
{
   class Test
   {
      public static void Main()
      {
         string string1 = "This is a test string";

         // find any nonwhitespace followed by whitespace
         Regex theReg = new Regex( @"(\S+)\s" );

         // get the collection of matches
         MatchCollection theMatches =
            theReg.Matches( string1 );

         // iterate through the collection
         foreach ( Match theMatch in theMatches )
         {
            Console.WriteLine(
               "theMatch.Length: {0}", theMatch.Length );

            if ( theMatch.Length != 0 )
            {
               Console.WriteLine( "theMatch: {0}",
                  theMatch.ToString() );
            }
         }
      }
   }
}
