#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SettingArrayBounds
{

   public class SettingArrayBounds
   {
      public static void CreateArrayWithBounds()
      {
         // Creates and initializes a multidimensional Array of type String.
         int[] lengthsArray = new int[2] { 3, 5 };
         int[] boundsArray = new int[2] { 2, 3 };
         Array multiDimensionalArray = Array.CreateInstance( typeof( String ), lengthsArray, boundsArray );

         // Displays the lower bounds and the upper bounds of each dimension.
         Console.WriteLine( "Bounds:\tLower\tUpper" );
         for ( int i = 0; i < multiDimensionalArray.Rank; i++ )
            Console.WriteLine( "{0}:\t{1}\t{2}", i, multiDimensionalArray.GetLowerBound( i ), multiDimensionalArray.GetUpperBound( i ) );

      }
      static void Main()
      {
         SettingArrayBounds.CreateArrayWithBounds();
      }
   }
}



