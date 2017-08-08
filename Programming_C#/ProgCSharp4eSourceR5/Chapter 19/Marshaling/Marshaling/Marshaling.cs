#region Using directives

using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Reflection;
using System.Text;

#endregion

namespace Marshaling
{

   // for marshal by reference comment out
   // the attribute and uncomment the base class
  // [Serializable]
   public class Point   : MarshalByRefObject
   {
      private int x;
      private int y;

      public Point (int x, int y)
      {
         Console.WriteLine( "[{0}] {1}",
            System.AppDomain.CurrentDomain.FriendlyName, 
            "Point constructor");

         this.x = x;
         this.y = y;
      }

    
      public int X
      {
         get
         {
            Console.WriteLine( "[{0}] {1}",
               System.AppDomain.CurrentDomain.FriendlyName, 
               "Point x.get");

            return this.x;
         }

         set
         {
            Console.WriteLine( "[{0}] {1}",
               System.AppDomain.CurrentDomain.FriendlyName, 
               "Point x.set");
            this.x = value;
         }
      }

      public int Y
      {
         get
         {
            Console.WriteLine( "[{0}] {1}",
               System.AppDomain.CurrentDomain.FriendlyName, 
               "Point y.get");
            return this.y;
         }

         set
         {
            Console.WriteLine( "[{0}] {1}",
               System.AppDomain.CurrentDomain.FriendlyName, 
               "Point y.set");
            this.y = value;
         }
      }
   }

   // the shape class marshals by reference
   public class Shape : MarshalByRefObject
   {
      private Point upperLeft;

      public Shape(int upperLeftX, int upperLeftY)
      {
         Console.WriteLine( "[{0}] {1}",
            System.AppDomain.CurrentDomain.FriendlyName, 
            "Shape constructor");

         upperLeft = new Point(upperLeftX, upperLeftY);
      }
      public Point GetUpperLeft()
      {
         return upperLeft;
      }

      public void ShowUpperLeft()
      {
         Console.WriteLine( "[{0}] Upper left: {1},{2}",
            System.AppDomain.CurrentDomain.FriendlyName, 
            upperLeft.X, upperLeft.Y);
      }
   }
   public class Tester
   {
      public static void Main()
      {

         Console.WriteLine( "[{0}] {1}",
            System.AppDomain.CurrentDomain.FriendlyName, 
            "Entered Main");
                           
         // create the new app domain
         AppDomain ad2 = 
            AppDomain.CreateDomain("Shape Domain");
    
         //  Assembly a = Assembly.LoadFrom("ProgCSharp.exe");
         //  Object theShape = a.CreateInstance("Shape");
         // instantiate a Shape object
         ObjectHandle oh = ad2.CreateInstance( 
            "Marshaling",
            "Marshaling.Shape", false,
            System.Reflection.BindingFlags.CreateInstance,
            null, new object[] {3, 5},
            null, null, null );

         Shape s1 = (Shape) oh.Unwrap();

         s1.ShowUpperLeft();     // ask the object to display

         // get a local copy? proxy?
         Point localPoint = s1.GetUpperLeft();

         // assign new values
         localPoint.X = 500;
         localPoint.Y = 600;

         // display the value of the local Point object
         Console.WriteLine( "[{0}] localPoint: {1}, {2}",
            System.AppDomain.CurrentDomain.FriendlyName, 
            localPoint.X, localPoint.Y);

         s1.ShowUpperLeft();     // show the value once more
      }
   }
}
