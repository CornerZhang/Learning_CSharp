#region Using directives

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

#endregion

namespace SerializingDeserialingAnObject
{
   [Serializable]
   class SumOf
   {
      private int startNumber = 1;
      private int endNumber;
      private int[] theSums;

      public static void Main()
      {
         Console.WriteLine( "Creating first one with new..." );
         SumOf app = new SumOf( 1, 10 );

         Console.WriteLine( "Creating second one with deserialize..." );
         SumOf newInstance = SumOf.DeSerialize();
         newInstance.DisplaySums();
      }


      public SumOf( int start, int end )
      {
         startNumber = start;
         endNumber = end;
         ComputeSums();
         DisplaySums();
         Serialize();
      }

      private void ComputeSums()
      {
         int count = endNumber - startNumber + 1;
         theSums = new int[count];
         theSums[0] = startNumber;
         for ( int i = 1, j = startNumber + 1; i < count; i++, j++ )
         {
            theSums[i] = j + theSums[i - 1];

         }
      }

      private void DisplaySums()
      {
         foreach ( int i in theSums )
         {
            Console.WriteLine( "{0}, ", i );
         }
      }

      private void Serialize()
      {
         Console.Write( "Serializing..." );
         // create a file stream to write the file
         FileStream fileStream =
            new FileStream( "DoSum.out", FileMode.Create );
         // use the CLR binary formatter
         BinaryFormatter binaryFormatter =
            new BinaryFormatter();
         // serialize to disk
         binaryFormatter.Serialize( fileStream, this );
         Console.WriteLine( "...completed" );
         fileStream.Close();
      }

      public static SumOf DeSerialize()
      {
         FileStream fileStream =
           new FileStream( "DoSum.out", FileMode.Open );
         BinaryFormatter binaryFormatter =
           new BinaryFormatter();
         SumOf retVal = ( SumOf ) binaryFormatter.Deserialize( fileStream );
         fileStream.Close();
         return retVal;
      }
   }
}
