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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButtonvfShur = new RadioButton();
            radioButtonvfEig = new RadioButton();
            groupBox2 = new GroupBox();
            radioButtonbtFull = new RadioButton();
            radioButtonbtPerm = new RadioButton();
            radioButtonbtScale = new RadioButton();
            radioButtonbtNone = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            radioButtonLeft = new RadioButton();
            radioButtonRight = new RadioButton();
            button1 = new Button();
            mtxGridView1 = new MtxGridView();
            mtxGridView2 = new MtxGridView();
            mtxGridView3 = new MtxGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            panel2.Controls.Add(radioButtonRight);
            panel2.Controls.Add(radioButtonLeft);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(label1);
            panel2.Size = new Size(878, 489);
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 627);
            panel3.Size = new Size(878, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(878, 138);
            // 
            // label1
            // 
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Matrix A :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonvfShur);
            groupBox1.Controls.Add(radioButtonvfEig);
            groupBox1.Location = new Point(403, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(106, 68);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vector Form";
            // 
            // radioButtonvfShur
            // 
            radioButtonvfShur.FlatStyle = FlatStyle.System;
            radioButtonvfShur.Location = new Point(10, 39);
            radioButtonvfShur.Name = "radioButtonvfShur";
            radioButtonvfShur.Size = new Size(67, 20);
            radioButtonvfShur.TabIndex = 1;
            radioButtonvfShur.Text = "vfShur";
            radioButtonvfShur.Click += radioButtonForm_clicked;
            // 
            // radioButtonvfEig
            // 
            radioButtonvfEig.Checked = true;
            radioButtonvfEig.FlatStyle = FlatStyle.System;
            radioButtonvfEig.Location = new Point(10, 20);
            radioButtonvfEig.Name = "radioButtonvfEig";
            radioButtonvfEig.Size = new Size(67, 19);
            radioButtonvfEig.TabIndex = 0;
            radioButtonvfEig.TabStop = true;
            radioButtonvfEig.Text = "vfEig";
            radioButtonvfEig.Click += radioButtonForm_clicked;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButtonbtFull);
            groupBox2.Controls.Add(radioButtonbtPerm);
            groupBox2.Controls.Add(radioButtonbtScale);
            groupBox2.Controls.Add(radioButtonbtNone);
            groupBox2.Location = new Point(518, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(183, 68);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Balance";
            // 
            // radioButtonbtFull
            // 
            radioButtonbtFull.Checked = true;
            radioButtonbtFull.FlatStyle = FlatStyle.System;
            radioButtonbtFull.Location = new Point(96, 39);
            radioButtonbtFull.Name = "radioButtonbtFull";
            radioButtonbtFull.Size = new Size(77, 20);
            radioButtonbtFull.TabIndex = 3;
            radioButtonbtFull.TabStop = true;
            radioButtonbtFull.Text = "btFull";
            radioButtonbtFull.Click += radioButtonBalance_clicked;
            // 
            // radioButtonbtPerm
            // 
            radioButtonbtPerm.FlatStyle = FlatStyle.System;
            radioButtonbtPerm.Location = new Point(96, 20);
            radioButtonbtPerm.Name = "radioButtonbtPerm";
            radioButtonbtPerm.Size = new Size(77, 19);
            radioButtonbtPerm.TabIndex = 2;
            radioButtonbtPerm.Text = "btPerm";
            radioButtonbtPerm.Click += radioButtonBalance_clicked;
            // 
            // radioButtonbtScale
            // 
            radioButtonbtScale.FlatStyle = FlatStyle.System;
            radioButtonbtScale.Location = new Point(10, 39);
            radioButtonbtScale.Name = "radioButtonbtScale";
            radioButtonbtScale.Size = new Size(76, 20);
            radioButtonbtScale.TabIndex = 1;
            radioButtonbtScale.Text = "btScale";
            radioButtonbtScale.Click += radioButtonBalance_clicked;
            // 
            // radioButtonbtNone
            // 
            radioButtonbtNone.FlatStyle = FlatStyle.System;
            radioButtonbtNone.Location = new Point(10, 20);
            radioButtonbtNone.Name = "radioButtonbtNone";
            radioButtonbtNone.Size = new Size(76, 19);
            radioButtonbtNone.TabIndex = 0;
            radioButtonbtNone.Text = "btNone";
            radioButtonbtNone.Click += radioButtonBalance_clicked;
            // 
            // label2
            // 
            label2.Location = new Point(10, 217);
            label2.Name = "label2";
            label2.Size = new Size(249, 19);
            label2.TabIndex = 4;
            label2.Text = "Eigenvalues are elements of vector D :";
            // 
            // label3
            // 
            label3.Location = new Point(384, 217);
            label3.Name = "label3";
            label3.Size = new Size(120, 19);
            label3.TabIndex = 6;
            label3.Text = "Eigenvectors";
            // 
            // radioButtonLeft
            // 
            radioButtonLeft.FlatStyle = FlatStyle.System;
            radioButtonLeft.Location = new Point(509, 217);
            radioButtonLeft.Name = "radioButtonLeft";
            radioButtonLeft.Size = new Size(57, 19);
            radioButtonLeft.TabIndex = 7;
            radioButtonLeft.Text = "Left";
            radioButtonLeft.Click += radioButtonEigenVectors_click;
            // 
            // radioButtonRight
            // 
            radioButtonRight.Checked = true;
            radioButtonRight.FlatStyle = FlatStyle.System;
            radioButtonRight.Location = new Point(566, 217);
            radioButtonRight.Name = "radioButtonRight";
            radioButtonRight.Size = new Size(68, 19);
            radioButtonRight.TabIndex = 8;
            radioButtonRight.TabStop = true;
            radioButtonRight.Text = "Right";
            radioButtonRight.Click += radioButtonEigenVectors_click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(19, 10);
            button1.Name = "button1";
            button1.Size = new Size(135, 29);
            button1.TabIndex = 0;
            button1.Text = "Calc eigenvalues";
            button1.Click += button1_Click;
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
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            mtxGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            mtxGridView1.Location = new Point(13, 28);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "";
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.Size = new Size(333, 185);
            mtxGridView1.TabIndex = 10;
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
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            mtxGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            mtxGridView2.Location = new Point(13, 249);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "";
            mtxGridView2.ReadOnly = true;
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.Size = new Size(173, 184);
            mtxGridView2.TabIndex = 11;
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
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridView3.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridView3.Location = new Point(388, 249);
            mtxGridView3.MultiSelect = false;
            mtxGridView3.Name = "mtxGridView3";
            mtxGridView3.numberFormat = "0.0000";
            mtxGridView3.ObjectInfoText = "";
            mtxGridView3.ReadOnly = true;
            mtxGridView3.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView3.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView3.Size = new Size(313, 184);
            mtxGridView3.TabIndex = 12;
            mtxGridView3.VirtualMode = true;
            // 
            // EigenVectors1Form
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(878, 686);
            Name = "EigenVectors1Form";
            Load += EigenVectors1Form_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView1).EndInit();
            ((ISupportInitialize)mtxGridView2).EndInit();
            ((ISupportInitialize)mtxGridView3).EndInit();
            ResumeLayout(false);
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

