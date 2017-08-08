
using System;


namespace chap06_Array
{
    class MainClass
    {
        const bool SIME = false;

        public static void ProcessArray(int[] values) {
            // ...
        }

        public static void Main (string[] args)
        {
            int[] myArray = new int[4];
            var myArrayExt = new int[8]{1,3,6,1,8,5,4,6};   // define with init

            int[,] myArray2D = new int[4, 4];
            var myArrayExt2D = new int[8, 8];

            var myArrayMem = System.Array.CreateInstance (typeof(float), 6);
            for (int i = 0; i < myArrayMem.Length; i++) {
                myArrayMem.SetValue (i, i);
            }

            myArray [0] = myArrayExt [0];

            myArrayExt2D [0, 0] = 67;

            if (SIME) {
                try {
                    myArrayExt [15] = 3;    // runtime error!
                } catch (System.IndexOutOfRangeException e) {
                    Console.WriteLine ("runtime error: {0}", e.Message);
                }
            }

            myArray2D[0,0] = myArrayExt2D[0,0];

            foreach (int x in myArrayExt) {
                Console.Write (x + " ");
            }
            Console.WriteLine ("");

            var myArrayFar = myArrayExt.Clone ();
            int[] holdArray = (int[])myArrayFar;
            System.Array.Sort (holdArray);
            foreach (int x in holdArray) {
                Console.Write (x + " ");
            }
            Console.WriteLine ("");

            int foundIndex = System.Array.BinarySearch (holdArray, 5);
            Console.WriteLine ("element 5 index: {0}", foundIndex);
        }
    }
}
