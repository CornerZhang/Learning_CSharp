#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Queue
{
   public class Tester
   {

      static void Main()
      {

         Queue<Int32> intQueuee = new Queue<Int32>();


         // populate the array
         for ( int i = 0; i < 5; i++ )
         {

            intQueuee.Enqueue( i * 5 );

         }

         // Display the Queue.
         Console.Write( "intQueuee values:\t" );
         PrintValues( intQueuee );

         // Remove an element from the queue.
         Console.WriteLine(
            "\n(Dequeue)\t{0}", intQueuee.Dequeue() );


         // Display the Queue.
         Console.Write( "intQueuee values:\t" );
         PrintValues( intQueuee );

         // Remove another element from the queue.
         Console.WriteLine(
            "\n(Dequeue)\t{0}", intQueuee.Dequeue() );

         // Display the Queue.
         Console.Write( "intQueuee values:\t" );
         PrintValues( intQueuee );

         // View the first element in the 
         // Queue but do not remove.
         Console.WriteLine(
            "\n(Peek)   \t{0}", intQueuee.Peek() );


         // Display the Queue.
         Console.Write( "intQueuee values:\t" );
         PrintValues( intQueuee );

      }

      public static void PrintValues( IEnumerable<Int32> myCollection )
      {
         IEnumerator<Int32> myEnumerator =
            myCollection.GetEnumerator();
         while ( myEnumerator.MoveNext() )
            Console.Write( "{0} ", myEnumerator.Current );
         Console.WriteLine();
      }

   }
}
