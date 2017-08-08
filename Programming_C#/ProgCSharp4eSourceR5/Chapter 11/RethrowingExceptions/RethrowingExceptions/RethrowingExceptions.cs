#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace RethrowingExceptions
{
   public class MyCustomException : System.ApplicationException
   {
      public MyCustomException(
         string message, Exception inner ):
         base(message,inner)
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

      public void TestFunc()
      {
         try
         {
            DangerousFunc1();
         }

         // if you catch a custom exception
            // print the exception history
         catch ( MyCustomException e )
         {
            Console.WriteLine( "\n{0}", e.Message );
            Console.WriteLine(
               "Retrieving exception history..." );
            Exception inner =
               e.InnerException;
            while ( inner != null )
            {
               Console.WriteLine(
                  "{0}", inner.Message );
               inner =
                  inner.InnerException;
            }
		   Console.WriteLine("Calling ToString...");
		   Console.Write(e.ToString());
	   }
      }

      public void DangerousFunc1()
      {
         try
         {
            DangerousFunc2();
         }

         // if you catch any exception here
            // throw a custom exception
         catch ( System.Exception e )
         {
            MyCustomException ex =
               new MyCustomException(
                  "E3 - Custom Exception Situation!", e );
            throw ex;
         }
      }

      public void DangerousFunc2()
      {
         try
         {
            DangerousFunc3();
         }

         // if you catch a DivideByZeroException take some 
            // corrective action and then throw a general exception
         catch ( System.DivideByZeroException e )
         {
            Exception ex =
               new Exception(
                  "E2 - Func2 caught divide by zero", e );
            throw ex;
         }
      }

      public void DangerousFunc3()
      {
         try
         {
            DangerousFunc4();
         }
         catch ( System.ArithmeticException )
         {
			 Console.WriteLine("Arithmetic exception caught in DF3, and rethrown...");
			 throw;
         }

         catch ( System.Exception )
         {
            Console.WriteLine(
               "Exception handled here." );
         }
      }

      public void DangerousFunc4()
      {
         throw new DivideByZeroException( "E1 - DivideByZero Exception" );
      }
   }
}
