namespace Interop
{
   partial class ActiveXImport
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( ActiveXImport ) );
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnSubtract = new System.Windows.Forms.Button();
         this.btnMultiply = new System.Windows.Forms.Button();
         this.btnDivide = new System.Windows.Forms.Button();
         this.axCalculator1 = new AxCalcControl.AxCalculator();
         ( ( System.ComponentModel.ISupportInitialize ) ( this.axCalculator1 ) ).BeginInit();
         this.SuspendLayout();
// 
// textBox1
// 
         this.textBox1.Location = new System.Drawing.Point( 13, 13 );
         this.textBox1.Name = "textBox1";
         this.textBox1.TabIndex = 0;
// 
// textBox2
// 
         this.textBox2.Location = new System.Drawing.Point( 13, 40 );
         this.textBox2.Name = "textBox2";
         this.textBox2.TabIndex = 1;
// 
// label1
// 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point( 162, 18 );
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size( 35, 14 );
         this.label1.TabIndex = 2;
         this.label1.Text = "label1";
// 
// btnAdd
// 
         this.btnAdd.Location = new System.Drawing.Point( 13, 67 );
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.TabIndex = 3;
         this.btnAdd.Text = "Add";
         this.btnAdd.Click += new System.EventHandler( this.btnAdd_Click );
// 
// btnSubtract
// 
         this.btnSubtract.Location = new System.Drawing.Point( 95, 67 );
         this.btnSubtract.Name = "btnSubtract";
         this.btnSubtract.TabIndex = 4;
         this.btnSubtract.Text = "Subtract";
         this.btnSubtract.Click += new System.EventHandler( this.btnSubtract_Click );
// 
// btnMultiply
// 
         this.btnMultiply.Location = new System.Drawing.Point( 177, 67 );
         this.btnMultiply.Name = "btnMultiply";
         this.btnMultiply.TabIndex = 5;
         this.btnMultiply.Text = "Multiply";
         this.btnMultiply.Click += new System.EventHandler( this.btnMultiply_Click );
// 
// btnDivide
// 
         this.btnDivide.Location = new System.Drawing.Point( 259, 66 );
         this.btnDivide.Name = "btnDivide";
         this.btnDivide.TabIndex = 6;
         this.btnDivide.Text = "Divide";
         this.btnDivide.Click += new System.EventHandler( this.btnDivide_Click );
// 
// axCalculator1
// 
         this.axCalculator1.Enabled = true;
         this.axCalculator1.Location = new System.Drawing.Point( 304, -1 );
         this.axCalculator1.Name = "axCalculator1";
         this.axCalculator1.OcxState = ( ( System.Windows.Forms.AxHost.State ) ( resources.GetObject( "axCalculator1.OcxState" ) ) );
         this.axCalculator1.TabIndex = 7;
// 
// ActiveXImport
// 
         this.AutoScaleBaseSize = new System.Drawing.Size( 5, 13 );
         this.ClientSize = new System.Drawing.Size( 376, 112 );
         this.Controls.Add( this.axCalculator1 );
         this.Controls.Add( this.btnDivide );
         this.Controls.Add( this.btnMultiply );
         this.Controls.Add( this.btnSubtract );
         this.Controls.Add( this.btnAdd );
         this.Controls.Add( this.label1 );
         this.Controls.Add( this.textBox2 );
         this.Controls.Add( this.textBox1 );
         this.Name = "ActiveXImport";
         this.Text = "ActiveX Control Import Test";
         ( ( System.ComponentModel.ISupportInitialize ) ( this.axCalculator1 ) ).EndInit();
         this.ResumeLayout( false );
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnSubtract;
      private System.Windows.Forms.Button btnMultiply;
      private System.Windows.Forms.Button btnDivide;
      private AxCalcControl.AxCalculator axCalculator1;
   }
}

