using System;
using MyCollection;

namespace extra_generic
{


    class MainClass
    {
        public static void Main (string[] args)
        {
            GenericList<int> list = new GenericList<int> ();

            for (int x = 0; x < 10; x++) {
                list.AddHead (x);
            }

            foreach (int i in list) {
                System.Console.Write (i + " ");
            }
            System.Console.WriteLine ("\nDone");
        }
    }
}
