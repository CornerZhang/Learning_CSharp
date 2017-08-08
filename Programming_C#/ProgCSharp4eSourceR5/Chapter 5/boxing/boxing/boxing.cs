#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace boxing
{
   public class UnboxingTest
   {
      public static void Main()
      {
         int i = 123;

         //Boxing
         object o = i;

         // unboxing (must be explict)
         int j = ( int ) o;
         Console.WriteLine( "j: {0}", j );
      }
   }
}
