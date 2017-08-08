#region Using directives

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

#endregion

namespace DynamicInvoke1
{
   public class MyMath
   {
      // sum numbers with a loop
      public int DoSumLooping( int initialVal )
      {
         int result = 0;
         for ( int i = 1; i <= initialVal; i++ )
         {
            result += i;
         }
         return result;
      }
   }

   // responsible for creating the BruteForceSums
   // class and compiling it and invoking the
   // DoSums method dynamically
   public class ReflectionTest
   {
      Type theType = null;
      object theClass = null;

      // the public method called by the driver
      public double DoSum( int theValue )
      {
         // if you don't have a reference
         // to the dynamically created class
         // create it
         if ( theType == null )
         {
            GenerateCode( theValue );
         }

         // with the reference to the dynamically 
         // created class you can invoke the method 
         object[] arguments = new object[0];
         object retVal =
            theType.InvokeMember( "ComputeSum",
            BindingFlags.Default |
            BindingFlags.InvokeMethod,
            null,
            theClass,
            arguments );
         return ( double ) retVal;
      }

      // generate the code and compile it
      private void GenerateCode( int theVal )
      {
         // open the file for writing
         string fileName = "BruteForceSums";
         Stream s =
            File.Open( fileName + ".cs", FileMode.Create );
         StreamWriter wrtr = new StreamWriter( s );
         wrtr.WriteLine(
            "// Dynamically created BruteForceSums class" );

         // create the class
         string className = "BruteForceSums";
         wrtr.WriteLine( "class {0}", className );
         wrtr.WriteLine( "{" );

         // create the method
         wrtr.WriteLine( "\tpublic double ComputeSum()" );
         wrtr.WriteLine( "\t{" );
         wrtr.WriteLine( "\t// Brute force sum method" );
         wrtr.WriteLine( "\t// For value = {0}", theVal );

         // write the brute force additions
         wrtr.Write( "\treturn 0" );
         for ( int i = 1; i <= theVal; i++ )
         {
            wrtr.Write( "+ {0}", i );
         }
         wrtr.WriteLine( ";" );    // finish method
         wrtr.WriteLine( "\t}" );    // end method
         wrtr.WriteLine( "}" );    // end class

         // close the writer and the stream
         wrtr.Close();
         s.Close();

         // Build the file
         ProcessStartInfo psi =
            new ProcessStartInfo();
         psi.FileName = "cmd.exe";

         string compileString = "/c {0}csc /optimize+ ";
         compileString += "/target:library ";
         compileString += "{1}.cs > compile.out";

         string frameworkDir =
           RuntimeEnvironment.GetRuntimeDirectory();
         psi.Arguments =
            String.Format( compileString, frameworkDir, fileName );
         psi.WindowStyle = ProcessWindowStyle.Minimized;

         Process proc = Process.Start( psi );
         proc.WaitForExit( 2000 );

         // Open the file, and get a 
         // pointer to the method info
         Assembly a =
            Assembly.LoadFrom( fileName + ".dll" );
         theClass = a.CreateInstance( className );
         theType = a.GetType( className );
         // File.Delete(fileName + ".cs");  // clean up
      }
   }

   public class TestDriver
   {
      public static void Main()
      {
         const int val = 200;  // 1..200
         const int iterations = 100000;
         double result = 0;

         // run the benchmark
         MyMath m = new MyMath();
         DateTime startTime = DateTime.Now;
         for ( int i = 0; i < iterations; i++ )
         {
            result = m.DoSumLooping( val );
         }
         TimeSpan elapsed =
            DateTime.Now - startTime;
         Console.WriteLine(
            "Sum of ({0}) = {1}", val, result );
         Console.WriteLine(
            "Looping. Elapsed milliseconds: " +
            elapsed.TotalMilliseconds +
            " for {0} iterations", iterations );

         // run our reflection alternative
         ReflectionTest t = new ReflectionTest();

         startTime = DateTime.Now;
         for ( int i = 0; i < iterations; i++ )
         {
            result = t.DoSum( val );
         }

         elapsed = DateTime.Now - startTime;
         Console.WriteLine(
            "Sum of ({0}) = {1}", val, result );
         Console.WriteLine(
            "Brute Force. Elapsed milliseconds: " +
            elapsed.TotalMilliseconds +
            " for {0} iterations", iterations );
      }
   }
}
