#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace LoopVsBruteForce
{
   public class MyMath
   {
      // sum numbers with a loop
      public int DoSum( int n )
      {
         int result = 0;
         for ( int i = 1; i <= n; i++ )
         {
            result += i;
         }
         return result;
      }

      // brute force by hand
      public int DoSum2()
      {
         return 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11
            + 12 + 13 + 14 + 15 + 16 + 17 + 18 + 19 + 20;
      }

   }

   public class TestDriver
   {
      public static void Main()
      {

         const int val = 20;  // val to sum

         // 1,000,000 iterations
         const int iterations = 1000000;

         // hold the answer
         int result = 0;

         MyMath m = new MyMath();

         // mark the start time   
         DateTime startTime = DateTime.Now;

         // run the experiment
         for ( int i = 0; i < iterations; i++ )
         {
            result = m.DoSum( val );
         }
         // mark the elapsed time
         TimeSpan elapsed =
            DateTime.Now - startTime;

         // display the results
         Console.WriteLine(
            "Loop: Sum of ({0}) = {1}",
               val, result );
         Console.WriteLine(
            "The elapsed time in milliseconds is: " +
            elapsed.TotalMilliseconds.ToString() );

         // mark a new start time
         startTime = DateTime.Now;

         // run the experiment
         for ( int i = 0; i < iterations; i++ )
         {
            result = m.DoSum2();
         }

         // mark the new elapsed time
         elapsed = DateTime.Now - startTime;

         // display the results
         Console.WriteLine(
            "Brute Force: Sum of ({0}) = {1}",
               val, result );
         Console.WriteLine(
            "The elapsed time in milliseconds is: " +
            elapsed.TotalMilliseconds );
      }
   }
}
