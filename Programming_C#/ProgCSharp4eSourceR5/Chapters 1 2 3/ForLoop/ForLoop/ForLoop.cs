#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ForLoop
{
   class ForLoop
   {
      static void Main( string[] args )
      {
         for ( int i = 0; i < 100; i++ )
         {
            Console.Write( "{0} ", i );

            if ( i % 10 == 0 )
            {
               Console.WriteLine( "\t{0}", i );
            }
         }
         return ;
      }
   }
}
