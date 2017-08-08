#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UsingGoTo
{
   class UsingGoTo
   {
      static void Main( string[] args )
      {
         int i = 0;
      repeat:            // the label
         Console.WriteLine( "i: {0}", i );
         i++;
         if ( i < 10 )
            goto repeat;  // the dastardly deed
         return;
      }
   }
}