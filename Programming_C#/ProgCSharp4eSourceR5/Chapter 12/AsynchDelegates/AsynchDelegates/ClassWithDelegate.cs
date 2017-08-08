#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace AsynchDelegates
{
   public class ClassWithDelegate
   {
      // a multicast delegate that encapsulates a method
      // that returns an int
      public delegate int DelegateThatReturnsInt();
      public event DelegateThatReturnsInt theDelegate;

      public void Run()
      {
         for ( ; ; )
         {
            // sleep for a half second
            Thread.Sleep( 500 );

            if ( theDelegate != null )
            {
               // explicitly invoke each delegated method
               foreach (
                 DelegateThatReturnsInt del in
                   theDelegate.GetInvocationList() )
               {
                  // invoke asynchronously
                  // pass the delegate in as a state object
                  del.BeginInvoke( new AsyncCallback( ResultsReturned ), del );

               }  // end foreach
            }    // end if
         }      // end for ;;
      }        // end run

      // call back method to capture results
      private void ResultsReturned( IAsyncResult iar )
      {
         // cast the state object back to the delegate type
         DelegateThatReturnsInt del = ( DelegateThatReturnsInt ) iar.AsyncState;

         // call EndInvoke on the delegate to get the results
         int result = del.EndInvoke( iar );

         // display the results
         Console.WriteLine( "Delegate returned result: {0}", result );
      }
   }          // end class


   public class FirstSubscriber
   {
      private int myCounter = 0;

      public void Subscribe( ClassWithDelegate theClassWithDelegate )
      {
         theClassWithDelegate.theDelegate +=
           new ClassWithDelegate.DelegateThatReturnsInt( DisplayCounter );
      }

      public int DisplayCounter()
      {
         Console.WriteLine( "Busy in DisplayCounter..." );
         Thread.Sleep( 10000 );
         Console.WriteLine( "Done with work in DisplayCounter..." );
         return ++myCounter;
      }
   }

   public class SecondSubscriber
   {
      private int myCounter = 0;

      public void Subscribe( ClassWithDelegate theClassWithDelegate )
      {
         theClassWithDelegate.theDelegate +=
           new ClassWithDelegate.DelegateThatReturnsInt( Doubler );
      }

      public int Doubler()
      {
         return myCounter += 2;
      }
   }

   public class Test
   {
      public static void Main()
      {
         ClassWithDelegate theClassWithDelegate =
           new ClassWithDelegate();

         FirstSubscriber fs = new FirstSubscriber();
         fs.Subscribe( theClassWithDelegate );

         SecondSubscriber ss = new SecondSubscriber();
         ss.Subscribe( theClassWithDelegate );

         theClassWithDelegate.Run();
      }
   }
}
