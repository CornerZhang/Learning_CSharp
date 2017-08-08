using System;
using ClassFoundation;
using System.Runtime.Remoting.Messaging;

namespace chap05_test
{
	// Error! MenuItem is sealed
//	class SettingMenu: MenuItem
//	{
//	};

	class MainClass
	{


		public static void Main (string[] args)
		{
            
			Control[] winArray = new Control[3];
			winArray [0] = new ListBox (1, 2, "First List Box");
			winArray [1] = new ListBox (3, 4, "Second List Box");
			winArray [2] = new Button (5, 6);
			for (int i = 0; i < 3; i++) {
				winArray [i].DrawWindow ();
			}

			string typeName = winArray [0].ToString();

			int iValue=5;
			Console.WriteLine("The value of i is: {0}", iValue.ToString());
			DisplayValue (iValue);

			SomeClass s = new SomeClass (7);
			Console.WriteLine ("The value of s is {0}", s.ToString ());
			DisplayValue (s);

			int integer = 123;
			object o = integer;	// boxing
			int j = (int)o;	// unboxing

            var counter = new Counter();
            counter.GetNextValue ();
            var t = Counter.TotalCount;

		}

		static void DisplayValue(object o) {
			Console.WriteLine ("The value of the object passed in is {0}", o.ToString ());
		}
	}
}
