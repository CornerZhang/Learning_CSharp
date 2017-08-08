#define DEBUG_SYM	// 必须在文件最前头

using System;
using StaticFields;
using Utility;

public enum Temperatures {
	WickedCold = 0,
	BoilingPoint = 212
};

enum Weekday {
	Mon = 1,
	Tur,
	Wen
};

class MyDefinedClass {
	private static readonly int classNumber;

	private int countNumber;

	// property
	public int totalNumber {
		get {
			return countNumber;
		}
		set {	// 默认参数名value
			countNumber = value;
		}
	}

	static MyDefinedClass() {
		classNumber = 0;

		System.Console.WriteLine ("MyDefinedClass - static ctor");	
	}

	public MyDefinedClass() {
		this.countNumber = 0;
	}

	public MyDefinedClass(int ready) {	// overload
	}

	public int ReadyGo(int a) {
		return countNumber;
	}

	public int ReadyGo() {	// overload
		return 0;
	}

	// error!!!
//	public long ReadyGo() {
//		return 0;
//	}

	public void Close(object a) {
	}
}

namespace chap03_test
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Tester test = new Tester ();

			MyDefinedClass obj = new MyDefinedClass ();	// 也可以 = null;
			int getValue = obj.ReadyGo (0);
			MyDefinedClass objAnother = obj;
			objAnother.ReadyGo (0);
			MyDefinedClass objB = new MyDefinedClass ();
			objB.totalNumber = 45;

			int a = (int)'A';
			a = getValue;
			a += 45;

			int b = 1112;
			Utility.Values.SwapInt (ref a, ref b);	// ref

			char c = (char)65;
			c++;

			int screenW, screenH;	// 不用初始化
			Utility.SystemSettings.GetSettings (out screenW, out screenH);	// out

			System.Console.WriteLine ("my int: {0}", a);
			System.Console.WriteLine ("my char: {0}", c);

			const int x = 32;
			a = x+6;

			a = (int)Temperatures.BoilingPoint;

			Weekday weekday = Weekday.Tur;

			const string myStr = "Hi, dear!";
			System.Console.WriteLine (myStr);

			switch (weekday) {
			case Weekday.Mon:
				break;
			case Weekday.Tur:
				break;
			case Weekday.Wen:
				break;
			}

		}
	}
}
