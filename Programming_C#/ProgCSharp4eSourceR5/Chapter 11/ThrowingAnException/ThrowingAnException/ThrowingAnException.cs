#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace ThrowingAnException
{
   public class Test
   {
      public static void Main()
      {
         Console.WriteLine( "Enter Main..." );
         Test t = new Test();
         t.Func1();
         Console.WriteLine( "Exit Main..." );

      }

      public void Func1()
      {
         Console.WriteLine( "Enter Func1..." );
         Func2();
         Console.WriteLine( "Exit Func1..." );
      }

      public void Func2()
      {
         Console.WriteLine( "Enter Func2..." );
         throw new System.Exception();
         Console.WriteLine( "Exit Func2..." );
      }
   }
}
