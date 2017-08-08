#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace InitializingVariables
{
	class Values
	{
		static void Main()
		{

			int myInt = 7;
			System.Console.WriteLine("Initialized, myInt: {0}",
			   myInt);

			myInt = 5;
			System.Console.WriteLine("After assignment, myInt: {0}",
			   myInt);

			

		}
	}

}
