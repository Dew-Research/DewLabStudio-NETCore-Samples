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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            panel5 = new Panel();
            mtxGridView4 = new Dew.Math.Controls.MtxGridView();
            label8 = new Label();
            mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            mtxGridView3 = new Dew.Math.Controls.MtxGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((ISupportInitialize)mtxGridView4).BeginInit();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            ((ISupportInitialize)mtxGridView2).BeginInit();
            ((ISupportInitialize)mtxGridView3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(mtxGridView3);
            panel2.Controls.Add(mtxGridView2);
            panel2.Controls.Add(mtxGridView1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label6);
            panel2.Size = new Size(881, 402);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 540);
            panel3.Size = new Size(881, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(881, 138);
            // 
            // label4
            // 
            label4.Location = new Point(10, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 6;
            label4.Text = "Method";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "LUSolve", "SVDSolve" });
            comboBox1.Location = new Point(67, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(382, 89);
            label5.Name = "label5";
            label5.Size = new Size(19, 29);
            label5.TabIndex = 8;
            label5.Text = "x";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(578, 89);
            label6.Name = "label6";
            label6.Size = new Size(29, 29);
            label6.TabIndex = 8;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(550, 183);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 9;
            button1.Text = "Solve";
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(checkBox1);
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(10, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 157);
            panel4.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 30);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(220, 98);
            textBox1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Location = new Point(202, 10);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 2;
            label7.Text = "Report";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(10, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 89);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condition Norm";
            // 
            // radioButton3
            // 
            radioButton3.Location = new Point(10, 59);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(115, 20);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "cnNormInf";
            radioButton3.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.Location = new Point(10, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(115, 20);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "cnNorm1";
            radioButton2.Click += radioButton1_Click;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(115, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "cnNone";
            radioButton1.Click += radioButton1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(10, 10);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 20);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Refine solution";
            checkBox1.Click += checkBox1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(mtxGridView4);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(10, 217);
            panel5.Name = "panel5";
            panel5.Size = new Size(153, 167);
            panel5.TabIndex = 11;
            panel5.Visible = false;
            // 
            // mtxGridView4
            // 
            mtxGridView4.AllowUserToAddRows = false;
            mtxGridView4.AllowUserToDeleteRows = false;
            mtxGridView4.AllowUserToResizeColumns = false;
            mtxGridView4.AllowUserToResizeRows = false;
            mtxGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridView4.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "0.0000";
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            mtxGridView4.DefaultCellStyle = dataGridViewCellStyle4;
            mtxGridView4.Dock = DockStyle.Fill;
            mtxGridView4.Location = new Point(0, 0);
            mtxGridView4.MultiSelect = false;
            mtxGridView4.Name = "mtxGridView4";
            mtxGridView4.numberFormat = "0.0000";
            mtxGridView4.ObjectInfoText = "";
            mtxGridView4.ReadOnly = true;
            mtxGridView4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView4.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView4.Size = new Size(153, 167);
            mtxGridView4.TabIndex = 2;
            mtxGridView4.VirtualMode = true;
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 1;
            label8.Text = "Singular values";
            // 
            // mtxGridView1
            // 
            mtxGridView1.AllowUserToAddRows = false;
            mtxGridView1.AllowUserToDeleteRows = false;
            mtxGridView1.AllowUserToResizeColumns = false;
            mtxGridView1.AllowUserToResizeRows = false;
            mtxGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            mtxGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            mtxGridView1.Location = new Point(10, 23);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "A";
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(364, 138);
            mtxGridView1.TabIndex = 12;
            mtxGridView1.VirtualMode = true;
            // 
            // mtxGridView2
            // 
            mtxGridView2.AllowUserToAddRows = false;
            mtxGridView2.AllowUserToDeleteRows = false;
            mtxGridView2.AllowUserToResizeColumns = false;
            mtxGridView2.AllowUserToResizeRows = false;
            mtxGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            mtxGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            mtxGridView2.Location = new Point(409, 23);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "X";
            mtxGridView2.ReadOnly = true;
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.ShowObjectInfo = true;
            mtxGridView2.Size = new Size(162, 138);
            mtxGridView2.TabIndex = 13;
            mtxGridView2.VirtualMode = true;
            // 
            // mtxGridView3
            // 
            mtxGridView3.AllowUserToAddRows = false;
            mtxGridView3.AllowUserToDeleteRows = false;
            mtxGridView3.AllowUserToResizeColumns = false;
            mtxGridView3.AllowUserToResizeRows = false;
            mtxGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridView3.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridView3.Location = new Point(614, 23);
            mtxGridView3.MultiSelect = false;
            mtxGridView3.Name = "mtxGridView3";
            mtxGridView3.numberFormat = "0.0000";
            mtxGridView3.ObjectInfoText = "B (RHS)";
            mtxGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            mtxGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView3.ShowObjectInfo = true;
            mtxGridView3.Size = new Size(158, 138);
            mtxGridView3.TabIndex = 14;
            mtxGridView3.VirtualMode = true;
            // 
            // SysLinearForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(881, 599);
            Name = "SysLinearForm";
            Load += SysLinearForm_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView4).EndInit();
            ((ISupportInitialize)mtxGridView1).EndInit();
            ((ISupportInitialize)mtxGridView2).EndInit();
            ((ISupportInitialize)mtxGridView3).EndInit();
            ResumeLayout(false);

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

