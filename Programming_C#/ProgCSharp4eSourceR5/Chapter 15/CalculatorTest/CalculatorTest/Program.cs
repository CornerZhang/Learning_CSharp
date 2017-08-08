#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CalculatorTest
{
   class Program
   {
// driver program to test the web service
      public class Tester
      {
         public static void Main()
         {
            Tester t = new Tester();
            t.Run();
         }

         public void Run()
         {
            int var1 = 5;
            int var2 = 7;

            // instantiate the web service proxy
            Service theWebSvc = new Service();

            // call the add method
            Console.WriteLine( "{0} + {1} = {2}", var1, var2,
               theWebSvc.Add( var1, var2 ) );

            // build a table by repeatedly calling the pow method
            for ( int i = 2; i < 10; i++ )
               for ( int j = 1; j < 10; j++ )
               {
                  Console.WriteLine( "{0} to the power of {1} = {2}", i, j,
                     theWebSvc.Pow( i, j ) );
               }
         }
      }

   }
}
