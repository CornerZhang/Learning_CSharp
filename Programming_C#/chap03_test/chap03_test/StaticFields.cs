using System;
using System.Collections.Generic;
using System.Text;

namespace StaticFields
{
	public class Cat
	{
		private static int instances = 0;

		// ctor
		public Cat ()
		{
			instances++;
		}

		// dtor
		~Cat () {	// default as public access
			--instances;
		}

		public static void HowManyCats ()
		{
			Console.WriteLine ("{0} cats adopted", instances);
		}
	};

	public class Tester
	{
		// static ctor, be call once
		static Tester () {
			Cat.HowManyCats ();
			Cat firsky = new Cat ();
			Cat.HowManyCats ();
			Cat whiskers = new Cat ();
			Cat.HowManyCats ();

			firsky = null;
			whiskers = null;
		}
	};

}

