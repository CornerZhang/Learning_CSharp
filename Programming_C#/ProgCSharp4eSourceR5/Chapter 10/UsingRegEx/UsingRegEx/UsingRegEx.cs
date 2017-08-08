#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace UsingRegEx
{
   public class Tester
   {
      static void Main()
      {
         string s1 =
            "One,Two,Three Liberty Associates, Inc.";
         Regex theRegex = new Regex( " |, |," );
         StringBuilder sBuilder = new StringBuilder();
         int id = 1;

         foreach ( string subString in theRegex.Split( s1 ) )
         {
            sBuilder.AppendFormat(
               "{0}: {1}\n", id++, subString );
         }
         Console.WriteLine( "{0}", sBuilder );
      }
   }
}
