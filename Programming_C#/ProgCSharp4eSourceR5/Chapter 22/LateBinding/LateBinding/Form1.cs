#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

#endregion

namespace LateBinding
{
   partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void btnAdd_Click(
         object sender, System.EventArgs e )
      {
         Invoke( "Add" );
      }

      private void btnSubtract_Click(
         object sender, System.EventArgs e )
      {
         Invoke( "Subtract" );
      }

      private void btnMultiply_Click(
         object sender, System.EventArgs e )
      {
         Invoke( "Multiply" );
      }

      private void btnDivide_Click(
         object sender, System.EventArgs e )
      {
         Invoke( "Divide" );
      }


      private void Invoke( string whichMethod )
      {
         Double left, right, result;
         left = Double.Parse( textBox1.Text );
         right = Double.Parse( textBox2.Text );

         // create a Type object to hold type information
         Type comCalcType;

         // an array for the arguments
         object[] inputArguments = 
      { left, right };

         // get the type info from the COM object
         comCalcType =
            Type.GetTypeFromProgID(
               "ComCalculator.ComCalc" );

         // create an instance
         object comCalcObject =
            Activator.CreateInstance( comCalcType );

         // invoke the method dynamically and 
         // cast the result to Double
         result = ( Double ) comCalcType.InvokeMember(
            whichMethod,                // the method to invoke
            BindingFlags.InvokeMethod,  // how to bind
            null,                       // binder
            comCalcObject,              // the COM object
            inputArguments );            // the method arguments

         label1.Text = result.ToString();
      }


   }
}