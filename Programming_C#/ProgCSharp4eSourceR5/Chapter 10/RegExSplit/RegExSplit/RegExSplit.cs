#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

#endregion

namespace RegExSplit
{
   public class Tester
   {
      static void Main()
      {
         string s1 =
            "One,Two,Three Liberty Associates, Inc.";
         StringBuilder sBuilder = new StringBuilder();
         int id = 1;
         foreach ( string subStr in Regex.Split( s1, " |, |," ) )
         {
            sBuilder.AppendFormat( "{0}: {1}\n", id++, subStr );
         }
         Console.WriteLine( "{0}", sBuilder );
      }
   }
}
