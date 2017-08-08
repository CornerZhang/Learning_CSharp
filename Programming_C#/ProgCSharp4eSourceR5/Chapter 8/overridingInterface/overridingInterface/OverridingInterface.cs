#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace overridingInterface
{
   interface IStorable
   {
      void Read();
      void Write();
   }

// Simplify Document to implement only IStorable
   public class Document : IStorable
   {
      // the document constructor
      public Document( string s )
      {
         Console.WriteLine(
            "Creating document with: {0}", s );

      }

      // Make read virtual

      public virtual void Read()
      {
         Console.WriteLine(
            "Document Read Method for IStorable" );
      }

      // NB: Not virtual!
      public void Write()
      {
         Console.WriteLine(
            "Document Write Method for IStorable" );
      }

   }

// Derive from Document
   public class Note : Document
   {
      public Note( string s ):
      base(s)
      {
         Console.WriteLine(
            "Creating note with: {0}", s );
      }

      // override the Read method

      public override void Read()
      {
         Console.WriteLine(
            "Overriding the Read method for Note!" );
      }

      // implement my own Write method
      public new void Write()
      {
         Console.WriteLine(
            "Implementing the Write method for Note!" );
      }
   }
   public class Tester
   {

      static void Main()
      {
         // create a document object
         Document theNote = new Note( "Test Note" );
         IStorable isNote = theNote as IStorable;
         if ( isNote != null )
         {
            isNote.Read();
            isNote.Write();
         }

         Console.WriteLine( "\n" );

         // direct call to the methods
         theNote.Read();
         theNote.Write();

         Console.WriteLine( "\n" );

         // create a note object
         Note note2 = new Note( "Second Test" );
         IStorable isNote2 = note2 as IStorable;
         if ( isNote2 != null )
         {
            isNote2.Read();
            isNote2.Write();
         }

         Console.WriteLine( "\n" );

         // directly call the methods
         note2.Read();
         note2.Write();
      }
   }
}
