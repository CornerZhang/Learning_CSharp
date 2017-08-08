#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace WorkingWithADONET
{
   partial class ADONetForm1 : Form
   {
      public ADONetForm1()
      {
         InitializeComponent();

         // connect to my local server, northwind db

         string connectionString = "server=localhost;" +
            "Trusted_Connection=yes; database=northwind";

         // get records from the customers table
         string commandString =
         "Select CompanyName, ContactName from Customers";
         

         // create the data set command object 
         // and the DataSet
         SqlDataAdapter DataAdapter =
         new SqlDataAdapter(
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