#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace StructWithoutNew
{
   public struct Location
   {
      public int xVal;
      public int yVal;

      public Location( int xCoordinate, int yCoordinate )
      {
         xVal = xCoordinate;
         yVal = yCoordinate;
      }
      public int x
      {
         get
         {
            return xVal;
         }
         set
         {
            xVal = value;
         }
      }

      public int y
      {
         get
         {
            return yVal;
         }
         set
         {
            yVal = value;
         }
      }

      public override string ToString()
      {
         return ( String.Format( "{0}, {1}", xVal, yVal ) );
      }
   }

   public class Tester
   {
      static void Main()
      {

         Location loc1;         // no call to the constructor

         loc1.xVal = 75;        // initialize the members
         loc1.yVal = 225;
         Console.WriteLine( loc1 );
      }
   }
}
