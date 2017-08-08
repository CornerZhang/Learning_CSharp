using System;

namespace chap06_operator_overloading
{
	public class Fraction
	{
		private int numerator;
		private int denominator;

		public Fraction( int numerator, int denominator )
		{
			Console.WriteLine( "In Fraction Constructor(int, int)" );
			this.numerator = numerator;
			this.denominator = denominator;
		}

		public Fraction( int wholeNumber )
		{
			Console.WriteLine( "In Fraction Constructor(int)" );
			numerator = wholeNumber;
			denominator = 1;
		}
			
		public static Fraction operator + (Fraction lhs, Fraction rhs) {
			Console.WriteLine( "In operator+" );
			if (lhs.denominator == rhs.denominator) {
				return new Fraction (lhs.numerator + rhs.numerator, lhs.denominator);
			}

			int firstProduct = lhs.numerator * rhs.denominator;
			int secondProduct = rhs.numerator * lhs.denominator;
			return new Fraction (firstProduct + secondProduct, lhs.denominator + rhs.denominator);
		}

		// boxing
		public static implicit operator Fraction( int theInt ) {
			Console.WriteLine( "In implicit conversion to Fraction" );
			return new Fraction (theInt);
		}

		// unboxing-int
		public static explicit operator int(Fraction theFraction) {
			Console.WriteLine( "In explicit conversion to int" );
			return theFraction.numerator / theFraction.denominator;
		}

		// ==
		public static bool operator == (Fraction lhs, Fraction rhs) {
			Console.WriteLine( "In operator ==" );
			if (lhs.denominator == rhs.denominator &&
			    lhs.numerator == rhs.numerator) {
				return true;
			} else {
				return false;
			}
			
		}

		// !=
		public static bool operator != (Fraction lhs, Fraction rhs) {
			Console.WriteLine( "In operator !=" );
			return !(lhs == rhs);
		}

		// runtime-Equals
		public override bool Equals(object o) {
			Console.WriteLine( "In method Equals" );
			if (!(o is Fraction)) {
				return false;
			}
			return this == (Fraction)o;
		}

		// runtime-ToString
		public override string ToString ()
		{
			string s = numerator.ToString () + "/" + denominator.ToString ();
			return s;
		}
	}
}

