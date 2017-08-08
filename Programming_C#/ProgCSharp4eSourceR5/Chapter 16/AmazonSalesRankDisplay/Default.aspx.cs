using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default_aspx
{
   protected int showRecords;
   protected int totalASP;
   protected int totalCSharp;
   protected int rowNumber = 0;


   protected override void OnLoad( EventArgs e )
   {
      // initialize number of records to show to 7
      if ( !IsPostBack )
      {
         showRecords = 7;
      }
      // if it is a post back, get the number
         // from the text box
      else
      {
         showRecords = Convert.ToInt32( txtShowRecords.Text );
      }

      // connect to the db
      string connectionString =
         "server=localhost;Trusted_Connection=true;database=AmazonSalesRanks";


      // pick records to display
      string commandString =
         @"Select top " + showRecords +
         " * from BookInfo where technology = 'ASPNET' order by rank";
      SqlDataAdapter dataAdapter =
         new SqlDataAdapter( commandString, connectionString );
      DataSet dataSet = new DataSet();
      dataAdapter.Fill( dataSet, "aspBookInfo" ); // first table


      commandString = @"Select top " + showRecords + " * from BookInfo where technology = 'CSHARP' order by rank";
      dataAdapter = new SqlDataAdapter( commandString, connectionString );
      dataAdapter.Fill( dataSet, "csBookInfo" ); // second table

      commandString = @"Select top " + showRecords + " * from BookInfo where technology = 'VBNET' order by rank";
      dataAdapter = new SqlDataAdapter( commandString, connectionString );
      dataAdapter.Fill( dataSet, "vbBookInfo" ); // third table

      // create the data view and bind to the grid
      DataView aspDataView =
         dataSet.Tables[0].DefaultView;
      gvASP.DataSource = aspDataView;
      gvASP.DataBind();

      rowNumber = 0;

      DataView csDataView = dataSet.Tables[1].DefaultView;
      gvCSharp.DataSource = csDataView;
      gvCSharp.DataBind();

      rowNumber = 0;

      DataView vbDataView = dataSet.Tables[2].DefaultView;
      this.gvVBNet.DataSource = vbDataView;
      gvVBNet.DataBind();



      // txtShowRecords.DataBind();
      lblLastUpdate.Text = "Last updated: " + dataSet.Tables[2].Rows[0]["lastUpdate"].ToString();

   }
   void RowDataBound( object sender, GridViewRowEventArgs e )
   {
      this.rowNumber++;
   }


}