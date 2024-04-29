using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Controls;

namespace MtxVecDemo
{
	public class CalcSqrtMtxForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.ComponentModel.IContainer components = null;


		private Matrix a,b,c;
		private System.Windows.Forms.RadioButton radioButtonGeneral;
        private MtxGridView mtxGridView2;
        private MtxGridView mtxGridView1;
		private System.Windows.Forms.RadioButton radioButtonSymmetric;

		public CalcSqrtMtxForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            a = new Matrix(0, 0);
            b = new Matrix(0, 0);
            c = new Matrix(0, 0);

            mtxGridView1.DataObject = a;
            mtxGridView2.DataObject = c;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonGeneral = new System.Windows.Forms.RadioButton();
            this.radioButtonSymmetric = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(915, 404);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 574);
            this.panel3.Size = new System.Drawing.Size(915, 73);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(915, 170);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonGeneral);
            this.groupBox1.Controls.Add(this.radioButtonSymmetric);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matrix type";
            // 
            // radioButtonGeneral
            // 
            this.radioButtonGeneral.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonGeneral.Location = new System.Drawing.Point(10, 49);
            this.radioButtonGeneral.Name = "radioButtonGeneral";
            this.radioButtonGeneral.Size = new System.Drawing.Size(124, 30);
            this.radioButtonGeneral.TabIndex = 1;
            this.radioButtonGeneral.Text = "General";
            // 
            // radioButtonSymmetric
            // 
            this.radioButtonSymmetric.Checked = true;
            this.radioButtonSymmetric.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonSymmetric.Location = new System.Drawing.Point(10, 20);
            this.radioButtonSymmetric.Name = "radioButtonSymmetric";
            this.radioButtonSymmetric.Size = new System.Drawing.Size(124, 29);
            this.radioButtonSymmetric.TabIndex = 0;
            this.radioButtonSymmetric.TabStop = true;
            this.radioButtonSymmetric.Text = "Symmetric";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.mtxGridView2);
            this.panel4.Controls.Add(this.mtxGridView1);
            this.panel4.Location = new System.Drawing.Point(192, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(411, 386);
            this.panel4.TabIndex = 1;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxGridView2.Location = new System.Drawing.Point(0, 0);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.ObjectInfoText = "";
            this.mtxGridView2.ReadOnly = true;
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.ShowObjectInfo = true;
            this.mtxGridView2.Size = new System.Drawing.Size(411, 386);
            this.mtxGridView2.TabIndex = 1;
            this.mtxGridView2.VirtualMode = true;
            // 
            // mtxGridView1
            // 
            this.mtxGridView1.AllowUserToAddRows = false;
            this.mtxGridView1.AllowUserToDeleteRows = false;
            this.mtxGridView1.AllowUserToResizeColumns = false;
            this.mtxGridView1.AllowUserToResizeRows = false;
            this.mtxGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridView1.Location = new System.Drawing.Point(0, 0);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(706, 386);
            this.mtxGridView1.TabIndex = 0;
            this.mtxGridView1.VirtualMode = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(19, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate random matrix";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(202, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "SQRT(A)";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(307, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "SQRT(A)*SQRT(A)";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CalcSqrtMtxForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(915, 647);
            this.Name = "CalcSqrtMtxForm";
            this.Load += new System.EventHandler(this.CalcSqrtMtxForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void panel4_Resize(object sender, System.EventArgs e) 
        {
            mtxGridView1.Height = panel4.Height / 2;
		}

		private void makeSymmetric(TMtx mtx) {
			for (int i=0;i<mtx.Rows;i++) 
				for (int j=0;j<mtx.Cols;j++) {
					if (i>j) mtx.Values[i,j] = mtx.Values[j,i];
				}
		}


		private void button1_Click(object sender, System.EventArgs e) 
        {
			a.Size(4,4,false);
			a.RandUniform(2,10);
			if (radioButtonSymmetric.Checked) makeSymmetric(a);
            mtxGridView1.UpdateGrid();
            
            button2.Enabled = true;
			button3.Enabled = false;
		}

		private void button2_Click(object sender, System.EventArgs e) {
			if (radioButtonSymmetric.Checked) c.MtxSqrt(a,TMtxType.mtSymmetric);
			else c.MtxSqrt(a,TMtxType.mtGeneral);
            mtxGridView2.UpdateGrid();
            button3.Enabled = true;
		}

		private void button3_Click(object sender, System.EventArgs e) {
            TMtx compare = new TMtx();
            b.Mul(c,c,TMtxOperation.opNone,TMtxOperation.opNone);
			if (b.Complex) compare.RealPart(b);
			else compare.Copy(b);
			if (compare.Equal(a,1.0E-3)) MessageBox.Show("Succeeded!");
			else MessageBox.Show("Failed!");
			button3.Enabled = false;
		}

		private void CalcSqrtMtxForm_Load(object sender, System.EventArgs e) {
			Add("SqrtMtx is an example of a matrix function.");
			Add("");
			Add("You can apply any function (Log, Exp, Power...) "
				+ "to the matrix via the MtxFunction method. In this "
				+ "case the result is obtained via eigenvalue "
				+ "decomposition.");
		}
	}
}

