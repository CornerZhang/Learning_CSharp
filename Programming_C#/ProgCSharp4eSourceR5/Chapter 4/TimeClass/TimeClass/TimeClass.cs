#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace TimeClass
{
   public class Time
   {
      // private variables
      int Year;
      int Month;
      int Date;
      int Hour;
      int Minute;
      int Second;

      // public methods
      public void DisplayCurrentTime()
      {
         Console.WriteLine(
            "stub for DisplayCurrentTime" );
      }
   }

   public class Tester
   {
      static void Main()
      {
         Time t = new Time();
         t.DisplayCurrentTime();
      }
   }
}
