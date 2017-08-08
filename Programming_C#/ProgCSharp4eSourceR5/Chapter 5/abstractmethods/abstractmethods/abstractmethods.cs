#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace abstractmethods
{
   using System;


   abstract public class Window
   {
      protected int top;
      protected int left;

      // constructor takes two integers to
      // fix location on the console
      public Window( int top, int left )
      {
         this.top = top;
         this.left = left;
      }

      // simulates drawing the window
      // notice: no implementation

      abstract public void DrawWindow();

   }

// ListBox derives from Window
   public class ListBox : Window
   {
      private string listBoxContents;  // new member variable

      // constructor adds a parameter
      public ListBox(
         int top,
         int left,
         string contents ):
      base(top, left)  // call base constructor
      {

         listBoxContents = contents;
      }

      // an overridden version implementing the
      // abstract method

      public override void DrawWindow()
      {

         Console.WriteLine( "Writing string to the listbox: {0}",
            listBoxContents );
      }

   }

   public class Button : Window
   {
      public Button(
         int top,
         int left ):
      base(top, left)
      {
      }

      // implement the abstract method

      public override void DrawWindow()
      {
         Console.WriteLine( "Drawing a button at {0}, {1}\n",
            top, left );
      }

   }

   public class Tester
   {
      static void Main()
      {
         Window[] winArray = new Window[3];
         winArray[0] = new ListBox( 1, 2, "First List Box" );
         winArray[1] = new ListBox( 3, 4, "Second List Box" );
         winArray[2] = new Button( 5, 6 );

         for ( int i = 0; i < 3; i++ )
         {
            winArray[i].DrawWindow();
         }
      }
   }
}
