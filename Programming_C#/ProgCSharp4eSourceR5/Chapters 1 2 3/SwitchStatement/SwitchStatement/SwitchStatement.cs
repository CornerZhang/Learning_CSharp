#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SwitchStatement
{
   class SwitchStatement
   {
      static void Main( string[] args )
      {
         const int Democrat = 0;
         const int LiberalRepublican = 1;
         const int Republican = 2;
         const int Libertarian = 3;
         const int NewLeft = 4;
         const int Progressive = 5;

         int myChoice = Libertarian;

         switch ( myChoice )
         {
            case Democrat:
               Console.WriteLine( "You voted Democratic.\n" );
               break;
            case LiberalRepublican:  // fall through
            //Console.WriteLine(
            //"Liberal Republicans vote Republican\n");
            case Republican:
               Console.WriteLine( "You voted Republican.\n" );
               break;
            case NewLeft:
               Console.WriteLine( "NewLeft is now Progressive" );
               goto case Progressive;
            case Progressive:
               Console.WriteLine( "You voted Progressive.\n" );
               break;
            case Libertarian:
               Console.WriteLine( "Libertarians are voting Republican" );
               goto case Republican;
            default:
               Console.WriteLine( "You did not pick a valid choice.\n" );
               break;
         }

         Console.WriteLine( "Thank you for voting." );

      }
   }
}
