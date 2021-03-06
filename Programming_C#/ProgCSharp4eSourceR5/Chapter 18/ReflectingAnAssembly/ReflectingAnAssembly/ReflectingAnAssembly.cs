﻿#region Using directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace ReflectingAnAssembly
{
   public class Tester
   {
      public static void Main()
      {
         // what is in the assembly
         Assembly a = Assembly.Load( "Mscorlib.dll" );
         Type[] types = a.GetTypes();
         foreach ( Type t in types )
         {
            Console.WriteLine( "Type is {0}", t );
         }
         Console.WriteLine(
            "{0} types found", types.Length );
      }
   }
}
