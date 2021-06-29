using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
	public class SysLinearForm : MtxVecDemo.BasicForm2
    {
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label8;
		private System.ComponentModel.IContainer components = null;

		private Matrix a;
		private Vector b,x,s;
        private Dew.Math.Controls.MtxGridView mtxGridView3;
        private Dew.Math.Controls.MtxGridView mtxGridView2;
        private Dew.Math.Controls.MtxGridView mtxGridView1;
        private Dew.Math.Controls.MtxGridView mtxGridView4;

		public SysLinearForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            a = new Matrix(0, 0);
            b = new Vector(0);
            x = new Vector(0);
            s = new Vector(0);

			a.SetIt(4,4,false,new double[]{ 0.001,  0, 0, 0,
										    3    ,0.001,   0, 0,
											2.5  ,  2,     3, 0,
											4    , -1,   0.5, 0.1});
			b.SetIt(new double[]{3, 1.5, -2, 4});
            mtxGridView1.DataObject = a;
            mtxGridView2.DataObject = x;
            mtxGridView3.DataObject = b;
            mtxGridView4.DataObject = s;
            
            comboBox1.SelectedIndex = 0;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mtxGridView4 = new Dew.Math.Controls.MtxGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView3 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtxGridView3);
            this.panel2.Controls.Add(this.mtxGridView2);
            this.panel2.Controls.Add(this.mtxGridView1);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(893, 411);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 581);
            this.panel3.Size = new System.Drawing.Size(893, 59);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(893, 170);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Method";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "LUSolve",
            "SVDSolve"});
            this.comboBox1.Location = new System.Drawing.Point(67, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(382, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(578, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(550, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Solve";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(10, 217);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(432, 157);
            this.panel4.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(220, 98);
            this.textBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(202, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Report";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(10, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition Norm";
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(10, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "cnNormInf";
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(10, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "cnNorm1";
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(115, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "cnNone";
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(10, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Refine solution";
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mtxGridView4);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(10, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(153, 167);
            this.panel5.TabIndex = 11;
            this.panel5.Visible = false;
            // 
            // mtxGridView4
            // 
            this.mtxGridView4.AllowUserToAddRows = false;
            this.mtxGridView4.AllowUserToDeleteRows = false;
            this.mtxGridView4.AllowUserToResizeColumns = false;
            this.mtxGridView4.AllowUserToResizeRows = false;
            this.mtxGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridView4.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "0.0000";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView4.DefaultCellStyle = dataGridViewCellStyle4;
            this.mtxGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxGridView4.IntPrecision = Dew.Math.TIntPrecision.prInt32;
            this.mtxGridView4.IsInteger = false;
            this.mtxGridView4.Location = new System.Drawing.Point(0, 0);
            this.mtxGridView4.MultiSelect = false;
            this.mtxGridView4.Name = "mtxGridView4";
            this.mtxGridView4.ObjectInfoText = "";
            this.mtxGridView4.ReadOnly = true;
            this.mtxGridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView4.Size = new System.Drawing.Size(153, 167);
            this.mtxGridView4.TabIndex = 2;
            this.mtxGridView4.VirtualMode = true;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Singular values";
            // 
            // mtxGridView1
            // 
            this.mtxGridView1.AllowUserToAddRows = false;
            this.mtxGridView1.AllowUserToDeleteRows = false;
            this.mtxGridView1.AllowUserToResizeColumns = false;
            this.mtxGridView1.AllowUserToResizeRows = false;
            this.mtxGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.mtxGridView1.IntPrecision = Dew.Math.TIntPrecision.prInt32;
            this.mtxGridView1.IsInteger = false;
            this.mtxGridView1.Location = new System.Drawing.Point(10, 23);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.ObjectInfoText = "A";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(364, 138);
            this.mtxGridView1.TabIndex = 12;
            this.mtxGridView1.VirtualMode = true;
            // 
            // mtxGridView2
            // 
            this.mtxGridView2.AllowUserToAddRows = false;
            this.mtxGridView2.AllowUserToDeleteRows = false;
            this.mtxGridView2.AllowUserToResizeColumns = false;
            this.mtxGridView2.AllowUserToResizeRows = false;
            this.mtxGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridView2.IntPrecision = Dew.Math.TIntPrecision.prInt32;
            this.mtxGridView2.IsInteger = false;
            this.mtxGridView2.Location = new System.Drawing.Point(409, 23);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.ObjectInfoText = "X";
            this.mtxGridView2.ReadOnly = true;
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.ShowObjectInfo = true;
            this.mtxGridView2.Size = new System.Drawing.Size(162, 138);
            this.mtxGridView2.TabIndex = 13;
            this.mtxGridView2.VirtualMode = true;
            // 
            // mtxGridView3
            // 
            this.mtxGridView3.AllowUserToAddRows = false;
            this.mtxGridView3.AllowUserToDeleteRows = false;
            this.mtxGridView3.AllowUserToResizeColumns = false;
            this.mtxGridView3.AllowUserToResizeRows = false;
            this.mtxGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridView3.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView3.IntPrecision = Dew.Math.TIntPrecision.prInt32;
            this.mtxGridView3.IsInteger = false;
            this.mtxGridView3.Location = new System.Drawing.Point(614, 23);
            this.mtxGridView3.MultiSelect = false;
            this.mtxGridView3.Name = "mtxGridView3";
            this.mtxGridView3.ObjectInfoText = "B (RHS)";
            this.mtxGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mtxGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView3.ShowObjectInfo = true;
            this.mtxGridView3.Size = new System.Drawing.Size(158, 138);
            this.mtxGridView3.TabIndex = 14;
            this.mtxGridView3.VirtualMode = true;
            // 
            // SysLinearForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(893, 640);
            this.Name = "SysLinearForm";
            this.Load += new System.EventHandler(this.SysLinearForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			if (comboBox1.SelectedIndex == 0) {
				panel4.Visible = true;
				panel5.Visible = ! panel4.Visible;
			} else if (comboBox1.SelectedIndex == 1) {
				panel4.Visible = false;
				panel5.Visible = ! panel4.Visible;
			}
			textBox1.Text="";
		}

		private void SysLinearForm_Load(object sender, System.EventArgs e) {
			Add("MtxVec offers three different methods to solve a system "
				+ "of linear equations : LU, LQR and singular value "
				+ "decomposition. Each of these methods has its advantages "
				+ "and disadvantages. Try changing values in matrix A, "
				+ "vector b and method used to calculate the solution vector "
				+ "x. The displayed matrix is nearly singular. You can add "
				+ "more non-zero elements to the diagonal to make it non-singular.");
			Add("In practice, most computations are performed with rounding "
				+ "errors. The LUSolve method offers you additional tools for "
				+ "refining the solution and estimating its error. They are "
				+ "evaluated only if RefineSolution is set to true");
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
				richTextBox1.SelectionFont.Size, FontStyle.Underline);
			Add("Parameters in this demo :");
			Add("ConditionNr: If your matrix is ill-conditioned "
				+ "(that is, it's ConditionNr is very small), then the error in "
				+ "the solution x is also large. ");
			Add("BackError: the smallest relative perturbation in elements "
				+ "of A and b such that x is the exact solution of the perturbed "
				+ "system.");
			Add("ForwError: the component-wise forward error in the computed "
				+ "solution.");
			Add("");
			Add("Try changing the matrix values and observe the solution, CondtionNr, ForwError and BackError.");

			comboBox1_SelectedIndexChanged(null,null);
			checkBox1_Click(checkBox1,null);
			radioButton1_Click(null,null);
		}

		private void checkBox1_Click(object sender, System.EventArgs e) {
			a.RefineSolution = (sender as CheckBox).Checked;
		}

		private void radioButton1_Click(object sender, System.EventArgs e) {
			if (radioButton1.Checked) a.ConditionNumber = TConditionNumber.cnNone;
			else if (radioButton2.Checked) a.ConditionNumber = TConditionNumber.cnNorm1;
			else if (radioButton3.Checked) a.ConditionNumber = TConditionNumber.cnNormInf;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			if (comboBox1.SelectedIndex == 0) {
				a.LUSolve(b,x,TMtxType.mtGeneral,TMtxOperation.opNone);
				textBox1.Text = "";
				if (checkBox1.Checked && !radioButton1.Checked) {
					textBox1.Text = "Forward error = " + a.ForwError.ToString("0.0000E+00")+ 
						"\r\nBackward error = " + a.BackError.ToString("0.0000E+00")+
						"\r\nConditionNr = " + a.ConditionNr.ToString("0.0000E+00");

				}
			} else if (comboBox1.SelectedIndex == 1) {
				a.SVDSolve(b,x,s,0); // TODO
                mtxGridView4.UpdateGrid();
			}
            mtxGridView2.UpdateGrid();
        }
	}
}

