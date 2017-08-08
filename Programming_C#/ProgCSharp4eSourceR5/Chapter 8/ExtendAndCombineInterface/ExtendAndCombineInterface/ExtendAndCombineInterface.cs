#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ExtendAndCombineInterface
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

// Extend the interface
   interface ILoggedCompressible : ICompressible
   {
      void LogSavedBytes();
   }

// Combine Interfaces
   interface IStorableCompressible : IStorable, ILoggedCompressible
   {
      void LogOriginalSize();
   }

// yet another interface
   interface IEncryptable
   {
      void Encrypt();
      void Decrypt();
   }

   public class Document : IStorableCompressible, IEncryptable
   {

      // hold the data for IStorable's Status property
      private int status = 0;

      // the document constructor
      public Document( string s )
      {
         Console.WriteLine( "Creating document with: {0}", s );

      }

      // implement IStorable
      public void Read()
      {
         Console.WriteLine(
            "Implementing the Read Method for IStorable" );
      }

      public void Write( object o )
      {
         Console.WriteLine(
            "Implementing the Write Method for IStorable" );
      }

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

      // implement ICompressible
      public void Compress()
      {
         Console.WriteLine( "Implementing Compress" );
      }

      public void Decompress()
      {
         Console.WriteLine( "Implementing Decompress" );
      }

      // implement ILoggedCompressible
      public void LogSavedBytes()
      {
         Console.WriteLine( "Implementing LogSavedBytes" );
      }

      // implement IStorableCompressible 
      public void LogOriginalSize()
      {
         Console.WriteLine( "Implementing LogOriginalSize" );
      }

      // implement IEncryptable
      public void Encrypt()
      {
         Console.WriteLine( "Implementing Encrypt" );

      }

      public void Decrypt()
      {
         Console.WriteLine( "Implementing Decrypt" );

      }
   }

   public class Tester
   {

      static void Main()
      {
         // create a document object
         Document doc = new Document( "Test Document" );

         // cast the document to the various interfaces
         IStorable isDoc = doc as IStorable;
         if ( isDoc != null )
         {
            isDoc.Read();
         }
         else
            Console.WriteLine( "IStorable not supported" );

         ICompressible icDoc = doc as ICompressible;
         if ( icDoc != null )
         {
            icDoc.Compress();
         }
         else
            Console.WriteLine( "Compressible not supported" );

         ILoggedCompressible ilcDoc = doc as ILoggedCompressible;
         if ( ilcDoc != null )
         {
            ilcDoc.LogSavedBytes();
            ilcDoc.Compress();
            // ilcDoc.Read();
         }
         else
            Console.WriteLine( "LoggedCompressible not supported" );

         IStorableCompressible isc = doc as IStorableCompressible;
         if ( isc != null )
         {
            isc.LogOriginalSize();  // IStorableCompressible
            isc.LogSavedBytes();    // ILoggedCompressible
            isc.Compress();         // ICompressible
            isc.Read();             // IStorable

         }
         else
         {
            Console.WriteLine( "StorableCompressible not supported" );
         }

         IEncryptable ie = doc as IEncryptable;
         if ( ie != null )
         {
            ie.Encrypt();
         }
         else
            Console.WriteLine( "Encryptable not supported" );
      }
   }
}
