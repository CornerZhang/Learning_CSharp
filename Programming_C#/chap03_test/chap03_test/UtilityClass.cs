using System;

namespace Utility
{
	public class Values
	{
		// 将会引用传值
		public static void SwapInt(ref int a, ref int b) {
			int t = a;
			a = b;
			b = t;
		}
	}

	public class SystemSettings
	{
		public static void GetSettings(out int screenWidth, out int screenHeight) {
			screenWidth = 1024;
			screenHeight = 768;
		}
	}
}

