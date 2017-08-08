/*
 * 操作符重载
 * logic: ==, !=, <, >, <=, >=
 * math: + - * /
 * assigment: =, +=, -+, *=, /=
 * converter: type x = (type)y
*/

using System;

namespace chap06_operator_overloading
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Fraction a = new Fraction(3, 4);
			Console.WriteLine( "a: {0}", a.ToString());	// RT-ToString()
			Fraction b = new Fraction(2, 4);
			Console.WriteLine( "b: {0}", b.ToString());

			Fraction c = a + b;	// operator +
			Console.WriteLine( "a + b = c: {0}", c.ToString() );

			Fraction d = c + 5;	// boxing
			Console.WriteLine( "c + 5 = d: {0}", d.ToString() );

			Fraction e = new Fraction( 2, 4 );
			if ( e == b )	// operator ==
			{
				Console.WriteLine( "e: {0} == b: {1}", e.ToString(), b.ToString() );
			}
			int ad = (int)e;
			Console.WriteLine ("ad: {0}", ad);
		}
	}
}
