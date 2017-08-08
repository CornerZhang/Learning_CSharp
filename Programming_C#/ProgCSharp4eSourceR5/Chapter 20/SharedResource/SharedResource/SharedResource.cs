#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace SharedResource
{
   class Tester
   {
      private int counter = 0;

      static void Main()
      {
         // make an instance of this class
         Tester t = new Tester();

         // run outside static Main
         t.DoTest();
      }

      public void DoTest()
      {
         Thread t1 = new Thread( new ThreadStart( Incrementer ) );
         t1.IsBackground = true;
         t1.Name = "ThreadOne";
         t1.Start();
         Console.WriteLine( "Started thread {0}",
            t1.Name );

         Thread t2 = new Thread( new ThreadStart( Incrementer ) );
         t2.IsBackground = true;
         t2.Name = "ThreadTwo";
         t2.Start();
         Console.WriteLine( "Started thread {0}",
            t2.Name );
         t1.Join();
         t2.Join();

         // after all threads end, print a message
         Console.WriteLine( "All my threads are done." );
      }

      // demo function, counts up to 1K
      public void Incrementer()
      {
         try
         {
            while ( counter < 1000 )
            {
               int temp = counter;
               temp++; // increment

               // simulate some work in this method
               Thread.Sleep( 1 );

               // assign the decremented value
               // and display the results
               counter = temp;
               Console.WriteLine(
                  "Thread {0}. Incrementer: {1}",
                  Thread.CurrentThread.Name,
                  counter );
            }
         }
         catch ( ThreadInterruptedException )
         {
            Console.WriteLine(
               "Thread {0} interrupted! Cleaning up...",
               Thread.CurrentThread.Name );
         }
         finally
         {
            Console.WriteLine(
               "Thread {0} Exiting. ",
               Thread.CurrentThread.Name );
         }
      }
   }
}
