#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

#endregion

namespace ReadingWebPageAsHTML
{
   public class Client
   {

      static public void Main( string[] Args )
      {

         // create a webRequest for a particular page
         HttpWebRequest webRequest =
            ( HttpWebRequest ) WebRequest.Create
            ( "http://www.libertyassociates.com/ ");

         // ask the web request for a webResponse encapsulating
         // that page
         HttpWebResponse webResponse =
            ( HttpWebResponse ) webRequest.GetResponse();

         // get the streamReader from the response
         StreamReader streamReader = new StreamReader(
            webResponse.GetResponseStream(), Encoding.ASCII );

         try
         {
            string outputString;
            outputString = streamReader.ReadToEnd();
            Console.WriteLine( outputString );
         }
         catch
         {
            Console.WriteLine( "Exception reading from web page" );
         }
         streamReader.Close();

      }
   }
}