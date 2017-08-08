#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ReferencesOnValueTypes
{
// declare a simple interface
   interface IStorable
   {
      void Read();
      int Status { get;set;}

   }

// Implement through a struct
   public struct myStruct : IStorable
   {

      public void Read()
      {
         Console.WriteLine(
            "Implementing IStorable.Read" );
      }

      public int Status
      {
         get
         {
            return status;
         }
         set
         {
            status = value;
         }
      }

      private int status;
   }

   public class Tester
   {

      static void Main()
      {
         // create a myStruct object
         myStruct theStruct = new myStruct();
         theStruct.Status = -1;  // initialize
         Console.WriteLine(
            "theStruct.Status: {0}", theStruct.Status );

         // Change the value
         theStruct.Status = 2;
         Console.WriteLine( "Changed object." );
         Console.WriteLine(
            "theStruct.Status: {0}", theStruct.Status );

         // cast to an IStorable
         // implicit box to a reference type
         IStorable isTemp = ( IStorable ) theStruct;

         // set the value through the interface reference
         isTemp.Status = 4;
         Console.WriteLine( "Changed interface." );
         Console.WriteLine( "theStruct.Status: {0}, isTemp: {1}",
            theStruct.Status, isTemp.Status );

         // Change the value again
         theStruct.Status = 6;
         Console.WriteLine( "Changed object." );
         Console.WriteLine( "theStruct.Status: {0}, isTemp: {1}",
            theStruct.Status, isTemp.Status );
      }
   }
}
