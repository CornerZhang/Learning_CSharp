#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomAttributes
{
   // create custom attribute to be assigned to class members
   [AttributeUsage( AttributeTargets.Class |
       AttributeTargets.Constructor |
       AttributeTargets.Field |
       AttributeTargets.Method |
       AttributeTargets.Property,
       AllowMultiple = true )]
   public class BugFixAttribute : System.Attribute
   {

      // private member data 
      private int bugID;
      private string comment;
      private string date;
      private string programmer;

      // attribute constructor for 
      // positional parameters
      public BugFixAttribute
         ( int bugID,
         string programmer,
         string date )
      {
         this.bugID = bugID;
         this.programmer = programmer;
         this.date = date;
      }

      // accessor
      public int BugID
      {
         get
         {
            return bugID;
         }
      }

      // property for named parameter
      public string Comment
      {
         get
         {
            return comment;
         }
         set
         {
            comment = value;
         }
      }

      // accessor
      public string Date
      {
         get
         {
            return date;
         }
      }

      // accessor
      public string Programmer
      {
         get
         {
            return programmer;
         }
      }
   }


   // ********* assign the attributes to the class ********

   [BugFixAttribute( 121, "Jesse Liberty", "01/03/05" )]
   [BugFixAttribute( 107, "Jesse Liberty", "01/04/05",
       Comment = "Fixed off by one errors" )]
   public class MyMath
   {

      public double DoFunc1( double param1 )
      {
         return param1 + DoFunc2( param1 );
      }

      public double DoFunc2( double param1 )
      {
         return param1 / 3;
      }

   }

   public class Tester
   {
//      public static void Main()
//      {
//         MyMath mm = new MyMath();
//         Console.WriteLine( "Calling DoFunc(7). Result: {0}",
//            mm.DoFunc1( 7 ) );
//      }
      public static void Main()
      {
         MyMath mm = new MyMath();
         Console.WriteLine( "Calling DoFunc(7). Result: {0}",
             mm.DoFunc1( 7 ) );

         // get the member information and use it to
         // retrieve the custom attributes
         System.Reflection.MemberInfo inf = typeof( MyMath );
         object[] attributes;
         attributes =
            inf.GetCustomAttributes(
                 typeof( BugFixAttribute ), false );

         // iterate through the attributes, retrieving the 
         // properties
         foreach ( Object attribute in attributes )
         {
            BugFixAttribute bfa = ( BugFixAttribute ) attribute;
            Console.WriteLine( "\nBugID: {0}", bfa.BugID );
            Console.WriteLine( "Programmer: {0}", bfa.Programmer );
            Console.WriteLine( "Date: {0}", bfa.Date );
            Console.WriteLine( "Comment: {0}", bfa.Comment );
         }
      }

   }
}
