namespace AmazonWebServiceClient
{
   partial class AmazonWebServiceClient
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
         this.lbOutput = new System.Windows.Forms.ListBox();
         this.btnStart = new System.Windows.Forms.Button();
         this.txtClock = new System.Windows.Forms.TextBox();
         this.btnNow = new System.Windows.Forms.Button();
         this.lblStatus = new System.Windows.Forms.Label();
         this.updateTimer = new System.Windows.Forms.Timer( this.components );
         this.SuspendLayout();
// 
// lbOutput
// 
         this.lbOutput.FormattingEnabled = true;
         this.lbOutput.Location = new System.Drawing.Point( 13, 13 );
         this.lbOutput.Name = "lbOutput";
         this.lbOutput.Size = new System.Drawing.Size( 700, 251 );
         this.lbOutput.TabIndex = 0;
// 
// btnStart
// 
         this.btnStart.Location = new System.Drawing.Point( 13, 289 );
         this.btnStart.Name = "btnStart";
         this.btnStart.TabIndex = 1;
         this.btnStart.Text = "Start";
         this.btnStart.Click += new System.EventHandler( this.btnStart_Click );
// 
// txtClock
// 
         this.txtClock.Location = new System.Drawing.Point( 124, 292 );
         this.txtClock.Name = "txtClock";
         this.txtClock.TabIndex = 2;
// 
// btnNow
// 
         this.btnNow.Location = new System.Drawing.Point( 271, 288 );
         this.btnNow.Name = "btnNow";
         this.btnNow.TabIndex = 3;
         this.btnNow.Text = "Now";
         this.btnNow.Click += new System.EventHandler( this.btnNow_Click );
// 
// lblStatus
// 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point( 13, 331 );
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size( 0, 0 );
         this.lblStatus.TabIndex = 4;
// 
// updateTimer
// 
         this.updateTimer.Tick += new System.EventHandler( this.updateTimer_Tick );
// 
// AmazonWebServiceClient
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 725, 378 );
         this.Controls.Add( this.lblStatus );
         this.Controls.Add( this.btnNow );
         this.Controls.Add( this.txtClock );
         this.Controls.Add( this.btnStart );
         this.Controls.Add( this.lbOutput );
         this.Name = "AmazonWebServiceClient";
         this.Text = "Amazon Web Service Client Searching";
         this.Load += new System.EventHandler( this.AmazonWebServiceClient_Load );
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ListBox lbOutput;
      private System.Windows.Forms.Button btnStart;
      private System.Windows.Forms.TextBox txtClock;
      private System.Windows.Forms.Button btnNow;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.Timer updateTimer;
   }
}

