#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace UsingADOManagedProvider
{
   partial class ADONetForm1 : Form
   {
      public ADONetForm1()
      {
         InitializeComponent();
         // connect to Northwind Access database

         string connectionString =
            "provider=Microsoft.JET.OLEDB.4.0; "
            + "data source = c:\\nwind.mdb";



         // get records from the customers table
         string commandString =
         "Select CompanyName, ContactName from Customers";

         // create the data set command object 
         // and the DataSet

         OleDbDataAdapter DataAdapter =
         new OleDbDataAdapter(
         commandString, connectionString );


         DataSet DataSet = new DataSet();

         // fill the data set object
         DataAdapter.Fill( DataSet, "Customers" );

         // Get the one table from the DataSet
         DataTable dataTable = DataSet.Tables[0];

         // for each row in the table, display the info
         foreach ( DataRow dataRow in dataTable.Rows )
         {
            lbCustomers.Items.Add(
               dataRow["CompanyName"] +
               " (" + dataRow["ContactName"] + ")" );
         }
      }
   }
}