#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ConvertingArrays
{
   // create an object we can
   // store in the array
   public class Employee
   {
      // a simple class to store in the array
      public Employee( int empID )
      {
         this.empID = empID;
      }
      public override string ToString()
      {
         return empID.ToString();
      }
      private int empID;
   }

   public class Tester
   {
      // this method takes an array of objects
      // we'll pass in an array of Employees
      // and then an array of strings
      // the conversion is implicit since both Employee
      // and string derive (ultimately) from object
      public static void PrintArray( object[] theArray )
      {
         Console.WriteLine( "Contents of the Array {0}",
            theArray.ToString() );

         // walk through the array and print
         // the values. 
         foreach ( object obj in theArray )
         {
            Console.WriteLine( "Value: {0}", obj );
         }
      }

      static void Main()
      {
         // make an array of Employee objects
         Employee[] myEmployeeArray = new Employee[3];

         // initialize each Employee's value
         for ( int i = 0; i < 3; i++ )
         {
            myEmployeeArray[i] = new Employee( i + 5 );
         }

         // display the values
         PrintArray( myEmployeeArray );

         // create an array of two strings
         string[] array = 
            {
               "hello", "world"
            };

         // print the value of the strings
         PrintArray( array );
      }
   }
}
