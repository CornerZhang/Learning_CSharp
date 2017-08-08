#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ReturningValuesInParams
{
   public class Time
   {
      // private member variables
      private int Year;
      private int Month;
      private int Date;
      private int Hour;
      private int Minute;
      private int Second;

      // public accessor methods
      public void DisplayCurrentTime()
      {
         System.Console.WriteLine( "{0}/{1}/{2} {3}:{4}:{5}",
            Month, Date, Year, Hour, Minute, Second );
      }

      public int GetHour()
      {
         return Hour;
      }


      public void GetTime( int h, int m, int s )
      {
         h = Hour;
         m = Minute;
         s = Second;
      }


      // constructor
      public Time( System.DateTime dt )
      {

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
         System.DateTime currentTime = System.DateTime.Now;
         Time t = new Time( currentTime );
         t.DisplayCurrentTime();

         int theHour = 0;
         int theMinute = 0;
         int theSecond = 0;
         t.GetTime( theHour, theMinute, theSecond );
         System.Console.WriteLine( "Current time: {0}:{1}:{2}",
                   theHour, theMinute, theSecond );
      }
   }
}
