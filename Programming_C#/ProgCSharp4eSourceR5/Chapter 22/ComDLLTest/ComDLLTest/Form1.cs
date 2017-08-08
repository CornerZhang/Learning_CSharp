#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace ComDLLTest
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
         Double left, right, result;
         left = Double.Parse( textBox1.Text );
         right = Double.Parse( textBox2.Text );

         ComCalculatorDLLNET.ComCalc theCalc = new ComCalculatorDLLNET.ComCalc();
         result = theCalc.Add( ref left, ref right );
         label1.Text = result.ToString();
      }

      private void btnSubtract_Click(
         object sender, System.EventArgs e )
      {
         Double left, right, result;
         left = Double.Parse(textBox1.Text);
         right = Double.Parse(textBox2.Text);
         ComCalculatorDLLNET.ComCalc theCalc = new ComCalculatorDLLNET.ComCalc();
         result = theCalc.Subtract(ref left, ref right); 
         label1.Text = result.ToString();
      }

      private void btnMultiply_Click(
         object sender, System.EventArgs e )
      {
         Double left, right, result;
         left = Double.Parse( textBox1.Text );
         right = Double.Parse( textBox2.Text );
         ComCalculatorDLLNET.ComCalc theCalc = new ComCalculatorDLLNET.ComCalc();
         result = theCalc.Multiply( ref left, ref right );
         label1.Text = result.ToString();
      }

      private void btnDivide_Click(
         object sender, System.EventArgs e )
      {
         Double left, right, result;
         left = Double.Parse( textBox1.Text );
         right = Double.Parse( textBox2.Text );
         ComCalculatorDLLNET.ComCalc theCalc = new ComCalculatorDLLNET.ComCalc();
         result = theCalc.Divide( ref left, ref right );
         label1.Text = result.ToString();
      }

   }
}