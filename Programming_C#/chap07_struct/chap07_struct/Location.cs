using System;
using System.Text;

namespace chap07_struct
{
	public struct Location
	{
		private int xVal;
		private int yVal;

		public Location() {
			xVal = 0;
			yVal = 0;
		}

		public Location(int xCoordinate, int yCoordinate) {
			xVal = xCoordinate;
			yVal = yCoordinate;
		}

		public int x {
			get
			{
				return xVal;
			}
			set
			{
				xVal = value;
			}
		}


		public int y {
			get {
				return yVal;
			}
			set {
				yVal = value;
			}
		}

		public override string ToString ()
		{
			return String.Format ("[Location: x={0}, y={1}]", xVal, yVal);
		}
	};

	public class Tester
	{
		public void MyFunc( Location loc ) {	// value-copy on parameter
			loc.x = 50;
			loc.y = 100;
			Console.WriteLine ("In MyFunc loc: {0}", loc);
		}

		public static void UnitTest() {
			Location loc1 = new Location (200, 300);	// alloc on stack
			Console.WriteLine ("Loc1 location: {0}", loc1);
			Tester t = new Tester ();	// alloc on heap
			t.MyFunc (loc1);
			Console.WriteLine ("Loc1 location: {0}", loc1);


		}
			
	};
}

