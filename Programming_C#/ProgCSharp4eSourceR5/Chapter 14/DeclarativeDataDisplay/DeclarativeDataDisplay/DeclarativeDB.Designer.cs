namespace DeclarativeDataDisplay
{
   partial class DeclarativeDB
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
		  this.components = new System.ComponentModel.Container();
		  System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
		  this.dataGridView1 = new System.Windows.Forms.DataGridView();
		  this.CustomersDataConnector = new System.Windows.Forms.DataConnector(this.components);
		  this.northwindDataSet = new DeclarativeDataDisplay.NorthwindDataSet();
		  this.customersTableAdapter = new DeclarativeDataDisplay.CustomersTableAdapter();
		  this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		  ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.CustomersDataConnector)).BeginInit();
		  ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
		  this.SuspendLayout();
// 
// dataGridView1
// 
		  this.dataGridView1.AutoGenerateColumns = false;
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn11);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn12);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn13);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn14);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn15);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn16);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn17);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn18);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn19);
		  this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn20);
		  this.dataGridView1.DataSource = this.CustomersDataConnector;
		  this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
		  this.dataGridView1.Location = new System.Drawing.Point(0, 0);
		  this.dataGridView1.Name = "dataGridView1";
		  this.dataGridView1.Size = new System.Drawing.Size(747, 262);
		  this.dataGridView1.TabIndex = 0;
// 
// CustomersDataConnector
// 
		  this.CustomersDataConnector.DataMember = "Customers";
		  this.CustomersDataConnector.DataSource = this.northwindDataSet;
// 
// northwindDataSet
// 
		  this.northwindDataSet.DataSetName = "NorthwindDataSet";
		  this.northwindDataSet.Locale = new System.Globalization.CultureInfo("en-US");
		  this.northwindDataSet.RemotingFormat = System.Data.SerializationFormat.Xml;
// 
// customersTableAdapter
// 
		  this.customersTableAdapter.ClearBeforeFill = true;
// 
// dataGridViewTextBoxColumn11
// 
		  this.dataGridViewTextBoxColumn11.DataPropertyName = "CustomerID";
		  this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn11.HeaderText = "Customer ID";
		  this.dataGridViewTextBoxColumn11.Name = "CustomerID";
		  this.dataGridViewTextBoxColumn11.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn12
// 
		  this.dataGridViewTextBoxColumn12.DataPropertyName = "CompanyName";
		  this.dataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn12.HeaderText = "Company";
		  this.dataGridViewTextBoxColumn12.Name = "CompanyName";
		  this.dataGridViewTextBoxColumn12.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn13
// 
		  this.dataGridViewTextBoxColumn13.DataPropertyName = "ContactName";
		  this.dataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn13.HeaderText = "Contact";
		  this.dataGridViewTextBoxColumn13.Name = "ContactName";
		  this.dataGridViewTextBoxColumn13.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn14
// 
		  this.dataGridViewTextBoxColumn14.DataPropertyName = "ContactTitle";
		  this.dataGridViewTextBoxColumn14.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn14.HeaderText = "Title";
		  this.dataGridViewTextBoxColumn14.Name = "ContactTitle";
		  this.dataGridViewTextBoxColumn14.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn15
// 
		  this.dataGridViewTextBoxColumn15.DataPropertyName = "Address";
		  this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn15.HeaderText = "Address";
		  this.dataGridViewTextBoxColumn15.Name = "Address";
		  this.dataGridViewTextBoxColumn15.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn16
// 
		  this.dataGridViewTextBoxColumn16.DataPropertyName = "City";
		  this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn16.HeaderText = "City";
		  this.dataGridViewTextBoxColumn16.Name = "City";
		  this.dataGridViewTextBoxColumn16.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn17
// 
		  this.dataGridViewTextBoxColumn17.DataPropertyName = "PostalCode";
		  this.dataGridViewTextBoxColumn17.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn17.HeaderText = "Zip";
		  this.dataGridViewTextBoxColumn17.Name = "PostalCode";
		  this.dataGridViewTextBoxColumn17.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn18
// 
		  this.dataGridViewTextBoxColumn18.DataPropertyName = "Country";
		  this.dataGridViewTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn18.HeaderText = "Country";
		  this.dataGridViewTextBoxColumn18.Name = "Country";
		  this.dataGridViewTextBoxColumn18.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn19
// 
		  this.dataGridViewTextBoxColumn19.DataPropertyName = "Phone";
		  this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn19.HeaderText = "Phone";
		  this.dataGridViewTextBoxColumn19.Name = "Phone";
		  this.dataGridViewTextBoxColumn19.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn20
// 
		  this.dataGridViewTextBoxColumn20.DataPropertyName = "Fax";
		  this.dataGridViewTextBoxColumn20.DefaultCellStyle = dataGridViewCellStyle1;
		  this.dataGridViewTextBoxColumn20.HeaderText = "Fax";
		  this.dataGridViewTextBoxColumn20.Name = "Fax";
		  this.dataGridViewTextBoxColumn20.ValueType = typeof(string);
// 
// DeclarativeDB
// 
		  this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
		  this.ClientSize = new System.Drawing.Size(747, 262);
		  this.Controls.Add(this.dataGridView1);
		  this.Name = "DeclarativeDB";
		  this.Text = "Declarative Data Base";
		  this.Load += new System.EventHandler(this.DeclarativeDB_Load);
		  ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.CustomersDataConnector)).EndInit();
		  ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
		  this.ResumeLayout(false);

	  }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private NorthwindDataSet northwindDataSet;
      private System.Windows.Forms.DataConnector CustomersDataConnector;
	   private CustomersTableAdapter customersTableAdapter;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
   	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
	private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
}
}

