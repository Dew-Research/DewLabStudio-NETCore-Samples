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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            floatEdit1 = new Dew.Math.Controls.FloatEdit();
            floatEdit2 = new Dew.Math.Controls.FloatEdit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(floatEdit2);
            panel2.Controls.Add(floatEdit1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Size = new Size(778, 366);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 504);
            panel3.Size = new Size(778, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(778, 138);
            // 
            // label1
            // 
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 29);
            label1.TabIndex = 1;
            label1.Text = "Z1 = ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Location = new Point(10, 59);
            label2.Name = "label2";
            label2.Size = new Size(48, 30);
            label2.TabIndex = 1;
            label2.Text = "Z2 = ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(10, 148);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 4;
            label3.Text = "Result";
            // 
            // label4
            // 
            label4.Location = new Point(235, 10);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 5;
            label4.Text = "Operation";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(230, 30);
            button1.Name = "button1";
            button1.Size = new Size(106, 28);
            button1.TabIndex = 6;
            button1.Text = "Z1 * Z2";
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(230, 59);
            button2.Name = "button2";
            button2.Size = new Size(106, 28);
            button2.TabIndex = 6;
            button2.Text = "Z1 / Z2";
            button2.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(230, 89);
            button3.Name = "button3";
            button3.Size = new Size(106, 28);
            button3.TabIndex = 6;
            button3.Text = "Z1 + Z2";
            button3.Click += button1_Click_1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(230, 118);
            button4.Name = "button4";
            button4.Size = new Size(106, 28);
            button4.TabIndex = 6;
            button4.Text = "Z1 - Z2";
            button4.Click += button1_Click_1;
            // 
            // floatEdit1
            // 
            floatEdit1.Increment = "0.100000001490116";
            floatEdit1.Location = new Point(46, 25);
            floatEdit1.Name = "floatEdit1";
            floatEdit1.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            floatEdit1.Size = new Size(144, 23);
            floatEdit1.StoreInRegistry = true;
            floatEdit1.TabIndex = 7;
            floatEdit1.Value = "2+2i";
            // 
            // floatEdit2
            // 
            floatEdit2.Increment = "0.100000001490116";
            floatEdit2.Location = new Point(46, 64);
            floatEdit2.Name = "floatEdit2";
            floatEdit2.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            floatEdit2.Size = new Size(144, 23);
            floatEdit2.StoreInRegistry = true;
            floatEdit2.TabIndex = 8;
            floatEdit2.Value = "1+5i";
            // 
            // FloatEditForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(778, 563);
            Name = "FloatEditForm";
            Load += FloatEditForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

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

