#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace UninitializedVariable
{
	class UninitializedVariable
	{
		static void Main(string[] args)
		{
			int myInt;
			System.Console.WriteLine
			("Uninitialized, myInt: {0}", myInt);
			myInt = 5;
			System.Console.WriteLine("Assigned, myInt: {0}", myInt);

		}
	}
}
