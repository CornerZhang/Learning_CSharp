#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AssigningWithoutInitializing
{
	class AssigningWithoutInitializing
	{
		static void Main(string[] args)
		{
			int myInt;
			myInt = 7;
			System.Console.WriteLine("Assigned, myInt: {0}", myInt);
			myInt = 5;
			System.Console.WriteLine("Reassigned, myInt: {0}", myInt);

		}
	}
}
