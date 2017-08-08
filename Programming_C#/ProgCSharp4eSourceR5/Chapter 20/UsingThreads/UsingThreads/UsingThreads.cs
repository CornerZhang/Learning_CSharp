#region Using directives

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

#endregion

namespace UsingThreads
{
   class Tester
   {
      static void Main()
      {
         // make an instance of this class
         Tester t = new Tester();

         Console.WriteLine( "Hello" );
         // run outside static Main
         t.DoTest();

      }

      public void DoTest()
      {
         // create a thread for the Incrementer
         // pass in a ThreadStart delegate
         // with the address of Incrementer
         Thread t1 =
            new Thread(
               new ThreadStart( Incrementer ) );

         // create a thread for the Decrementer
         // pass in a ThreadStart delegate
         // with the address of Decrementer
         Thread t2 =
            new Thread(
               new ThreadStart( Decrementer ) );

         // start the threads
         t1.Start();
         t2.Start();
      }

      // demo function, counts up to 1K
      public void Incrementer()
      {
         for ( int i = 0; i < 10000; i++ )
         {
            
            System.Console.WriteLine(
               "Incrementer: {0}", i );
         }
      }

      // demo function, counts down from 1k
      public void Decrementer()
      {
         for ( int i = 10000; i >= 0; i-- )
         {
            System.Console.WriteLine(
               "Decrementer: {0}", i );
         }
      }
   }
}
