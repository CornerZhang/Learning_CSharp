#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace Interop
{
   partial class ActiveXImport : Form
   {
      public ActiveXImport()
      {
         InitializeComponent();
      }

      private void btnAdd_Click( object sender, System.EventArgs e )
      {
         double left = double.Parse( textBox1.Text );
         double right = double.Parse( textBox2.Text );
         label1.Text = axCalculator1.Add( ref left, ref right ).ToString();
      }

      private void btnDivide_Click( object sender, System.EventArgs e )
      {
         double left = double.Parse( textBox1.Text );
         double right = double.Parse( textBox2.Text );
         label1.Text = axCalculator1.Divide( ref left, ref right ).ToString();
      }

      private void btnMultiply_Click( object sender, System.EventArgs e )
      {
         double left = double.Parse( textBox1.Text );
         double right = double.Parse( textBox2.Text );
         label1.Text = axCalculator1.Multiply( ref left, ref right ).ToString();
      }

      private void btnSubtract_Click( object sender, System.EventArgs e )
      {
         double left = double.Parse( textBox1.Text );
         double right = double.Parse( textBox2.Text );
         label1.Text = axCalculator1.Subtract( ref left, ref right ).ToString();
      }
   }
}