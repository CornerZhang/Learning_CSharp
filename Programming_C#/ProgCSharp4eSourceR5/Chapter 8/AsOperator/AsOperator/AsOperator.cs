#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AsOperator
{
   interface IStorable
   {
      void Read();
      void Write( object obj );
      int Status { get; set; }

   }

// here's the new interface
   interface ICompressible
   {
      void Compress();
      void Decompress();
   }



// Document implements IStorable
   public class Document : IStorable
   {

      private int status = 0;

      public Document( string s )
      {
         Console.WriteLine(
            "Creating document with: {0}", s );

      }

      // IStorable.Read
      public void Read()
      {
         Console.WriteLine( "Reading...");
      }

      // IStorable.Write
      public void Write( object o )
      {
         Console.WriteLine( "Writing...");
      }

      // IStorable.Status
      public int Status
      {
         get
         {
            return status;
         }

         set
         {
            status = value;
         }
      }
   }

	// derives from Document and implements ICompressible
	public class CompressibleDocument : Document, ICompressible
	{
		public CompressibleDocument(String s) :
			base(s)
		{ }

		public void Compress()
		{
			Console.WriteLine("Compressing...");
		}
		public void Decompress()
		{
			Console.WriteLine("Decompressing...");
		}


	}


   public class Tester
   {

      static void Main()
      {
		  // A collection of Documents
		  Document[] docArray = new Document[2];

		  // First entry is a Document
		  docArray[0] = new Document( "Test Document" );

		  // Second entry is a CompressibleDocument (ok because 
		  // CompressibleDocument is a Document)
		  docArray[1] = new CompressibleDocument("Test compressibleDocument");


		  // don't know what we'll pull out of this hat
		  foreach (Document doc in docArray)
		  {
			  // report your name
			  Console.WriteLine("Got: {0}", doc);

			  // Both pass this test
			  IStorable isDoc = doc as IStorable;
			  if (isDoc != null)
			  {
				  isDoc.Read();
			  }

			  // fails for Document
			  // passes for CompressibleDocument
			  ICompressible icDoc = doc as ICompressible;
			  if (icDoc != null)
			  {
				  icDoc.Compress();

			  }
		  }
	  }
   }
}
