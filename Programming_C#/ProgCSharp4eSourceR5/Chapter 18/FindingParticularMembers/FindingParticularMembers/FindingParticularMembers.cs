#region Using directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace FindingParticularMembers
{
   public class Tester
   {
      public static void Main()
      {
         // examine a single object
         Type theType = Type.GetType(
            "System.Reflection.Assembly" );

         // just members which are methods beginning with Get
         MemberInfo[] mbrInfoArray =
            theType.FindMembers( MemberTypes.Method,
               BindingFlags.Public |
               BindingFlags.Static |
               BindingFlags.NonPublic |
               BindingFlags.Instance |
               BindingFlags.DeclaredOnly,
               Type.FilterName, "Get*" );
         foreach ( MemberInfo mbrInfo in mbrInfoArray )
         {
            Console.WriteLine( "{0} is a {1}",
               mbrInfo, mbrInfo.MemberType );
         }
      }
   }
}
