#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Initializer
{
   public class Time
   {
      // private member variables
      private int Year;
      private int Month;
      private int Date;
      private int Hour;
      private int Minute;
      private int Second = 30;  // initializer

      // public accessor methods
      public void DisplayCurrentTime()
      {
         System.DateTime now = System.DateTime.Now;
         System.Console.WriteLine(
         "\nDebug\t: {0}/{1}/{2} {3}:{4}:{5}",
         now.Month, now.Day, now.Year, now.Hour,
             now.Minute, now.Second );

         System.Console.WriteLine( "Time\t: {0}/{1}/{2} {3}:{4}:{5}",
            Month, Date, Year, Hour, Minute, Second );
      }


      // constructors
      public Time( System.DateTime dt )
      {

         Year = dt.Year;
         Month = dt.Month;
         Date = dt.Day;
         Hour = dt.Hour;
         Minute = dt.Minute;
         Second = dt.Second;   //explicit assignment

      }

      public Time( int Year, int Month, int Date,
            int Hour, int Minute )
      {
         this.Year = Year;
         this.Month = Month;
         this.Date = Date;
         this.Hour = Hour;
         this.Minute = Minute;
      }

   }

   public class Tester
   {
      static void Main()
      {
         System.DateTime currentTime = System.DateTime.Now;
         Time t = new Time( currentTime );
         t.DisplayCurrentTime();

         Time t2 = new Time( 2005, 11, 18, 11, 45 );
         t2.DisplayCurrentTime();

      }
   }
}
