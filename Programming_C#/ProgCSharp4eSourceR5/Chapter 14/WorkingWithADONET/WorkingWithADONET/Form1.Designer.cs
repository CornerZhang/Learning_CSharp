namespace WorkingWithADONET
{
   partial class ADONetForm1
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
         this.lbCustomers = new System.Windows.Forms.ListBox();
         this.SuspendLayout();
// 
// lbCustomers
// 
         this.lbCustomers.FormattingEnabled = true;
         this.lbCustomers.Location = new System.Drawing.Point( 13, 13 );
         this.lbCustomers.Name = "lbCustomers";
         this.lbCustomers.Size = new System.Drawing.Size( 243, 199 );
         this.lbCustomers.TabIndex = 0;
// 
// ADONetForm1
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 292, 262 );
         this.Controls.Add( this.lbCustomers );
         this.Name = "ADONetForm1";
         this.Text = "ADO.NET Form 1";
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.ListBox lbCustomers;
   }
}

