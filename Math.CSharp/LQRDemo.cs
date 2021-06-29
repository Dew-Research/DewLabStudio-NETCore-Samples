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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView3 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(797, 381);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 551);
            this.panel3.Size = new System.Drawing.Size(797, 59);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(797, 170);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Examples";
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(10, 79);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(153, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "SVD (Rows > Cols)";
            this.radioButton4.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(10, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(163, 20);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "SVD (Rows < Cols)";
            this.radioButton3.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(10, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(163, 20);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "QR (Rows > Cols)";
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "LQ (Rows < Cols)";
            this.radioButton1.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(10, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 20);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "\"Economy\" size";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(10, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Perform decomposition";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(192, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Singular values";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(317, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "QR = A?";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mtxGridView1
            // 
            this.mtxGridView1.AllowUserToAddRows = false;
            this.mtxGridView1.AllowUserToDeleteRows = false;
            this.mtxGridView1.AllowUserToResizeColumns = false;
            this.mtxGridView1.AllowUserToResizeRows = false;
            this.mtxGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mtxGridView1.Location = new System.Drawing.Point(265, 10);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.ObjectInfoText = "A";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(487, 184);
            this.mtxGridView1.TabIndex = 4;
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
            this.mtxGridView2.Location = new System.Drawing.Point(10, 202);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.ObjectInfoText = "";
            this.mtxGridView2.ReadOnly = true;
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.ShowObjectInfo = true;
            this.mtxGridView2.Size = new System.Drawing.Size(372, 184);
            this.mtxGridView2.TabIndex = 5;
            this.mtxGridView2.VirtualMode = true;
            // 
            // mtxGridView3
            // 
            this.mtxGridView3.AllowUserToAddRows = false;
            this.mtxGridView3.AllowUserToDeleteRows = false;
            this.mtxGridView3.AllowUserToResizeColumns = false;
            this.mtxGridView3.AllowUserToResizeRows = false;
            this.mtxGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.mtxGridView3.Location = new System.Drawing.Point(406, 202);
            this.mtxGridView3.MultiSelect = false;
            this.mtxGridView3.Name = "mtxGridView3";
            this.mtxGridView3.ObjectInfoText = "";
            this.mtxGridView3.ReadOnly = true;
            this.mtxGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView3.ShowObjectInfo = true;
            this.mtxGridView3.Size = new System.Drawing.Size(346, 184);
            this.mtxGridView3.TabIndex = 6;
            this.mtxGridView3.VirtualMode = true;
            // 
            // LQRDemoForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(797, 610);
            this.Name = "LQRDemoForm";
            this.Load += new System.EventHandler(this.LQRDemoForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView3)).EndInit();
            this.ResumeLayout(false);

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

