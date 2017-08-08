#region Using directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace ReflectingOnMembersOfAType
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

         // get all the members
         MemberInfo[] mbrInfoArray =
            theType.GetMembers();
         foreach ( MemberInfo mbrInfo in mbrInfoArray )
         {
            Console.WriteLine( "{0} is a {1}",
               mbrInfo, mbrInfo.MemberType );
         }
      }
   }
}
