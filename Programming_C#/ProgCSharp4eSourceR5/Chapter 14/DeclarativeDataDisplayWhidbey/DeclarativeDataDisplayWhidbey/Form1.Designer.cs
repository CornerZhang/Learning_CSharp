namespace DeclarativeDataDisplayWhidbey
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.northwindDataSet = new DeclarativeDataDisplayWhidbey.NorthwindDataSet();
			this.CustomersDataConnector = new System.Windows.Forms.DataConnector(this.components);
			this.customersTableAdapter = new DeclarativeDataDisplayWhidbey.CustomersTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataConnector)).BeginInit();
			this.SuspendLayout();
// 
// dataGridView1
// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn1);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn2);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn3);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn4);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn5);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn6);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn7);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn8);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn9);
			this.dataGridView1.Columns.Add(this.dataGridViewTextBoxColumn10);
			this.dataGridView1.DataSource = this.CustomersDataConnector;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(292, 266);
			this.dataGridView1.TabIndex = 0;
// 
// northwindDataSet
// 
			this.northwindDataSet.DataSetName = "NorthwindDataSet";
			this.northwindDataSet.Locale = new System.Globalization.CultureInfo("en-US");
			this.northwindDataSet.RemotingFormat = System.Data.SerializationFormat.Xml;
// 
// CustomersDataConnector
// 
			this.CustomersDataConnector.DataMember = "Customers";
			this.CustomersDataConnector.DataSource = this.northwindDataSet;
// 
// customersTableAdapter
// 
			this.customersTableAdapter.ClearBeforeFill = true;
// 
// dataGridViewTextBoxColumn1
// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
			this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
			this.dataGridViewTextBoxColumn1.Name = "CustomerID";
			this.dataGridViewTextBoxColumn1.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn2
// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
			this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
			this.dataGridViewTextBoxColumn2.Name = "CompanyName";
			this.dataGridViewTextBoxColumn2.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn3
// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactName";
			this.dataGridViewTextBoxColumn3.HeaderText = "ContactName";
			this.dataGridViewTextBoxColumn3.Name = "ContactName";
			this.dataGridViewTextBoxColumn3.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn4
// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "ContactTitle";
			this.dataGridViewTextBoxColumn4.HeaderText = "ContactTitle";
			this.dataGridViewTextBoxColumn4.Name = "ContactTitle";
			this.dataGridViewTextBoxColumn4.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn5
// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Address";
			this.dataGridViewTextBoxColumn5.HeaderText = "Address";
			this.dataGridViewTextBoxColumn5.Name = "Address";
			this.dataGridViewTextBoxColumn5.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn6
// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "City";
			this.dataGridViewTextBoxColumn6.HeaderText = "City";
			this.dataGridViewTextBoxColumn6.Name = "City";
			this.dataGridViewTextBoxColumn6.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn7
// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "PostalCode";
			this.dataGridViewTextBoxColumn7.HeaderText = "PostalCode";
			this.dataGridViewTextBoxColumn7.Name = "PostalCode";
			this.dataGridViewTextBoxColumn7.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn8
// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Country";
			this.dataGridViewTextBoxColumn8.HeaderText = "Country";
			this.dataGridViewTextBoxColumn8.Name = "Country";
			this.dataGridViewTextBoxColumn8.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn9
// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn9.HeaderText = "Phone";
			this.dataGridViewTextBoxColumn9.Name = "Phone";
			this.dataGridViewTextBoxColumn9.ValueType = typeof(string);
// 
// dataGridViewTextBoxColumn10
// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Fax";
			this.dataGridViewTextBoxColumn10.HeaderText = "Fax";
			this.dataGridViewTextBoxColumn10.Name = "Fax";
			this.dataGridViewTextBoxColumn10.ValueType = typeof(string);
// 
// Form1
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CustomersDataConnector)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private NorthwindDataSet northwindDataSet;
		private System.Windows.Forms.DataConnector CustomersDataConnector;
		private CustomersTableAdapter customersTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
	}
}

