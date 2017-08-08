#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace IComparable
{
   // a simple class to store in the array
   public class Employee : IComparable<Employee>
   {
      private int empID;

      public Employee( int empID )
      {
         this.empID = empID;
      }

      public override string ToString()
      {
         return empID.ToString();
      }


      public bool Equals( Employee other )
      {
         if ( this.empID == other.empID )
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      // Comparer delegates back to Employee
      // Employee uses the integer's default
      // CompareTo method

      public int CompareTo( Employee rhs )
      {
         return this.empID.CompareTo( rhs.empID );
      }
   }
   public class Tester
   {
      static void Main()
      {
         List<Employee> empArray = new List<Employee>();
         List<Int32> intArray = new List<Int32>();

         // generate random numbers for 
         // both the integers and the
         // employee id's

         Random r = new Random();

         // populate the array
         for ( int i = 0; i < 5; i++ )
         {
            // add a random employee id
            empArray.Add( new Employee( r.Next( 10 ) + 100 ) );

            // add a random integer
            intArray.Add( r.Next( 10 ) );
         }


         // display all the contents of the int array
         for ( int i = 0; i < intArray.Count; i++ )
         {
            Console.Write( "{0} ", intArray[i].ToString() );
         }
         Console.WriteLine( "\n" );

         // display all the contents of the Employee array
         for ( int i = 0; i < empArray.Count; i++ )
         {
            Console.Write( "{0} ", empArray[i].ToString() );
         }
         Console.WriteLine( "\n" );

         // sort and display the int array
         intArray.Sort();
         for ( int i = 0; i < intArray.Count; i++ )
         {
            Console.Write( "{0} ", intArray[i].ToString() );
         }
         Console.WriteLine( "\n" );

         // sort and display the employee array
         //Employee.EmployeeComparer c = Employee.GetComparer();
         //empArray.Sort(c);

         empArray.Sort();


         // display all the contents of the Employee array
         for ( int i = 0; i < empArray.Count; i++ )
         {
            Console.Write( "{0} ", empArray[i].ToString() );
         }
         Console.WriteLine( "\n" );

      }
   }
}
