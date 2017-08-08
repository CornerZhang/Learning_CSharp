#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ExceptionObject
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
            double a = 12;
            double b = 0;
            Console.WriteLine( "{0} / {1} = {2}",
                a, b, DoDivide( a, b ) );
            Console.WriteLine(
              "This line may or may not print" );
         }

         // most derived exception type first
         catch ( System.DivideByZeroException e )
         {
            Console.WriteLine(
                 "\nDivideByZeroException! Msg: {0}",
                 e.Message );
            Console.WriteLine(
                 "\nHelpLink: {0}", e.HelpLink );
            Console.WriteLine(
                 "\nHere's a stack trace: {0}\n",
                 e.StackTrace );
         }
         catch (System.Exception e)
         {
            Console.WriteLine(
                 "Unknown exception caught" + e.Message );
         }
         finally
         {
            Console.WriteLine(
              "Close file here." );
         }

      }

      // do the division if legal
      public double DoDivide( double a, double b )
      {
         if ( b == 0 )
         {
            DivideByZeroException e =
              new DivideByZeroException();
            e.HelpLink =
              "http://www.libertyassociates.com";
            throw e;
         }
         if ( a == 0 )
            throw new ArithmeticException();
         return a / b;
      }
   }
}
