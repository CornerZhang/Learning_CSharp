#region Using directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace ReflectingOnAType
{
   public class Tester
   {
      public static void Main()
      {
         // examine a single object
         Type theType =
            Type.GetType(
               "System.Reflection.Assembly" );
         Console.WriteLine(
            "\nSingle Type is {0}\n", theType );
      }
   }
}
