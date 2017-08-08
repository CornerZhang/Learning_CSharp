#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace NestedIf
{
   class NestedIf
   {
      static void Main()
      {
         int temp = 32;

         if ( temp <= 32 )
         {
            Console.WriteLine( "Warning! Ice on road!" );
            if ( temp == 32 )
            {
               Console.WriteLine(
                  "Temp exactly freezing, beware of water." );
            }
            else
            {
               Console.WriteLine( "Watch for black ice! Temp: {0}", temp );
            }		// end else
         }			// end if (temp <= 32)
      }				// end main
   }					// end class
}						// end namespace
