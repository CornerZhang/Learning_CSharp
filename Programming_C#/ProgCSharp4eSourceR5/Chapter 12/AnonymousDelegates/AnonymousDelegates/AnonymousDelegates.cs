#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace AnonymousDelegates
{
   public enum Comparison
   {
      theFirstComesFirst = 1,
      theSecondComesFirst = 2
   }

   // a simple collection to hold 2 items
   public class Pair<T>
   {

      // private array to hold the two objects
      private T[] thePair = new T[2];

      // the delegate declaration
      public delegate Comparison
          WhichIsFirst( T obj1, T obj2 );

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
      public void Sort(
          WhichIsFirst theDelegatedFunc )
      {
         if ( theDelegatedFunc( thePair[0], thePair[1] )
             == Comparison.theSecondComesFirst )
         {
            T temp = thePair[0];
            thePair[0] = thePair[1];
            thePair[1] = temp;
         }
      }

      // public method which orders the two objects
      // by the reverse of whatever criteria the object likes!
      public void ReverseSort(
          WhichIsFirst theDelegatedFunc )
      {
         if ( theDelegatedFunc( thePair[0], thePair[1] ) ==
             Comparison.theFirstComesFirst )
         {
            T temp = thePair[0];
            thePair[0] = thePair[1];
            thePair[1] = temp;
         }
      }

      // ask the two objects to give their string value
      public override string ToString()
      {
         return thePair[0].ToString() + ", "
             + thePair[1].ToString();
      }
   }        // end class Pair

   public class Dog
   {
      private int weight;
      public static Pair<Dog>.WhichIsFirst OrderDogs
      {
         get
         {
            return new Pair<Dog>.WhichIsFirst( WhichDogComesFirst );
         }
      }

      public Dog( int weight )
      {
         this.weight = weight;
      }

      // dogs are ordered by weight
      public static Comparison WhichDogComesFirst(
          Dog d1, Dog d2 )
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
      public static Pair<Student>.WhichIsFirst OrderStudents
      {
         get
         {
            return new Pair<Student>.WhichIsFirst( WhichStudentComesFirst );
         }
      }
      public Student( string name )
      {
         this.name = name;
      }

      // students are ordered alphabetically
      public static Comparison
          WhichStudentComesFirst( Student s1, Student s2 )
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

   public class Test
   {
      public static void Main()
      {
         // create two students and two dogs
         // and add them to Pair objects
         Student Jesse = new Student( "Jesse" );
         Student Stacey = new Student( "Stacey" );
         Dog Milo = new Dog( 65 );
         Dog Fred = new Dog( 12 );

         Pair<Student> studentPair = new Pair<Student>( Jesse, Stacey );
         Pair<Dog> dogPair = new Pair<Dog>( Milo, Fred );
         Console.WriteLine( "studentPair\t\t\t: {0}",
             studentPair.ToString() );
         Console.WriteLine( "dogPair\t\t\t\t: {0}",
             dogPair.ToString() );

         // Instantiate  the delegates
         Pair<Student>.WhichIsFirst theStudentDelegate =
             new Pair<Student>.WhichIsFirst(
             Student.WhichStudentComesFirst );

         Pair<Dog>.WhichIsFirst theDogDelegate =
             new Pair<Dog>.WhichIsFirst(
             Dog.WhichDogComesFirst );

         // sort using the delegates
         studentPair.Sort( Student.OrderStudents );
         Console.WriteLine( "After Sort studentPair\t\t: {0}",
             studentPair.ToString() );
         studentPair.ReverseSort( Student.OrderStudents );
         Console.WriteLine( "After ReverseSort studentPair\t: {0}",
             studentPair.ToString() );

         dogPair.Sort( Dog.OrderDogs );
         Console.WriteLine( "After Sort dogPair\t\t: {0}",
             dogPair.ToString() );
         dogPair.ReverseSort( Dog.OrderDogs );
         Console.WriteLine( "After ReverseSort dogPair\t: {0}",
             dogPair.ToString() );
      }
   }
}
