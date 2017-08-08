#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace OverloadedIndexer
{
   // a simplified ListBox control
   public class ListBoxTest
   {
      private string[] strings;
      private int ctr = 0;

      // initialize the list box with strings
      public ListBoxTest( params string[] initialStrings )
      {
         // allocate space for the strings
         strings = new String[256];

         // copy the strings passed in to the constructor
         foreach ( string s in initialStrings )
         {
            strings[ctr++] = s;
         }
      }

      // add a single string to the end of the list box
      public void Add( string theString )
      {
         strings[ctr] = theString;
         ctr++;
      }


      // allow array-like access
      public string this[int index]
      {
         get
         {
            if ( index < 0 || index >= strings.Length )
            {
               // handle bad index
            }
            return strings[index];
         }
         set
         {
            strings[index] = value;
         }
      }

      private int findString( string searchString )
      {
         for ( int i = 0; i < strings.Length; i++ )
         {
            if ( strings[i].StartsWith( searchString ) )
            {
               return i;
            }
         }
         return -1;
      }

      // index on string
      public string this[string index]
      {
         get
         {
            if ( index.Length == 0 )
            {
               // handle bad index
            }

            return this[findString( index )];
         }
         set
         {
            strings[findString( index )] = value;
         }
      }



      // publish how many strings you hold
      public int GetNumEntries()
      {
         return ctr;
      }
   }

   public class Tester
   {
      static void Main()
      {
         // create a new list box and initialize
         ListBoxTest lbt =
            new ListBoxTest( "Hello", "World" );

         // add a few strings
         lbt.Add( "Who" );
         lbt.Add( "Is" );
         lbt.Add( "John" );
         lbt.Add( "Galt" );

         // test the access
         string subst = "Universe";
         lbt[1] = subst;
         lbt["Hel"] = "GoodBye";
         // lbt["xyz"] = "oops";

         // access all the strings
         for ( int i = 0; i < lbt.GetNumEntries(); i++ )
         {
            Console.WriteLine( "lbt[{0}]: {1}", i, lbt[i] );
         }      // end for
      }         // end main
   }            // end tester
}
