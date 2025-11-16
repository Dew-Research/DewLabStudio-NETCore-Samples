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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            radioButtonGeneral = new RadioButton();
            radioButtonSymmetric = new RadioButton();
            panel4 = new Panel();
            mtxGridView2 = new MtxGridView();
            mtxGridView1 = new MtxGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((ISupportInitialize)mtxGridView2).BeginInit();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(groupBox1);
            panel2.Size = new Size(1001, 481);
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 619);
            panel3.Size = new Size(1001, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1001, 138);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonGeneral);
            groupBox1.Controls.Add(radioButtonSymmetric);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(144, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Matrix type";
            // 
            // radioButtonGeneral
            // 
            radioButtonGeneral.FlatStyle = FlatStyle.System;
            radioButtonGeneral.Location = new Point(10, 49);
            radioButtonGeneral.Name = "radioButtonGeneral";
            radioButtonGeneral.Size = new Size(124, 30);
            radioButtonGeneral.TabIndex = 1;
            radioButtonGeneral.Text = "General";
            // 
            // radioButtonSymmetric
            // 
            radioButtonSymmetric.Checked = true;
            radioButtonSymmetric.FlatStyle = FlatStyle.System;
            radioButtonSymmetric.Location = new Point(10, 20);
            radioButtonSymmetric.Name = "radioButtonSymmetric";
            radioButtonSymmetric.Size = new Size(124, 29);
            radioButtonSymmetric.TabIndex = 0;
            radioButtonSymmetric.TabStop = true;
            radioButtonSymmetric.Text = "Symmetric";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(mtxGridView2);
            panel4.Controls.Add(mtxGridView1);
            panel4.Location = new Point(192, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 465);
            panel4.TabIndex = 1;
            panel4.Resize += panel4_Resize;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridView2.Dock = DockStyle.Fill;
            mtxGridView2.Location = new Point(0, 155);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "";
            mtxGridView2.ReadOnly = true;
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.ShowObjectInfo = true;
            mtxGridView2.Size = new Size(799, 310);
            mtxGridView2.TabIndex = 1;
            mtxGridView2.VirtualMode = true;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            mtxGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            mtxGridView1.Dock = DockStyle.Top;
            mtxGridView1.Location = new Point(0, 0);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "";
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(799, 155);
            mtxGridView1.TabIndex = 0;
            mtxGridView1.VirtualMode = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(19, 10);
            button1.Name = "button1";
            button1.Size = new Size(163, 28);
            button1.TabIndex = 0;
            button1.Text = "Generate random matrix";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(202, 10);
            button2.Name = "button2";
            button2.Size = new Size(90, 28);
            button2.TabIndex = 1;
            button2.Text = "SQRT(A)";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(307, 10);
            button3.Name = "button3";
            button3.Size = new Size(144, 28);
            button3.TabIndex = 2;
            button3.Text = "SQRT(A)*SQRT(A)";
            button3.Click += button3_Click;
            // 
            // CalcSqrtMtxForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1001, 678);
            Name = "CalcSqrtMtxForm";
            Load += CalcSqrtMtxForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView2).EndInit();
            ((ISupportInitialize)mtxGridView1).EndInit();
            ResumeLayout(false);

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

