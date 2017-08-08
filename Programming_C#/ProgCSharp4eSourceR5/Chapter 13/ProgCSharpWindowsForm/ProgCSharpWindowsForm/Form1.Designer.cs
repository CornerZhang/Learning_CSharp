namespace ProgCSharpWindowsForm
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
         this.button1 = new System.Windows.Forms.Button();
         this.SuspendLayout();
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( ( byte ) ( 0 ) ) );
         this.label1.Location = new System.Drawing.Point( 13, 13 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 118, 26 );
         this.label1.TabIndex = 0;
         this.label1.Text = "Hello World";
// 
// button1
// 
         this.button1.Location = new System.Drawing.Point( 13, 46 );
         this.button1.Name = "button1";
         this.button1.TabIndex = 1;
         this.button1.Text = "Cancel";
         this.button1.Click += new System.EventHandler( this.button1_Click );
// 
// Form1
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 199, 132 );
         this.Controls.Add( this.button1 );
         this.Controls.Add( this.label1 );
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button button1;

   }
}

