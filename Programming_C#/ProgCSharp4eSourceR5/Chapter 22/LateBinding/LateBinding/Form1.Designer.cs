namespace LateBinding
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
         this.btnDivide = new System.Windows.Forms.Button();
         this.btnMultiply = new System.Windows.Forms.Button();
         this.btnSubtract = new System.Windows.Forms.Button();
         this.btnAdd = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
// 
// btnDivide
// 
         this.btnDivide.Location = new System.Drawing.Point( 259, 67 );
         this.btnDivide.Name = "btnDivide";
         this.btnDivide.TabIndex = 13;
         this.btnDivide.Text = "Divide";
         this.btnDivide.Click += new System.EventHandler( this.btnDivide_Click );
// 
// btnMultiply
// 
         this.btnMultiply.Location = new System.Drawing.Point( 177, 68 );
         this.btnMultiply.Name = "btnMultiply";
         this.btnMultiply.TabIndex = 12;
         this.btnMultiply.Text = "Multiply";
         this.btnMultiply.Click += new System.EventHandler( this.btnMultiply_Click );
// 
// btnSubtract
// 
         this.btnSubtract.Location = new System.Drawing.Point( 95, 68 );
         this.btnSubtract.Name = "btnSubtract";
         this.btnSubtract.TabIndex = 11;
         this.btnSubtract.Text = "Subtract";
         this.btnSubtract.Click += new System.EventHandler( this.btnSubtract_Click );
// 
// btnAdd
// 
         this.btnAdd.Location = new System.Drawing.Point( 13, 68 );
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.TabIndex = 10;
         this.btnAdd.Text = "Add";
         this.btnAdd.Click += new System.EventHandler( this.btnAdd_Click );
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 162, 19 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 35, 14 );
         this.label1.TabIndex = 9;
         this.label1.Text = "label1";
// 
// textBox2
// 
         this.textBox2.Location = new System.Drawing.Point( 13, 41 );
         this.textBox2.Name = "textBox2";
         this.textBox2.TabIndex = 8;
// 
// textBox1
// 
         this.textBox1.Location = new System.Drawing.Point( 13, 14 );
         this.textBox1.Name = "textBox1";
         this.textBox1.TabIndex = 7;
// 
// Form1
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 393, 120 );
         this.Controls.Add( this.btnDivide );
         this.Controls.Add( this.btnMultiply );
         this.Controls.Add( this.btnSubtract );
         this.Controls.Add( this.btnAdd );
         this.Controls.Add( this.label1 );
         this.Controls.Add( this.textBox2 );
         this.Controls.Add( this.textBox1 );
         this.Name = "Form1";
         this.Text = "Com Dll Test";
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnDivide;
      private System.Windows.Forms.Button btnMultiply;
      private System.Windows.Forms.Button btnSubtract;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.TextBox textBox1;
   }
}

