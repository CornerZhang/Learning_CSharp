#region Using directives

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

#endregion

namespace usingStatement
{
   class Tester
   {
      public static void Main()
      {
         using ( Font theFont = new Font( "Arial", 10.0f ) )
         {
            // use theFont

         }   // compiler will call Dispose on theFont

         Font anotherFont = new Font( "Courier", 12.0f );

         using ( anotherFont )
         {
            // use anotherFont

         }  // compiler calls Dispose on anotherFont
      }
   }
}
