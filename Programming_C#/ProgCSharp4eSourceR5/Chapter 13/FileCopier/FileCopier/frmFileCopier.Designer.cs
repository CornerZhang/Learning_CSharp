namespace FileCopier
{
   partial class frmFileCopier
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
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.tvwSource = new System.Windows.Forms.TreeView();
         this.tvwTarget = new System.Windows.Forms.TreeView();
         this.btnClear = new System.Windows.Forms.Button();
         this.chkOverwrite = new System.Windows.Forms.CheckBox();
         this.btnCopy = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.lblStatus = new System.Windows.Forms.Label();
         this.txtTargetDir = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.label1.Location = new System.Drawing.Point( 13, 30 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 101, 21 );
         this.label1.TabIndex = 0;
         this.label1.Text = "Source Files";
// 
// label2
// 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 12F, ( ( System.Drawing.FontStyle ) ( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.label2.Location = new System.Drawing.Point( 287, 30 );
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size( 97, 21 );
         this.label2.TabIndex = 1;
         this.label2.Text = "Target Files";
// 
// tvwSource
// 
         this.tvwSource.CheckBoxes = true;
         this.tvwSource.Location = new System.Drawing.Point( 13, 58 );
         this.tvwSource.Name = "tvwSource";
         this.tvwSource.Size = new System.Drawing.Size( 252, 348 );
         this.tvwSource.TabIndex = 2;
         this.tvwSource.AfterCheck += new System.Windows.Forms.TreeViewEventHandler( this.tvwSource_AfterCheck );
         this.tvwSource.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler( this.tvwExpand );
// 
// tvwTarget
// 
         this.tvwTarget.Location = new System.Drawing.Point( 287, 85 );
         this.tvwTarget.Name = "tvwTarget";
         this.tvwTarget.Size = new System.Drawing.Size( 252, 321 );
         this.tvwTarget.TabIndex = 3;
         this.tvwTarget.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler( this.tvwExpand );
         this.tvwTarget.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.tvwTargetDir_AfterSelect );
// 
// btnClear
// 
         this.btnClear.Location = new System.Drawing.Point( 72, 413 );
         this.btnClear.Name = "btnClear";
         this.btnClear.TabIndex = 4;
         this.btnClear.Text = "Clear";
         this.btnClear.Click += new System.EventHandler( this.btnClear_Click );
// 
// chkOverwrite
// 
         this.chkOverwrite.AutoSize = true;
         this.chkOverwrite.Location = new System.Drawing.Point( 287, 413 );
         this.chkOverwrite.Name = "chkOverwrite";
         this.chkOverwrite.Size = new System.Drawing.Size( 104, 17 );
         this.chkOverwrite.TabIndex = 5;
         this.chkOverwrite.Text = "Overwrite if exists";
// 
// btnCopy
// 
         this.btnCopy.Location = new System.Drawing.Point( 463, 413 );
         this.btnCopy.Name = "btnCopy";
         this.btnCopy.TabIndex = 6;
         this.btnCopy.Text = "Copy";
         this.btnCopy.Click += new System.EventHandler( this.btnCopy_Click );
// 
// btnDelete
// 
         this.btnDelete.Location = new System.Drawing.Point( 463, 443 );
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.TabIndex = 7;
         this.btnDelete.Text = "Delete";
         this.btnDelete.Click += new System.EventHandler( this.btnDelete_Click );
// 
// btnCancel
// 
         this.btnCancel.Location = new System.Drawing.Point( 463, 473 );
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.TabIndex = 8;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
// 
// lblStatus
// 
         this.lblStatus.AutoSize = true;
         this.lblStatus.Location = new System.Drawing.Point( 13, 451 );
         this.lblStatus.Name = "lblStatus";
         this.lblStatus.Size = new System.Drawing.Size( 36, 14 );
         this.lblStatus.TabIndex = 9;
         this.lblStatus.Text = "Status";
// 
// txtTargetDir
// 
         this.txtTargetDir.Location = new System.Drawing.Point( 287, 58 );
         this.txtTargetDir.Name = "txtTargetDir";
         this.txtTargetDir.Size = new System.Drawing.Size( 251, 20 );
         this.txtTargetDir.TabIndex = 10;
// 
// frmFileCopier
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 569, 525 );
         this.Controls.Add( this.txtTargetDir );
         this.Controls.Add( this.lblStatus );
         this.Controls.Add( this.btnCancel );
         this.Controls.Add( this.btnDelete );
         this.Controls.Add( this.btnCopy );
         this.Controls.Add( this.chkOverwrite );
         this.Controls.Add( this.btnClear );
         this.Controls.Add( this.tvwTarget );
         this.Controls.Add( this.tvwSource );
         this.Controls.Add( this.label2 );
         this.Controls.Add( this.label1 );
         this.Name = "frmFileCopier";
         this.Text = "File Copier";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TreeView tvwSource;
      private System.Windows.Forms.TreeView tvwTarget;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.CheckBox chkOverwrite;
      private System.Windows.Forms.Button btnCopy;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Label lblStatus;
      private System.Windows.Forms.TextBox txtTargetDir;
   }
}

