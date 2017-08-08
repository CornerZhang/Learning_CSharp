#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace InitializingMultiDimensionalArray
{
   public class Tester
   {
      static void Main()
      {
         const int rows = 4;
         const int columns = 3;

         // imply a 4x3 array
         int[,] rectangularArray = 
            {
                {0,1,2}, {3,4,5}, {6,7,8}, {9,10,11}
            };

         for ( int i = 0; i < rows; i++ )
         {
            for ( int j = 0; j < columns; j++ )
            {
               Console.WriteLine( "rectangularArray[{0},{1}] = {2}",
                  i, j, rectangularArray[i, j] );
            }
         }
      }
   }
}
