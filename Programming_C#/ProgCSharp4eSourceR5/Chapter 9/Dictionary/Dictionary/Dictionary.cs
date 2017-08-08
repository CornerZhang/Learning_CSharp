#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Dictionary
{
   public class Tester
   {
      static void Main()
      {
         // Create and initialize a new Dictionary.
         Dictionary<string,string> Dictionary = new Dictionary<string,string>();
         Dictionary.Add("000440312", "Jesse Liberty");
         Dictionary.Add("000123933", "Stacey Liberty");
         Dictionary.Add("000145938", "John Galt");
         Dictionary.Add("000773394", "Ayn Rand");

         // access a particular item
         Console.WriteLine("myDictionary[\"000145938\"]: {0}",
            Dictionary["000145938"]);
      }
   }
}

