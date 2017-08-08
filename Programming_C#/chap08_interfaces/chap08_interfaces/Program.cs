using System;
using SimpleInterface;
using System.Net.NetworkInformation;

public class Document: IStorableCompressible, IEncryptable
{
    private int status = 0;

    public int Status {
        get {
            return status;
        }
        set {
            status = value;
        }
    }

    public Document(string s) {
        Console.WriteLine ("Creating document with: {0}", s);
    }

    public void Read() {
        Console.WriteLine ("Implementing the Read Method for IStorable");
    }

    public void Write(Object obj) {
        Console.WriteLine ("Implementing the Write Method for IStorable");
    }

    public void Compress()
    {
        Console.WriteLine( "Implementing Compress" );
    }

    public void Decompress()
    {
        Console.WriteLine( "Implementing Decompress" );
    }

    public void LogSavedBytes()
    {
        Console.WriteLine( "Implementing LogSavedBytes" );
    }

    public void LogOriginalSize()
    {
        Console.WriteLine( "Implementing LogOriginalSize" );
    }

    public void Encrypt()
    {
        Console.WriteLine( "Implementing Encrypt" );

    }

    public void Decrypt()
    {
        Console.WriteLine( "Implementing Decrypt" );

    }

};

namespace chap08_interfaces
{
    class MainClass
    {
        public static void Main (string[] args)
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

            IStorable isDocument = (IStorable)doc;
            isDocument.Status = 0;
            isDocument.Read ();

            // error!
//            IStorable doc1 = new IStorable ();

            // OK!
            IStorable doc2 = new Document ("Test2 document");
            if (doc2) {
                doc2.Read ();
            }
        }
    }
}
