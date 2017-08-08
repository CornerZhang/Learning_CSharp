using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace DelegateAndEvent
{
    public enum Comparison
    {
        theFirstComesFirst = 1,
        theSecondComesFirst = 2
    }

    public class Pair<T>
    {

        // private array to hold the two objects
        private T[] thePair = new T[2];

        // the delegate declaration
        public delegate Comparison WhichIsFirst( T obj1, T obj2 );

        public static void Swap(ref T a, ref T b) {
            T temp = a;
            a = b;
            b = temp;
        }

        // passed in constructor take two objects, 
        // added in order received
        public Pair(
            T firstObject,
            T secondObject )
        {
            thePair[0] = firstObject;
            thePair[1] = secondObject;
        }

        // public method which orders the two objects
        // by whatever criteria the object likes!
        public void Sort( WhichIsFirst theDelegatedFunc )
        {
            if ( theDelegatedFunc( thePair[0], thePair[1] ) == Comparison.theSecondComesFirst )
            {
                Swap(ref thePair [0], ref thePair [1]);
            }
        }

        // public method which orders the two objects
        // by the reverse of whatever criteria the object likes!
        public void ReverseSort( WhichIsFirst theDelegatedFunc )
        {
            if ( theDelegatedFunc( thePair[0], thePair[1] ) == Comparison.theFirstComesFirst )
            {
                Swap (ref thePair [0], ref thePair [1]);
            }
        }

        // ask the two objects to give their string value
        public override string ToString()
        {
            return thePair[0].ToString() + ", " + thePair[1].ToString();
        }
    }        // end class Pair

    public class Dog
    {
        private int weight;

        public Dog( int weight )
        {
            this.weight = weight;
        }

        // dogs are ordered by weight
        public static Comparison WhichDogComesFirst( Dog d1, Dog d2 )
        {
            return d1.weight > d2.weight ?
                Comparison.theSecondComesFirst :
                Comparison.theFirstComesFirst;
        }
        public override string ToString()
        {
            return weight.ToString();
        }
    }        // end class Dog

    public class Student
    {
        private string name;

        public Student( string name )
        {
            this.name = name;
        }

        // students are ordered alphabetically
        public static Comparison WhichStudentComesFirst( Student s1, Student s2 )
        {
            return ( String.Compare( s1.name, s2.name ) < 0 ?
                Comparison.theFirstComesFirst :
                Comparison.theSecondComesFirst );
        }

        public override string ToString()
        {
            return name;
        }
    }        // end class Student

    public class Dispatcher
    {
        public delegate void Caller_onUI(int x, int y); // Caller_onUI as type
        public event Caller_onUI caller_click;  // use "event" keyword, caller_click as instance

        public Dispatcher() {
            caller_click = null;
        }

        public Dispatcher(Caller_onUI caller) {
            caller_click = caller;
        }

        public void Fire(int x, int y) {
            if(caller_click!=null)
                caller_click (x, y);
        }
    }

    abstract public class EventSubscribe
    {
        private Dispatcher dispatcher = null;

        public EventSubscribe(Dispatcher dispatcher) {
            dispatcher.caller_click += Caller_Event_onUI;

            this.dispatcher = dispatcher;
        }

        ~EventSubscribe() {
            dispatcher = null;
        }

        public bool Valid() {
            return (dispatcher!=null);
        }

        abstract public void Caller_Event_onUI(int x, int y);
    }
}

