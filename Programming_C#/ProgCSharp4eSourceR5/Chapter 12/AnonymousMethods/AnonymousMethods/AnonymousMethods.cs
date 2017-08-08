﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace AnonymousMethods
{
   // a class to hold the information about the event
   // in this case it will hold only information 
   // available in the clock class, but could hold
   // additional state information 
   public class TimeInfoEventArgs : EventArgs
   {
      public readonly int hour;
      public readonly int minute;
      public readonly int second;
      public TimeInfoEventArgs( int hour, int minute, int second )
      {
         this.hour = hour;
         this.minute = minute;
         this.second = second;
      }
   }

   // our subject -- it is this class that other classes
   // will observe. This class publishes one event: 
   // OnSecondChange. The observers subscribe to that event
   public class Clock
   {
      private int hour;
      private int minute;
      private int second;

      // the delegate the subscribers must implement
      public delegate void SecondChangeHandler
        (
        object clock,
        TimeInfoEventArgs timeInformation
        );

      // the keyword event controls access to the delegate
      public event SecondChangeHandler OnSecondChange;

      // set the clock running
      // it will raise an event for each new second
      public void Run()
      {

         for ( ; ; )
         {
            // sleep 10 milliseconds
            Thread.Sleep( 10 );

            // get the current time
            System.DateTime dt = System.DateTime.Now;

            // if the second has changed
            // notify the subscribers
            if ( dt.Second != second )
            {
               // create the TimeInfoEventArgs object
               // to pass to the subscriber
               TimeInfoEventArgs timeInformation =
                 new TimeInfoEventArgs(
                 dt.Hour, dt.Minute, dt.Second );

               // if anyone has subscribed, notify them
               if ( OnSecondChange != null )
               {
                  OnSecondChange(
                    this, timeInformation );
               }
            }

            // update the state
            this.second = dt.Second;
            this.minute = dt.Minute;
            this.hour = dt.Hour;

         }
      }
   }

   // an observer. DisplayClock subscribes to the 
   // clock's events. The job of DisplayClock is 
   // to display the current time 
   public class DisplayClock
   {
      // given a clock, subscribe to 
      // its SecondChangeHandler event
      public void Subscribe( Clock clock )
      {
         clock.OnSecondChange += delegate( object theClock, TimeInfoEventArgs ti )
         {
          Console.WriteLine( "Current Time: {0}:{1}:{2}",
           ti.hour.ToString(),
           ti.minute.ToString(),
           ti.second.ToString() );
         };
           
      }

    }

   // a second subscriber whose job is to write to a file
   public class LogCurrentTime
   {
      public void Subscribe( Clock clock )
      {
         clock.OnSecondChange += delegate( object theClock, TimeInfoEventArgs ti )
         {
         Console.WriteLine( "Logging to file: {0}:{1}:{2}",
           ti.hour.ToString(),
           ti.minute.ToString(),
           ti.second.ToString() );
         };
      }

      // this method should write to a file
      // we write to the console to see the effect
      // this object keeps no state
   }

   public class Test
   {
      public static void Main()
      {
         // create a new clock 
         Clock theClock = new Clock();

         // create the display and tell it to
         // subscribe to the clock just created
         DisplayClock dc = new DisplayClock();
         dc.Subscribe( theClock );

         // create a Log object and tell it
         // to subscribe to the clock 
         LogCurrentTime lct = new LogCurrentTime();
         lct.Subscribe( theClock );


         // Get the clock started
         theClock.Run();
      }
   }
}
