#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DeclarativeDataDisplayWhidbey
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
// TODO: Delete this line of code to remove the default AutoFill for 'northwindDataSet.Customers'.
			this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

		}
	}
}