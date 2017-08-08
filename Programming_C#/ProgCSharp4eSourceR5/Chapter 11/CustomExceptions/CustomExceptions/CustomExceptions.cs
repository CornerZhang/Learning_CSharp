#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomExceptions
{
   public class MyCustomException :
         System.ApplicationException
   {
      public MyCustomException( string message ):
         base(message)
      {

      }
   }

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
            double a = 0;
            double b = 5;
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
               "\nHelpLink: {0}\n", e.HelpLink );
         }
         catch ( MyCustomException e )
         {
            Console.WriteLine(
               "\nMyCustomException! Msg: {0}",
               e.Message );
            Console.WriteLine(
               "\nHelpLink: {0}\n", e.HelpLink );
         }
         catch
         {
            Console.WriteLine(
               "Unknown exception caught" );
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
         {
            DivideByZeroException e =
               new DivideByZeroException();
            e.HelpLink =
               "http://www.libertyassociates.com";
            throw e;
         }
         if ( a == 0 )
         {
            MyCustomException e =
               new MyCustomException(
                  "Can't have zero divisor" );
            e.HelpLink =
            "http://www.libertyassociates.com/NoZeroDivisor.htm";
            throw e;
         }
         return a / b;
      }
   }
}
