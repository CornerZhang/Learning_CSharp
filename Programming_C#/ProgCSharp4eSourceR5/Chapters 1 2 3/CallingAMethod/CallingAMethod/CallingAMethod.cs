#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CallingAMethod
{
	class CallingAMethod
	{
		static void Main()
		{
			Console.WriteLine("In Main! Calling SomeMethod( )...");
			SomeMethod();
			Console.WriteLine("Back in Main( ).");
		}
		static void SomeMethod()
		{
			Console.WriteLine("Greetings from SomeMethod!");
		}
	}
}
