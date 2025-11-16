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
	public class EigenVectors1Form : MtxVecDemo.BasicForm2
	{
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonvfEig;
		private System.Windows.Forms.RadioButton radioButtonvfShur;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton radioButtonbtFull;
		private System.Windows.Forms.RadioButton radioButtonbtPerm;
		private System.Windows.Forms.RadioButton radioButtonbtScale;
		private System.Windows.Forms.RadioButton radioButtonbtNone;
		private System.Windows.Forms.RadioButton radioButtonLeft;
		private System.Windows.Forms.RadioButton radioButtonRight;
		private System.Windows.Forms.Button button1;
        private MtxGridView mtxGridView3;
        private MtxGridView mtxGridView2;
        private MtxGridView mtxGridView1;
		private System.ComponentModel.IContainer components = null;

		public EigenVectors1Form()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            a = new Matrix(0, 0);
            eigL = new Matrix(0, 0);
            eigR = new Matrix(0, 0);
            diagMtx = new Matrix(0, 0);
            eigValues = new Vector(0);

            mtxGridView1.DataObject = a;
            mtxGridView2.DataObject = eigValues;

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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonvfShur = new System.Windows.Forms.RadioButton();
            this.radioButtonvfEig = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonbtFull = new System.Windows.Forms.RadioButton();
            this.radioButtonbtPerm = new System.Windows.Forms.RadioButton();
            this.radioButtonbtScale = new System.Windows.Forms.RadioButton();
            this.radioButtonbtNone = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonLeft = new System.Windows.Forms.RadioButton();
            this.radioButtonRight = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView3 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel2.Controls.Add(this.radioButtonRight);
            this.panel2.Controls.Add(this.radioButtonLeft);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(813, 417);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 529);
            this.panel3.Size = new System.Drawing.Size(813, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(813, 112);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrix A :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonvfShur);
            this.groupBox1.Controls.Add(this.radioButtonvfEig);
            this.groupBox1.Location = new System.Drawing.Point(336, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vector Form";
            // 
            // radioButtonvfShur
            // 
            this.radioButtonvfShur.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonvfShur.Location = new System.Drawing.Point(8, 32);
            this.radioButtonvfShur.Name = "radioButtonvfShur";
            this.radioButtonvfShur.Size = new System.Drawing.Size(56, 16);
            this.radioButtonvfShur.TabIndex = 1;
            this.radioButtonvfShur.Text = "vfShur";
            this.radioButtonvfShur.Click += new System.EventHandler(this.radioButtonForm_clicked);
            // 
            // radioButtonvfEig
            // 
            this.radioButtonvfEig.Checked = true;
            this.radioButtonvfEig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonvfEig.Location = new System.Drawing.Point(8, 16);
            this.radioButtonvfEig.Name = "radioButtonvfEig";
            this.radioButtonvfEig.Size = new System.Drawing.Size(56, 16);
            this.radioButtonvfEig.TabIndex = 0;
            this.radioButtonvfEig.TabStop = true;
            this.radioButtonvfEig.Text = "vfEig";
            this.radioButtonvfEig.Click += new System.EventHandler(this.radioButtonForm_clicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonbtFull);
            this.groupBox2.Controls.Add(this.radioButtonbtPerm);
            this.groupBox2.Controls.Add(this.radioButtonbtScale);
            this.groupBox2.Controls.Add(this.radioButtonbtNone);
            this.groupBox2.Location = new System.Drawing.Point(432, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance";
            // 
            // radioButtonbtFull
            // 
            this.radioButtonbtFull.Checked = true;
            this.radioButtonbtFull.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonbtFull.Location = new System.Drawing.Point(80, 32);
            this.radioButtonbtFull.Name = "radioButtonbtFull";
            this.radioButtonbtFull.Size = new System.Drawing.Size(64, 16);
            this.radioButtonbtFull.TabIndex = 3;
            this.radioButtonbtFull.TabStop = true;
            this.radioButtonbtFull.Text = "btFull";
            this.radioButtonbtFull.Click += new System.EventHandler(this.radioButtonBalance_clicked);
            // 
            // radioButtonbtPerm
            // 
            this.radioButtonbtPerm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonbtPerm.Location = new System.Drawing.Point(80, 16);
            this.radioButtonbtPerm.Name = "radioButtonbtPerm";
            this.radioButtonbtPerm.Size = new System.Drawing.Size(64, 16);
            this.radioButtonbtPerm.TabIndex = 2;
            this.radioButtonbtPerm.Text = "btPerm";
            this.radioButtonbtPerm.Click += new System.EventHandler(this.radioButtonBalance_clicked);
            // 
            // radioButtonbtScale
            // 
            this.radioButtonbtScale.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonbtScale.Location = new System.Drawing.Point(8, 32);
            this.radioButtonbtScale.Name = "radioButtonbtScale";
            this.radioButtonbtScale.Size = new System.Drawing.Size(64, 16);
            this.radioButtonbtScale.TabIndex = 1;
            this.radioButtonbtScale.Text = "btScale";
            this.radioButtonbtScale.Click += new System.EventHandler(this.radioButtonBalance_clicked);
            // 
            // radioButtonbtNone
            // 
            this.radioButtonbtNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonbtNone.Location = new System.Drawing.Point(8, 16);
            this.radioButtonbtNone.Name = "radioButtonbtNone";
            this.radioButtonbtNone.Size = new System.Drawing.Size(64, 16);
            this.radioButtonbtNone.TabIndex = 0;
            this.radioButtonbtNone.Text = "btNone";
            this.radioButtonbtNone.Click += new System.EventHandler(this.radioButtonBalance_clicked);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eigenvalues are elements of vector D :";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(320, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eigenvectors";
            // 
            // radioButtonLeft
            // 
            this.radioButtonLeft.Checked = true;
            this.radioButtonLeft.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonLeft.Location = new System.Drawing.Point(424, 176);
            this.radioButtonLeft.Name = "radioButtonLeft";
            this.radioButtonLeft.Size = new System.Drawing.Size(48, 16);
            this.radioButtonLeft.TabIndex = 7;
            this.radioButtonLeft.TabStop = true;
            this.radioButtonLeft.Text = "Left";
            this.radioButtonLeft.Click += new System.EventHandler(this.radioButtonEigenVectors_click);
            // 
            // radioButtonRight
            // 
            this.radioButtonRight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonRight.Location = new System.Drawing.Point(472, 176);
            this.radioButtonRight.Name = "radioButtonRight";
            this.radioButtonRight.Size = new System.Drawing.Size(56, 16);
            this.radioButtonRight.TabIndex = 8;
            this.radioButtonRight.Text = "Right";
            this.radioButtonRight.Click += new System.EventHandler(this.radioButtonEigenVectors_click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc eigenvalues";
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.mtxGridView1.Location = new System.Drawing.Point(11, 23);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.numberFormat = "0.0000";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.Size = new System.Drawing.Size(277, 150);
            this.mtxGridView1.TabIndex = 10;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridView2.Location = new System.Drawing.Point(11, 202);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.numberFormat = "0.0000";
            this.mtxGridView2.ObjectInfoText = "";
            this.mtxGridView2.ReadOnly = true;
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.Size = new System.Drawing.Size(144, 150);
            this.mtxGridView2.TabIndex = 11;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView3.Location = new System.Drawing.Point(323, 202);
            this.mtxGridView3.MultiSelect = false;
            this.mtxGridView3.Name = "mtxGridView3";
            this.mtxGridView3.numberFormat = "0.0000";
            this.mtxGridView3.ObjectInfoText = "";
            this.mtxGridView3.ReadOnly = true;
            this.mtxGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView3.Size = new System.Drawing.Size(261, 150);
            this.mtxGridView3.TabIndex = 12;
            this.mtxGridView3.VirtualMode = true;
            // 
            // EigenVectors1Form
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(813, 577);
            this.Name = "EigenVectors1Form";
            this.Load += new System.EventHandler(this.EigenVectors1Form_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView3)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		private Matrix a, eigL, eigR, diagMtx;
		private Vector eigValues;
		private TVectorForm vecForm;
		private TBalanceType bal;

		private void EigenVectors1Form_Load(object sender, System.EventArgs e) {

			Add("The Eig method is a powerful tool. With it you can "
				+ "easily calculate eigenvalues and left/right eigenvectors.");
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
				richTextBox1.SelectionFont.Size, FontStyle.Bold);
			Add("VectorForm");
			Add("If \"Vector Form\" is vfEig, then full balance will "
				+ "be used to find eigenvalues eigenvectors (check help "
				+ "file for more on this topic). The computed eigenvectors "
				+ "are normalized to have Euclidean norm equal to 1 and "
				+ "largest component real and are stored in the rows of "
				+ "the VL and VR matrices. If \"Vector Form\" is vfSchur "
				+ "then  user defined balance will be used to find eigenvalues "
				+ "eigenvectors (check help file for more on this topic)");
			Add("");
			richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,
				richTextBox1.SelectionFont.Size, FontStyle.Bold);
			Add("Balance");
			Add("Balancing the matrix can be very useful when calculating the "
				+ "eigenvalues and eigenvector. Balancing operation can perform "
				+ "one or both of the following similarity transformations:");
			Add("1) Permutation, 2) Similarity transformation.");
			Add("");
			Add("Try changing A matrix values, \"Vector Form\"  and (optionally) "
				+"\"Balance\". The \"Left\" and \"Right\" radio buttons show left and right "
				+ "(check help for more info on this topic) eigenvectors.");

			a.SetIt(4,4,false, new double[]{1,-3,5,-3,
																			-1,12,0.3,2.5,
																			5,1.22,2.33,-0.5,
																			2.4,-1,5,3});
            mtxGridView1.UpdateGrid();

			radioButtonForm_clicked(null,null);
			radioButtonBalance_clicked(null, null);
		}

		private void radioButtonForm_clicked(object sender, System.EventArgs e) {
			if (radioButtonvfEig.Checked) {
				vecForm = TVectorForm.vfEig;
				groupBox2.Enabled = false;
				radioButtonbtFull.Checked = true;
			} else if (radioButtonvfShur.Checked) {
				vecForm = TVectorForm.vfSchur;
				groupBox2.Enabled = true;
			}
		}

		private void radioButtonBalance_clicked(object sender, System.EventArgs e) {
			if (radioButtonbtNone.Checked) bal = TBalanceType.btNone;
			else if (radioButtonbtFull.Checked) bal = TBalanceType.btFull;
			else if (radioButtonbtPerm.Checked) bal = TBalanceType.btPerm;
			else if (radioButtonbtScale.Checked) bal = TBalanceType.btScale;
		}

		private void button1_Click(object sender, System.EventArgs e) {
			TMtxType type = a.DetectMtxType(false);
			a.Balance = bal;
			a.Eig(eigL, eigValues, eigR, type, vecForm, true);
            mtxGridView2.UpdateGrid();
			radioButtonEigenVectors_click(null,null);
		}

		private void radioButtonEigenVectors_click(object sender, System.EventArgs e) {
            mtxGridView3.DataObject = (radioButtonLeft.Checked) ? eigL : eigR;
		}
	}
}

