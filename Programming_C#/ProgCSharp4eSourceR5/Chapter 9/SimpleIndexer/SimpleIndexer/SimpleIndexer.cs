#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SimpleIndexer
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
         if ( ctr >= strings.Length )
         {
            // handle bad index
         }
         else
            strings[ctr++] = theString;
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
            // add only through the add method
            if ( index >= ctr )
            {
               // handle error
            }
            else
               strings[index] = value;
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

         // access all the strings
         for ( int i = 0; i < lbt.GetNumEntries(); i++ )
         {
            Console.WriteLine( "lbt[{0}]: {1}", i, lbt[i] );
         }
      }
   }
}
