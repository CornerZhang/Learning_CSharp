namespace ProgrammaticDataDisplay
{
   partial class ProgrammaticDataDisplay
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
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).BeginInit();
         this.SuspendLayout();
// 
// dataGridView1
// 
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.dataGridView1.Location = new System.Drawing.Point( 0, 0 );
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size( 579, 262 );
         this.dataGridView1.TabIndex = 0;
// 
// ProgrammaticDataDisplay
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 579, 262 );
         this.Controls.Add( this.dataGridView1 );
         this.Name = "ProgrammaticDataDisplay";
         this.Text = "Programmatic Data Display";
         ( ( System.ComponentModel.ISupportInitialize ) ( this.dataGridView1 ) ).EndInit();
         this.ResumeLayout( false );

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
   }
}

