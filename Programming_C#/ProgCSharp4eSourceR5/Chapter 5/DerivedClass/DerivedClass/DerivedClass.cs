#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DerivedClass
{
   public class Control
   {
      // these members are private and thus invisible
      // to derived class methods; we'll examine this 
      // later in the chapter
      private int top;
      private int left;

      // constructor takes two integers to
      // fix location on the console
      public Control( int top, int left )
      {
         this.top = top;
         this.left = left;
      }

      // simulates drawing the window
      public virtual void DrawWindow()
      {
         Console.WriteLine( "Drawing Window at {0}, {1}",
            top, left );
      }
   }

// ListBox derives from Window
   public class ListBox : Control
   {
      private string mListBoxContents;  // new member variable

      // constructor adds a parameter
      public ListBox(
         int top,
         int left,
         string theContents ):
      base(top, left)  // call base constructor
      {
         mListBoxContents = theContents;
      }

      // a new version (note keyword) because in the
      // derived method we change the behavior
      public override void DrawWindow()
      {
         base.DrawWindow();  // invoke the base method
         Console.WriteLine( "Writing string to the listbox: {0}",
            mListBoxContents );
      }
   }

   public class Tester
   {
      public static void Main()
      {
         // create a base instance
         Control w = new Control( 5, 10 );
         w.DrawWindow();

         // create a derived instance
         ListBox lb = new ListBox( 20, 30, "Hello world" );
         lb.DrawWindow();
      }
   }
}
