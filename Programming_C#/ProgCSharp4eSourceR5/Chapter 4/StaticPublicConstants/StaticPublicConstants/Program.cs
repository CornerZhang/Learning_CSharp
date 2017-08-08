#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StaticPublicConstants
{
   public class RightNow
   {
      // public member variables
      public static int Year;
      public static int Month;
      public static int Date;
      public static int Hour;
      public static int Minute;
      public static int Second;

      static RightNow()
      {
         System.DateTime dt = System.DateTime.Now;
         Year = dt.Year;
         Month = dt.Month;
         Date = dt.Day;
         Hour = dt.Hour;
         Minute = dt.Minute;
         Second = dt.Second;
      }
   }

   public class Tester
   {
      static void Main()
      {
         System.Console.WriteLine( "This year: {0}",
                RightNow.Year.ToString() );
         RightNow.Year = 2006;
         System.Console.WriteLine( "This year: {0}",
                RightNow.Year.ToString() );

      }
   }
}
