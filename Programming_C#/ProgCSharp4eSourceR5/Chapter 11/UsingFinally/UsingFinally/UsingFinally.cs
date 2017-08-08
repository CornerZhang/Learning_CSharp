#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UsingFinally
{
   public class Test
   {
      public static void Main()
      {
         Test t = new Test();
         t.TestFunc();
      }

      // try to divide two numbers
      // handle possible exceptions
      public void TestFunc()
      {
         try
         {
            Console.WriteLine( "Open file here" );
            double a = 5;
            double b = 0;
            Console.WriteLine( "{0} / {1} = {2}",
                a, b, DoDivide( a, b ) );
            Console.WriteLine(
                "This line may or may not print" );
         }

         // most derived exception type first
         catch ( System.DivideByZeroException )
         {
            Console.WriteLine(
               "DivideByZeroException caught!" );
         }
         catch
         {
            Console.WriteLine( "Unknown exception caught" );
         }

         finally
         {
            Console.WriteLine( "Close file here." );
         }


      }

      // do the division if legal
      public double DoDivide( double a, double b )
      {
         if ( b == 0 )
            throw new System.DivideByZeroException();
         if ( a == 0 )
            throw new System.ArithmeticException();
         return a / b;
      }
   }
}
