#region Using directives

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

#endregion

namespace DynamicallyInvokingAMethod
{
   public class Tester
   {
      public static void Main()
      {
         Type theMathType = Type.GetType( "System.Math" );
         // Since System.Math has no public constructor, this
         // would throw an exception.
         //Object theObj = 
         //   Activator.CreateInstance(theMathType);

         // array with one member
         Type[] paramTypes = new Type[1];
         paramTypes[0] = Type.GetType( "System.Double" );

         // Get method info for Cos()
         MethodInfo CosineInfo =
            theMathType.GetMethod( "Cos", paramTypes );

         // fill an array with the actual parameters
         Object[] parameters = new Object[1];
         parameters[0] = 45 * ( Math.PI / 180 ); // 45 degrees in radians
         Object returnVal =
            CosineInfo.Invoke( theMathType, parameters );
         Console.WriteLine(
            "The cosine of a 45 degree angle {0}",
            returnVal );

      }
   }
}
