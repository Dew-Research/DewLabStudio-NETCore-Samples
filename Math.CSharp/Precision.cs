using System;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
	public class PrecisionForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label labelStreamSize;
        private Dew.Math.Controls.MtxGridView mtxGridView2;
        private Dew.Math.Controls.MtxGridView mtxGridView1;
		private System.ComponentModel.IContainer components = null;

		public PrecisionForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			comboBox1.SelectedIndex = 0;
			comboBox2.SelectedIndex = 0;
            m1 = new Matrix(20, 20);
            m2 = new Matrix(0, 0);
            mtxGridView1.DataObject = m1;
            mtxGridView2.DataObject = m2;
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.labelStreamSize = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(867, 460);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 630);
            this.panel3.Size = new System.Drawing.Size(867, 73);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(867, 170);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precision";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Items.AddRange(new object[] {
            "prDouble",
            "prSingle",
            "prInteger",
            "prCardinal",
            "prSmallInt",
            "prWord",
            "prShortInt",
            "prByte"});
            this.comboBox1.Location = new System.Drawing.Point(19, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rounding type";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Items.AddRange(new object[] {
            "rnTrunc",
            "rnRound"});
            this.comboBox2.Location = new System.Drawing.Point(19, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(38, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(651, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Original matrix (20x20)";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(651, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saved matrix (20x20)";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(204, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 442);
            this.panel4.TabIndex = 8;
            this.panel4.Resize += new System.EventHandler(this.panel4_Resize);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.mtxGridView2);
            this.panel6.Controls.Add(this.labelStreamSize);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 167);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(651, 275);
            this.panel6.TabIndex = 1;
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
            this.mtxGridView2.Location = new System.Drawing.Point(0, 20);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.ObjectInfoText = "";
            this.mtxGridView2.ReadOnly = true;
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.Size = new System.Drawing.Size(651, 255);
            this.mtxGridView2.TabIndex = 10;
            this.mtxGridView2.VirtualMode = true;
            // 
            // labelStreamSize
            // 
            this.labelStreamSize.Location = new System.Drawing.Point(154, 0);
            this.labelStreamSize.Name = "labelStreamSize";
            this.labelStreamSize.Size = new System.Drawing.Size(230, 20);
            this.labelStreamSize.TabIndex = 9;
            this.labelStreamSize.Text = "0 bytes";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mtxGridView1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(651, 167);
            this.panel5.TabIndex = 0;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxGridView1.Location = new System.Drawing.Point(0, 20);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.ReadOnly = true;
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.Size = new System.Drawing.Size(651, 147);
            this.mtxGridView1.TabIndex = 6;
            this.mtxGridView1.VirtualMode = true;
            // 
            // PrecisionForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(867, 703);
            this.Name = "PrecisionForm";
            this.Load += new System.EventHandler(this.PrecisionForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private Matrix m1, m2;
		private TPrecision precision;
		private TRounding rounding;
		private void panel4_Resize(object sender, System.EventArgs e) {
			panel5.Height = panel4.Height / 2;
		}

		private void PrecisionForm_Load(object sender, System.EventArgs e) {
			Add("SaveToStream allows you to specify the precision "
				+ "and rounding method. This enables you to minimize "
				+ "the storage space required for your data and at "
				+ "the same time gives you the ability to process "
				+ "data written in any number format.");
			m1.RandGauss(5,0.5);
            mtxGridView1.UpdateGrid();
		}

		private void button1_Click(object sender, System.EventArgs e) {
			MemoryStream stream = new MemoryStream();
			try {
				m1.Precision = precision;
				m1.Rounding = rounding;
				m1.SaveToStream((Stream) stream);
				labelStreamSize.Text = "MemoryStream size : " + stream.Length + " bytes";
				stream.Seek(0,SeekOrigin.Begin);
				m2.LoadFromStream((Stream) stream);
                mtxGridView2.UpdateGrid();
			} finally {
				stream.Close();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (comboBox1.SelectedIndex) {
				case 0 : precision = TPrecision.prDouble; break;
				case 1 : precision = TPrecision.prSingle; break;
				case 2 : precision = TPrecision.prInteger; break;
				case 3 : precision = TPrecision.prCardinal; break;
				case 4 : precision = TPrecision.prSmallInt; break;
				case 5 : precision = TPrecision.prWord; break;
				case 6 : precision = TPrecision.prShortInt; break;
				case 7 : precision = TPrecision.prByte; break;
			}

		}

		private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e) {
			switch (comboBox2.SelectedIndex) {
				case 0 : rounding = TRounding.rnTrunc; break;
				case 1 : rounding = TRounding.rnRound; break;
			}
		}
	}
}

