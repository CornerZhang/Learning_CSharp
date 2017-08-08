#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace CustomizedDataSet
{
   partial class CustomizedDataSet : Form
   {
      private System.Data.SqlClient.SqlConnection myConnection;
      private System.Data.DataSet myDataSet;
      private System.Data.SqlClient.SqlCommand myCommand;
      private System.Data.SqlClient.SqlDataAdapter DataAdapter;


      public CustomizedDataSet()
      {
         InitializeComponent();
         string connectionString = "server=localhost;" +
            "Trusted_Connection=yes; database=northwind";
         myConnection = new
            System.Data.SqlClient.SqlConnection( connectionString );
         myConnection.Open();

         // create the DataSet and set a property
         myDataSet = new System.Data.DataSet();
         myDataSet.CaseSensitive = true;

         // create the SqlCommand  object and assign the
         // connection and the select statement
         myCommand = new System.Data.SqlClient.SqlCommand();
         myCommand.Connection = myConnection;
         myCommand.CommandText = "Select * from Customers";

         // create the DataAdapter object and pass in the
         // SQL Command object and establish the table mappings
         DataAdapter = new System.Data.SqlClient.SqlDataAdapter();
         DataAdapter.SelectCommand = myCommand;
         DataAdapter.TableMappings.Add( "Table", "Customers" );

         // Tell the DataAdapter object to fill the DataSet
         DataAdapter.Fill( myDataSet );

         // display it in the grid
         dataGridView1.DataSource =
            myDataSet.Tables["Customers"].DefaultView;

      }
   }
}