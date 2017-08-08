using System;

namespace chap11_exception
{
    public class Test
    {
        public void Func1() {
            Console.WriteLine ("Enter Func1...");
            try {
                Console.WriteLine ("Enter try block...");
                Func2 ();
                Console.WriteLine ("Exit try block...");
            }catch(System.Exception e){
                Console.WriteLine ("Exception caught and handled. - {0}", e.Message);
                Console.WriteLine ("Helplink: {0}", e.HelpLink);
                // will unwind stack
            }finally{
                Console.WriteLine ("Close all here.");
            }

            Console.WriteLine ("Exit Func1...");
        }

        public void Func2() {
            Console.WriteLine ("Enter Func2...");

            {
                Exception e = new System.Exception ();  // throw
                throw e;
            }

            Console.WriteLine ("Exit Func2...");
        }
    };

    class MainClass
    {
        public static void Main (string[] args)
        {
            Test t = new Test ();
            t.Func1 ();
        }
    }
}
