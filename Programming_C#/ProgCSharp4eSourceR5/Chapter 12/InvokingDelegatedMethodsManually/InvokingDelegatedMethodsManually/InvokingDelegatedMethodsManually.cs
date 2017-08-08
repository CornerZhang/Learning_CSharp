#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace InvokingDelegatedMethodsManually
{
   public class ClassWithDelegate
   {
      // a multicast delegate that encapsulates a method
      // that returns an int
      public delegate int DelegateThatReturnsInt();
      public DelegateThatReturnsInt theDelegate;

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
                  int result = del();
                  Console.WriteLine(
                    "Delegates fired! Returned result: {0}",
                    result );
               }  // end foreach
               Console.WriteLine();
            }    // end if
         }      // end for ;;
      }        // end run
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
