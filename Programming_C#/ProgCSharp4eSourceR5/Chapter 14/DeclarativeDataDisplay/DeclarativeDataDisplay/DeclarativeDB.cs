#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace DeclarativeDataDisplay
{
   partial class DeclarativeDB : Form
   {
      public DeclarativeDB()
      {
         InitializeComponent();
      }

      private void DeclarativeDB_Load(object sender, EventArgs e)
      {
// TODO: Delete this line of code to remove the default AutoFill for 'northwindDataSet.Customers'.
         this.customersTableAdapter.Fill( this.northwindDataSet.Customers );

      }
   }
}