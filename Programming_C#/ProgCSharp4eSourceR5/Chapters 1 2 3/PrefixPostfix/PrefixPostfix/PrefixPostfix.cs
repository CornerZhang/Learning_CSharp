#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace PrefixPostfix
{
   class PrefixPostfix
   {
      static void Main( string[] args )
      {
         int valueOne = 10;
         int valueTwo;
         valueTwo = valueOne++;
         Console.WriteLine( "After postfix: {0}, {1}", valueOne,
         valueTwo );
         valueOne = 20;
         valueTwo = ++valueOne;
         Console.WriteLine( "After prefix: {0}, {1}", valueOne,
         valueTwo );

      }
   }
}
