#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ArraySortAndReverse
{
   public class Tester
   {
      public static void PrintMyArray( object[] theArray )
      {

         foreach ( object obj in theArray )
         {
            Console.WriteLine( "Value: {0}", obj );
         }
         Console.WriteLine( "\n" );
      }

      static void Main()
      {
         String[] myArray = 
            {
                "Who", "is", "John", "Galt" 
            };

         PrintMyArray( myArray );
         Array.Reverse( myArray );
         PrintMyArray( myArray );

         String[] myOtherArray = 
            {
                "We", "Hold", "These", "Truths",
                "To", "Be", "Self","Evident", 
            };

         PrintMyArray( myOtherArray );
         Array.Sort( myOtherArray );
         PrintMyArray( myOtherArray );

      }
   }
}
