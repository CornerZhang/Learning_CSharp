using System;

namespace ClassFoundation
{
	abstract public class Control
	{
		protected int top;
		protected int left;

		public Control (int top, int left) {
			this.top = top;
			this.left = left;
		}

		abstract public void DrawWindow ();
	};

	public class ListBox: Control
	{
		private string listBoxContents;


		public ListBox(int top, int left, string contents) : base(top, left) {
			listBoxContents = contents;
		}

		public override void DrawWindow() {

			Console.WriteLine ("Writing string to the listbox: {0}", listBoxContents);
		}
	};

	public class Button: Control
	{
		public Button(int top, int left ) : base(top, left) {
		}

		public override void DrawWindow() {
			Console.WriteLine ("Drawing a button at {0}, {1}", top, left);
		}
	};

	sealed public class MenuItem: Control
	{
		public MenuItem(int top, int left): base(top, left) {
		}

		public override void DrawWindow() {
			Console.WriteLine ("Drawing a MenuItem at {0}, {1}", top, left);
		}
	};

	public class SomeClass
	{
		private int val;

		public SomeClass(int someValue) {
			val = someValue;
		}

		public override string ToString ()
		{
			return val.ToString ();
		}
	};

    public class Counter
    {
        private int _count;
        private static int _totalCount;

        public int GetNextValue() {
            _count += 1;
            _totalCount += 1;
            return _count;
        }

        public static int TotalCount {
            get { return _totalCount; }
        }
    };
}

