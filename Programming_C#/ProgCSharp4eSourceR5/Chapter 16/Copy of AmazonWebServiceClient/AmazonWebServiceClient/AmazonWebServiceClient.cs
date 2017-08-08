#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace AmazonWebServiceClient
{
   partial class AmazonWebServiceClient : Form
   {
      private int timeRemaining;
      const int WaitTime = 900; // 15 minutes
      private string connectionString;
      private System.Data.SqlClient.SqlConnection connection;
      private System.Data.SqlClient.SqlCommand command;

      public AmazonWebServiceClient()
      {
         InitializeComponent();
      }

      private void AmazonWebServiceClient_Load( object sender, EventArgs e )
      {
         // connection string to connect to the Sales Rank Database
         connectionString =
            "server=localhost;Trusted_Connection=true;database=AmazonSales";

         // Create connection object, initialize with 
         // connection string. 
         connection =
            new System.Data.SqlClient.SqlConnection( connectionString );

         // Create a SqlCommand object and assign the connection
         command =
            new System.Data.SqlClient.SqlCommand();

         command.Connection = connection;
         timeRemaining = 1;  // when you first start up, get the info.
         UpdateButton();

      }

      private void btnStart_Click( object sender, EventArgs e )
      {
         // toggle the timer
         updateTimer.Enabled = updateTimer.Enabled ? false : true;
         UpdateButton();

      }

      private void btnNow_Click( object sender, EventArgs e )
      {
         timeRemaining = 2;
      }

      private void UpdateButton()
      {
         btnStart.Text = updateTimer.Enabled ? "Stop" : "Start";
      }

      private void updateTimer_Tick( object sender, EventArgs e )
      {


         if ( updateTimer.Enabled )
            txtClock.Text = ( --timeRemaining ).ToString() + " seconds";
         else
            txtClock.Text = "Stopped";

         // hi ho, hi ho, it's off to work we go...
         if ( timeRemaining < 1 )
         {
            timeRemaining = WaitTime;  // reset the clock

            // create data set based on xml file
            DataSet BookData = new DataSet();
            BookData.ReadXml( "aspnet_isbn.xml" );

			 // iterate through, calling GetInfoFromISBN for 
            // each isbn found in file
            foreach ( DataRow Book in BookData.Tables[0].Rows )
            {
               string isbn = Book[0].ToString();
               GetInfoFromISBN( isbn, "ASPNET" );
            }

            BookData = new DataSet();
            BookData.ReadXml( "csharpIsbn.xml" );
            foreach ( DataRow Book in BookData.Tables[0].Rows )
            {
               string isbn = Book[0].ToString();
               GetInfoFromISBN( isbn, "CSHARP" );
            }

            BookData = new DataSet();
            BookData.ReadXml( "VBnetIsbn.xml" );
            foreach ( DataRow Book in BookData.Tables[0].Rows )
            {
               string isbn = Book[0].ToString();
               GetInfoFromISBN( isbn, "VBNET" );
            }
         }
      }

      private void GetInfoFromISBN( string isbn, string technology )
      {
         if ( isbn.Length != 10 )
            return;

         
         AWSProductData productData = new AWSProductData();
         ItemLookup lookup = null;
         try
         {
            ItemLookupRequest req = new ItemLookupRequest();
            req.IdType = ItemLookupRequestIdType.ASIN;
            req.ItemId = new string[1];
            req.ItemId[0] = isbn;
            // req.SearchIndex = "Books";

            lookup = new ItemLookup();
            lookup.AssociateTag = "libertyassocia00A";
            lookup.SubscriptionId = "0SD959SZV6KXV3BKE2R2";
            lookup.Request = new ItemLookupRequest[1];
            lookup.Request[0] = req;
         }
         catch ( System.Exception e )
         {
            lblStatus.Text = e.Message;
         }


         ItemLookupResponse response;
         Items info;
         Item[] items;
         Item item;
         



         int salesRank = -1;
         string author = string.Empty;
         string pubDate = string.Empty; 
         string publisher = string.Empty; 
         string title = string.Empty; 
         string strURL = string.Empty; 

         try
         {
            response = productData.ItemLookup( lookup );
            info = response.Items[0];
            items = info.Item;
            item = items[0];
            salesRank = item.SalesRank == null ? -1 : Convert.ToInt32(item.SalesRank);
            author = FixQuotes( item.ItemAttributes.Author[0] );
            pubDate =   FixQuotes(item.ItemAttributes.PublicationDate);
            publisher = FixQuotes(item.ItemAttributes.Publisher);
            title = FixQuotes(item.ItemAttributes.Title);
            strURL = item.DetailPageURL;
         }
         catch ( System.Exception ex)
         {
            lblStatus.Text = ex.Message;
         }

         // update the list box
         string results = title + " by " + author + ": " +
            publisher + ", " + pubDate + ". Rank: " + salesRank;
         lbOutput.Items.Add( results );
         lbOutput.SelectedIndex = lbOutput.Items.Count - 1;

         // update the database
         string commandString = @"Update BookInfo set isbn = '" +
            isbn + "', title = '" + title + "', publisher = '" +
            publisher + "', pubDate = '" + pubDate + "', rank = " +
            salesRank + ", link = '" + strURL + "', lastUpdate = '" +
            System.DateTime.Now + "', technology = '" +
            technology + "', author = '" +
            author + "' where isbn = '" +
            isbn + "'";

         command.CommandText = commandString;
         try
         {
            // if no rows were affected, this is a new record
            connection.Open();
            int numRowsAffected = command.ExecuteNonQuery();
            if ( numRowsAffected == 0 )
            {
               commandString = @"Insert into BookInfo values ('" +
                  isbn + "', '" + title + "', '" + publisher + "', '" +
                  pubDate + "', '" + FixQuotes( strURL ) + "', " + salesRank + ", '" +
                  System.DateTime.Now +
                  "', '" + technology + "', '" + author + "')";

               command.CommandText = commandString;
               command.ExecuteNonQuery();
            }
         }
         catch ( Exception ex )
         {
            lblStatus.Text = ex.Message;
            lbOutput.Items.Add( "Unable to update database!" );
            lbOutput.SelectedIndex = lbOutput.Items.Count - 1;
         }
         finally
         {
            connection.Close();      // clean up
         }
      }     // close for GetInfoFromISBN

      private string FixQuotes( string s )
      {
         if ( s == null )
            return string.Empty;
         return s.Replace( "'", "''" );

      }
   } // end class
} // end name space
