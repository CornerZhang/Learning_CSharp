﻿#region Using directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Enumerable
{
   public class ListBoxTest : IEnumerable<String>
   {
      private string[] strings;
      private int ctr = 0;
      // Enumerable classes can return an enumerator
      public IEnumerator<string> GetEnumerator()
      {
         foreach ( string s in strings )
         {
            yield return s;
         }
	   }

      IEnumerator IEnumerable.GetEnumerator()
      {
         throw new NotImplementedException();
      }



	  // initialize the list box with strings
      public ListBoxTest( params string[] initialStrings )
      {
         // allocate space for the strings
         strings = new String[8];

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
         foreach ( string s in lbt )
         {
            Console.WriteLine( "Value: {0}", s );
         }
      }
   }
}
