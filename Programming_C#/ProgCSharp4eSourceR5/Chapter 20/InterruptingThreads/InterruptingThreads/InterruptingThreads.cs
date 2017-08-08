#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace InterruptingThreads
{
   class Tester
   {
      static void Main()
      {
         // make an instance of this class
         Tester t = new Tester();

         // run outside static Main
         t.DoTest();
      }

      public void DoTest()
      {
         // create an array of unnamed threads
         Thread[] myThreads = 
            {
               new Thread( new ThreadStart(Decrementer) ),
               new Thread( new ThreadStart(Incrementer) ),
               new Thread( new ThreadStart(Incrementer) )              
            };

         // start each thread
         int ctr = 1;
         foreach ( Thread myThread in myThreads )
         {
            myThread.IsBackground = true;
            myThread.Start();
            myThread.Name = "Thread" + ctr.ToString();
            ctr++;
            Console.WriteLine( "Started thread {0}", myThread.Name );
            Thread.Sleep( 50 );
         }

         // having started the threads
         // tell thread 1 to abort
         myThreads[1].Abort();

         // wait for all threads to end before continuing
         foreach ( Thread myThread in myThreads )
         {
            myThread.Join();
         }

         // after all threads end, print a message
         Console.WriteLine( "All my threads are done." );
      }

      // demo function, counts down from 1k
      public void Decrementer()
      {
         try
         {
            for ( int i = 1000; i >= 0; i-- )
            {
               Console.WriteLine(
                  "Thread {0}. Decrementer: {1}",
                  Thread.CurrentThread.Name,
                  i );
               Thread.Sleep( 1 );
            }
         }
         catch ( ThreadAbortException )
         {
            Console.WriteLine(
               "Thread {0} aborted! Cleaning up...",
               Thread.CurrentThread.Name );
         }
         finally
         {
            Console.WriteLine(
               "Thread {0} Exiting. ",
               Thread.CurrentThread.Name );
         }
      }

      // demo function, counts up to 1K
      public void Incrementer()
      {
         try
         {
            for ( int i = 0; i < 1000; i++ )
            {
               Console.WriteLine(
                  "Thread {0}. Incrementer: {1}",
                  Thread.CurrentThread.Name,
                  i );
               Thread.Sleep( 1 );
            }
         }
         catch ( ThreadAbortException )
         {
            Console.WriteLine(
               "Thread {0} aborted! Cleaning up...",
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
