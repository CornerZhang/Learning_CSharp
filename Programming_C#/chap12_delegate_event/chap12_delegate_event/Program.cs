using System;
using DelegateAndEvent;

namespace chap12_delegate_event
{
    class UILabel: EventSubscribe
    {
        public UILabel(Dispatcher dispatcher) : base(dispatcher) {
        }

        public override void Caller_Event_onUI(int x, int y) {
            Console.WriteLine("UILabel: {0}, {1}", x, y);
        }
    };


    class UIButton: EventSubscribe
    {
        public UIButton(Dispatcher dispatcher) : base(dispatcher) {
        }

        public override void Caller_Event_onUI(int x, int y) {
            Console.WriteLine("UIButton: {0}, {1}", x, y);
        }
    };

    class MainClass
    {
        public static void Main (string[] args)
        {
            // create two students and two dogs
            // and add them to Pair objects
            Student Jesse = new Student( "Jesse" );
            Student Stacey = new Student( "Stacey" );
            Dog Milo = new Dog( 65 );
            Dog Fred = new Dog( 12 );

            Pair<Student> studentPair = new Pair<Student>( Jesse, Stacey );
            Pair<Dog> dogPair = new Pair<Dog>( Milo, Fred );
            Console.WriteLine( "studentPair\t\t\t: {0}", studentPair.ToString() );
            Console.WriteLine( "dogPair\t\t\t\t: {0}", dogPair.ToString() );

            // Instantiate  the delegates
            Pair<Student>.WhichIsFirst theStudentDelegate = new Pair<Student>.WhichIsFirst( Student.WhichStudentComesFirst );
            Pair<Dog>.WhichIsFirst theDogDelegate = new Pair<Dog>.WhichIsFirst( Dog.WhichDogComesFirst );

            // sort using the delegates
            studentPair.Sort( theStudentDelegate );
            Console.WriteLine( "After Sort studentPair\t\t: {0}", studentPair.ToString() );
            studentPair.ReverseSort( theStudentDelegate );
            Console.WriteLine( "After ReverseSort studentPair\t: {0}", studentPair.ToString() );

            dogPair.Sort( theDogDelegate );
            Console.WriteLine( "After Sort dogPair\t\t: {0}", dogPair.ToString() );
            dogPair.ReverseSort( theDogDelegate );
            Console.WriteLine( "After ReverseSort dogPair\t: {0}", dogPair.ToString() );

            // my simulate code, about delegate
            {
                // a null
                Dispatcher dispatcherA = new Dispatcher ();
                dispatcherA.Fire (45, 80);

                //used safe, with event
//                Dispatcher dispatcherB = new Dispatcher ();
//                dispatcherB.caller_click = null;    // Compile Error, cause use "event"
//                dispatcherB.Fire (45, 80);

                // multi-binding delegate
                Console.WriteLine ("start multi-binding delegates");
                Dispatcher dispatcherMulti = new Dispatcher ();
                UILabel label = new UILabel (dispatcherMulti);
                label.Valid ();
                UIButton button = new UIButton (dispatcherMulti);
                button.Valid ();
                dispatcherMulti.Fire (45, 80);
                label = null;
                button = null;
            }
        }
    }
}
