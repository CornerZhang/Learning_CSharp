#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace ProgrammaticDataDisplay
{
   partial class ProgrammaticDataDisplay : Form
   {
      public ProgrammaticDataDisplay()
      {
         InitializeComponent();
         // set up connection and command strings
         string connectionString = "server=localhost;" +
         "Trusted_Connection=yes; database=northwind";
         string commandString =
            "Select CompanyName, ContactName, ContactTitle, "
            + "Phone, Fax from Customers";

         // create a data set and fill it
         SqlDataAdapter DataAdapter =
            new SqlDataAdapter( commandString, connectionString );
         DataSet DataSet = new DataSet();
         DataAdapter.Fill( DataSet, "Customers" );

         // bind the DataSet to the grid
         dataGridView1.DataSource =
            DataSet.Tables["Customers"].DefaultView;

      }
   }
}