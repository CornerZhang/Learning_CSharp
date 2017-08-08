#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ExplicitImplementation
{
   interface IStorable
   {
      void Read();
      void Write();
   }

   interface ITalk
   {
      void Talk();
      void Read();
   }

// Modify Document to implement IStorable and ITalk
   public class Document : IStorable, ITalk
   {
      // the document constructor
      public Document( string s )
      {
         Console.WriteLine( "Creating document with: {0}", s );

      }

      // Make read virtual
      public virtual void Read()
      {
         Console.WriteLine( "Implementing IStorable.Read" );
      }

      public void Write()
      {
         Console.WriteLine( "Implementing IStorable.Write" );

      }

      void ITalk.Read()
      {
         Console.WriteLine( "Implementing ITalk.Read" );
      }

      public void Talk()
      {
         Console.WriteLine( "Implementing ITalk.Talk" );
      }

   }


   public class Tester
   {

      static void Main()
      {
         // create a document object
         Document theDoc = new Document( "Test Document" );
         IStorable isDoc = theDoc;
         isDoc.Read();

         ITalk itDoc = theDoc;
         itDoc.Read();

         theDoc.Read();
         theDoc.Talk();

      }

   }
}
