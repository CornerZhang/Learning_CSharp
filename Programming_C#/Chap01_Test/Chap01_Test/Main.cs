// first program

using System;
using Ext1;

class Hello {

	// static void Main ();

	static int Main(string[] args) {
		/* use console system to stdout
		 * multi-lines comments
		 */
		ExtWorking ();

		System.Console.WriteLine ("Hello world!");

		return 0;
	}

	static void ExtWorking() {
		Ext1.BaseClass obj = new Ext1.BaseClass ();
		obj.Done ();

	}
}