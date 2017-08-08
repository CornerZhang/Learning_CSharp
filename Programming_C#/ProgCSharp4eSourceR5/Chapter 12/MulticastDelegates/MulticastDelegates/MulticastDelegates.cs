#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace MulticastDelegates
{
   public class MyClassWithDelegate
   {
      // the delegate declaration
      public delegate void StringDelegate( string s );

   }

   public class MyImplementingClass
   {
      public static void WriteString( string s )
      {
         Console.WriteLine( "Writing string {0}", s );
      }

      public static void LogString( string s )
      {
         Console.WriteLine( "Logging string {0}", s );
      }

      public static void TransmitString( string s )
      {
         Console.WriteLine( "Transmitting string {0}", s );
      }

   }


   public class Test
   {
      public static void Main()
      {
         // define three StringDelegate objects
         MyClassWithDelegate.StringDelegate
            Writer, Logger, Transmitter;

         // define another StringDelegate
         // to act as the multicast delegate
         MyClassWithDelegate.StringDelegate
            myMulticastDelegate;

         // Instantiate the first three delegates, 
         // passing in methods to encapsulate
         Writer = new MyClassWithDelegate.StringDelegate(
            MyImplementingClass.WriteString );
         Logger = new MyClassWithDelegate.StringDelegate(
            MyImplementingClass.LogString );
         Transmitter =
            new MyClassWithDelegate.StringDelegate(
            MyImplementingClass.TransmitString );

         // Invoke the Writer delegate method
         Writer( "String passed to Writer\n" );

         // Invoke the Logger delegate method 
         Logger( "String passed to Logger\n" );

         // Invoke the Transmitter delegate method
         Transmitter( "String passed to Transmitter\n" );

         // Tell the user you are about to combine
         // two delegates into the multicast delegate
         Console.WriteLine(
            "myMulticastDelegate = Writer + Logger" );

         // combine the two delegates, the result is
         // assigned to myMulticast Delegate
         myMulticastDelegate = Writer + Logger;

         // Call the delegated methods, two methods
         // will be invoked
         myMulticastDelegate(
            "First string passed to Collector" );

         // Tell the user you are about to add
         // a third delegate to the multicast
         Console.WriteLine(
            "\nmyMulticastDelegate += Transmitter" );

         // add the third delegate
         myMulticastDelegate += Transmitter;

         // invoke the three delegated methods
         myMulticastDelegate(
            "Second string passed to Collector" );

         // tell the user you are about to remove
         // the logger delegate
         Console.WriteLine(
            "\nmyMulticastDelegate -= Logger" );

         // remove the logger delegate
         myMulticastDelegate -= Logger;

         // invoke the two remaining 
         // delegated methods
         myMulticastDelegate(
            "Third string passed to Collector" );
      }
   }
}
