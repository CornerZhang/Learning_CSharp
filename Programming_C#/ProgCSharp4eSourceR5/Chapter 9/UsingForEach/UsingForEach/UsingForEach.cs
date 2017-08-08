#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UsingForEach
{
   namespace Programming_CSharp
   {

      // a simple class to store in the array
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
         static void Main()
         {
            int[] intArray;
            Employee[] empArray;
            intArray = new int[5];
            empArray = new Employee[3];

            // populate the array
            for ( int i = 0; i < empArray.Length; i++ )
            {
               empArray[i] = new Employee( i + 5 );
            }

            foreach ( int i in intArray )
            {
               Console.WriteLine( i.ToString() );
            }
            foreach ( Employee e in empArray )
            {
               Console.WriteLine( e.ToString() );
            }
         }
      }
   }
}
