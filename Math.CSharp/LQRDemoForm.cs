using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;

namespace MtxVecDemo
{
	public class LQRDemoForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.ComponentModel.IContainer components = null;


		private Matrix tmpM1, tmpM2, tmpM3, a, l, q, r;
        private Dew.Math.Controls.MtxGridView mtxGridView1;
        private Dew.Math.Controls.MtxGridView mtxGridView3;
        private Dew.Math.Controls.MtxGridView mtxGridView2;
		private Vector s;

		public LQRDemoForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            a = new Matrix(0, 0);
            l = new Matrix(0, 0);
            q = new Matrix(0, 0);
            r = new Matrix(0, 0);
            tmpM1 = new Matrix(0, 0);
            tmpM2 = new Matrix(0, 0);
            tmpM3 = new Matrix(0, 0);

            mtxGridView1.DataObject = a;

            s = new Vector(0);
			s.Caption = "Singular values";
			radioButton2_Click(null, null);
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            mtxGridView3 = new Dew.Math.Controls.MtxGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(groupBox1);
            panel2.Size = new Size(977, 429);
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 567);
            panel3.Size = new Size(977, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(977, 138);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Examples";
            // 
            // radioButton4
            // 
            radioButton4.FlatStyle = FlatStyle.System;
            radioButton4.Location = new Point(10, 79);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(153, 19);
            radioButton4.TabIndex = 3;
            radioButton4.Text = "SVD (Rows > Cols)";
            radioButton4.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.FlatStyle = FlatStyle.System;
            radioButton3.Location = new Point(10, 59);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(163, 20);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "SVD (Rows < Cols)";
            radioButton3.Click += radioButton2_Click;
            // 
            // radioButton2
            // 
            radioButton2.FlatStyle = FlatStyle.System;
            radioButton2.Location = new Point(10, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(163, 20);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "QR (Rows > Cols)";
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.FlatStyle = FlatStyle.System;
            radioButton1.Location = new Point(10, 20);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(163, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "LQ (Rows < Cols)";
            radioButton1.Click += radioButton2_Click;
            // 
            // checkBox1
            // 
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(10, 128);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(182, 20);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "\"Economy\" size";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(10, 20);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 0;
            button1.Text = "Perform decomposition";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(192, 20);
            button2.Name = "button2";
            button2.Size = new Size(115, 29);
            button2.TabIndex = 1;
            button2.Text = "Singular values";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(317, 20);
            button3.Name = "button3";
            button3.Size = new Size(105, 29);
            button3.TabIndex = 2;
            button3.Text = "QR = A?";
            button3.Click += button3_Click;
            // 
            // mtxGridView1
            // 
            mtxGridView1.AllowUserToAddRows = false;
            mtxGridView1.AllowUserToDeleteRows = false;
            mtxGridView1.AllowUserToResizeColumns = false;
            mtxGridView1.AllowUserToResizeRows = false;
            mtxGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            mtxGridView1.Location = new Point(265, 10);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "A";
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(667, 184);
            mtxGridView1.TabIndex = 4;
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
            mtxGridView2.Location = new Point(10, 202);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "";
            mtxGridView2.ReadOnly = true;
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.ShowObjectInfo = true;
            mtxGridView2.Size = new Size(372, 184);
            mtxGridView2.TabIndex = 5;
            mtxGridView2.VirtualMode = true;
            // 
            // mtxGridView3
            // 
            mtxGridView3.AllowUserToAddRows = false;
            mtxGridView3.AllowUserToDeleteRows = false;
            mtxGridView3.AllowUserToResizeColumns = false;
            mtxGridView3.AllowUserToResizeRows = false;
            mtxGridView3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            mtxGridView3.Location = new Point(406, 202);
            mtxGridView3.MultiSelect = false;
            mtxGridView3.Name = "mtxGridView3";
            mtxGridView3.numberFormat = "0.0000";
            mtxGridView3.ObjectInfoText = "";
            mtxGridView3.ReadOnly = true;
            mtxGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView3.ShowObjectInfo = true;
            mtxGridView3.Size = new Size(526, 184);
            mtxGridView3.TabIndex = 6;
            mtxGridView3.VirtualMode = true;
            // 
            // LQRDemoForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(977, 626);
            Name = "LQRDemoForm";
            Load += LQRDemoForm_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView1).EndInit();
            ((ISupportInitialize)mtxGridView2).EndInit();
            ((ISupportInitialize)mtxGridView3).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private void radioButton2_Click(object sender, System.EventArgs e) {
			if (radioButton1.Checked) {
				a.Size(2,4);
				a.RandUniform(2,10);
				button3.Text = "LQ = A ?";
			} else if (radioButton2.Checked) {
				a.Size(3,2);
				a.RandUniform(-10,-3);
				button3.Text = "QR = A ?";
			} else if (radioButton3.Checked) {
				a.Size(2,4);
				a.RandUniform(2,10);
				a.SetZero(0,0,1,0);
				button3.Text = "USV' = A ?";
			} else if (radioButton4.Checked) {
				a.Size(3,2);
				a.RandUniform(2,10);
				a.SetZero(0,0,0,1);
				button3.Text = "USV' = A ?";
			}
            mtxGridView1.UpdateGrid();
            
            button2.Enabled = false;
			button3.Enabled = false;
}
		private void button1_Click(object sender, System.EventArgs e) {
			if (radioButton1.Checked) {
				a.LQR(l,q,null,checkBox1.Checked);
                mtxGridView2.ObjectInfoText = "L";
                mtxGridView2.DataObject = l;
                mtxGridView3.ObjectInfoText = "Q";
                mtxGridView3.DataObject = q;
			} else if (radioButton2.Checked) {
				a.LQR(null,q,r,checkBox1.Checked);
                mtxGridView2.ObjectInfoText = "Q";
                mtxGridView2.DataObject = q;
                mtxGridView3.ObjectInfoText = "R";
                mtxGridView3.DataObject = r;
            }
            else if (radioButton3.Checked || radioButton4.Checked)
            {
				button2.Enabled = true;
				a.SVD(l,s,q,checkBox1.Checked);
                mtxGridView2.ObjectInfoText = "U";
                mtxGridView2.DataObject = l;
                mtxGridView3.ObjectInfoText = "V";
                mtxGridView3.DataObject = q;
            }
			button3.Enabled = true;
		}

		private void button2_Click(object sender, System.EventArgs e) {
			tmpM1.Size(l.Cols, q.Cols, s.Complex);
			tmpM1.SetZero();
			tmpM1.Diag(s,0);
			MtxVecEdit.ViewValues(tmpM1, "Singular values",true,false,false);
		}

		private void button3_Click(object sender, System.EventArgs e) {
			if (radioButton1.Checked) {
				tmpM2.Mul(l,q);
				MtxVecEdit.ViewValues(tmpM2,"LQ = A ?",true,false,false);
			} else if (radioButton2.Checked) {
				tmpM2.Mul(q,r);
				MtxVecEdit.ViewValues(tmpM2,"QR = A ?",true,false,false);
			} else if (radioButton3.Checked || radioButton4.Checked) {
				// Q.Cols because we are multiplying with V" 
				// First, calculate S  
				tmpM1.Size(l.Cols,q.Cols, s.Complex);
				tmpM1.SetZero();
				tmpM1.Diag(s,0);
				// Multiply S by V"=Q"
				tmpM2.Mul(tmpM1,q,TMtxOperation.opNone,TMtxOperation.opTran);
				// Multiply from left by U=L
				tmpM3.Mul(l, tmpM2);
				MtxVecEdit.ViewValues(tmpM3,"U*S*V' = A ?",true,false,false);
			}
		}

		private void LQRDemoForm_Load(object sender, System.EventArgs e) {
			Add("MtxVec offers several methods for matrix decomposition. "
				+ "If matrix is squared, then LU decomposition can be used. "
				+ "If this is not the case (number of rows <> number of columns) "
				+ "then either LQ,QR, or SVD decomposition method can be used. "
				+ "All these methods are used extensively for solving system of "
				+ "linear equations (LUSolve, LQRSolve, SVDSolve). In this example "
				+ "the following decompositions are demonstrated.");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("LQ decomposition : Mtx.Rows < Mtx.Cols;  Mtx = L*Q; Mtx must have full rank");
			Add("QR decomposition : Mtx.Rows > Mtx.Cols; Mtx = Q*R; Mtx must have full rank");
			Add("SVD decomposition : Mtx = U*S*V'; Mtx does not have full rank");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

			Add("");
			Add("The \"Economy size\" checkbox indicates economy size matrices will be calculated. "
				+ "For more on this check the help file.");
		
		}
	}
}

