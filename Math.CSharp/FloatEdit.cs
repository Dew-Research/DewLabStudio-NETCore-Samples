using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
	public class FloatEditForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
        private Dew.Math.Controls.FloatEdit floatEdit2;
        private Dew.Math.Controls.FloatEdit floatEdit1;
		private System.ComponentModel.IContainer components = null;

		public FloatEditForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.floatEdit1 = new Dew.Math.Controls.FloatEdit();
            this.floatEdit2 = new Dew.Math.Controls.FloatEdit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.floatEdit2);
            this.panel2.Controls.Add(this.floatEdit1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(615, 251);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Size = new System.Drawing.Size(615, 73);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(615, 170);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Z1 = ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z2 = ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 23);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(235, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operation";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(230, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Z1 * Z2";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(230, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Z1 / Z2";
            this.button2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(230, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 28);
            this.button3.TabIndex = 6;
            this.button3.Text = "Z1 + Z2";
            this.button3.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(230, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 28);
            this.button4.TabIndex = 6;
            this.button4.Text = "Z1 - Z2";
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // floatEdit1
            // 
            this.floatEdit1.Increment = "0.100000001490116";
            this.floatEdit1.Location = new System.Drawing.Point(46, 25);
            this.floatEdit1.Name = "floatEdit1";
            this.floatEdit1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.floatEdit1.Size = new System.Drawing.Size(144, 23);
            this.floatEdit1.StoreInRegistry = true;
            this.floatEdit1.TabIndex = 7;
            this.floatEdit1.Value = "2+2i";
            // 
            // floatEdit2
            // 
            this.floatEdit2.Increment = "0.100000001490116";
            this.floatEdit2.Location = new System.Drawing.Point(46, 64);
            this.floatEdit2.Name = "floatEdit2";
            this.floatEdit2.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.floatEdit2.Size = new System.Drawing.Size(144, 23);
            this.floatEdit2.StoreInRegistry = true;
            this.floatEdit2.TabIndex = 8;
            this.floatEdit2.Value = "1+5i";
            // 
            // FloatEditForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(615, 494);
            this.Name = "FloatEditForm";
            this.Load += new System.EventHandler(this.FloatEditForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		private void button1_Click_1(object sender, System.EventArgs e) {
			TCplx z1 = floatEdit1.CplxPosition;
			TCplx z2 = floatEdit2.CplxPosition;
			TCplx res = Math387.StrToCplx("0");
			if (sender == button1) res = Math387.CMul(z1,z2);
			if (sender == button2) res = Math387.CDiv(z1,z2);
			if (sender == button3) res = Math387.CAdd(z1,z2);
			if (sender == button4) res = Math387.CSub(z1,z2);
			textBox1.Text = Math387.CplxToStr(res,4,7);
		}

		private void FloatEditForm_Load(object sender, System.EventArgs e) {
			Add("The Dew.Math.Controls.FloatEdit control can be used to edit/view/change "
				+ "real or complex number. The control also includes runtime complex "
				+ "number format editor. You can invoke it with :");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;		
			Add("holding the CTRL key and double clicking on FloatEdit control");
			Add("in code by calling FloatEdit Execute method");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;		
		}
	}
}

