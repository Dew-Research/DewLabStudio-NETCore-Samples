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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            labelStreamSize = new Label();
            panel5 = new Panel();
            mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((ISupportInitialize)mtxGridView2).BeginInit();
            panel5.SuspendLayout();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label1);
            panel2.Size = new Size(1018, 397);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 535);
            panel3.Size = new Size(1018, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1018, 138);
            // 
            // label1
            // 
            label1.Location = new Point(19, 10);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Precision";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Items.AddRange(new object[] { "prDouble", "prSingle", "prInteger", "prCardinal", "prSmallInt", "prWord", "prShortInt", "prByte" });
            comboBox1.Location = new Point(19, 30);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(19, 69);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Rounding type";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Items.AddRange(new object[] { "rnTrunc", "rnRound" });
            comboBox2.Location = new Point(19, 89);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 23);
            comboBox2.TabIndex = 3;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(38, 138);
            button1.Name = "button1";
            button1.Size = new Size(90, 28);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(836, 20);
            label3.TabIndex = 5;
            label3.Text = "Original matrix (20x20)";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(836, 20);
            label4.TabIndex = 7;
            label4.Text = "Saved matrix (20x20)";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(173, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(836, 381);
            panel4.TabIndex = 8;
            panel4.Resize += panel4_Resize;
            // 
            // panel6
            // 
            panel6.Controls.Add(mtxGridView2);
            panel6.Controls.Add(labelStreamSize);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 167);
            panel6.Name = "panel6";
            panel6.Size = new Size(836, 214);
            panel6.TabIndex = 1;
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
            mtxGridView2.Location = new Point(0, 20);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "";
            mtxGridView2.ReadOnly = true;
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.Size = new Size(836, 194);
            mtxGridView2.TabIndex = 10;
            mtxGridView2.VirtualMode = true;
            // 
            // labelStreamSize
            // 
            labelStreamSize.Location = new Point(154, 0);
            labelStreamSize.Name = "labelStreamSize";
            labelStreamSize.Size = new Size(230, 20);
            labelStreamSize.TabIndex = 9;
            labelStreamSize.Text = "0 bytes";
            // 
            // panel5
            // 
            panel5.Controls.Add(mtxGridView1);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(836, 167);
            panel5.TabIndex = 0;
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
            mtxGridView1.Dock = DockStyle.Fill;
            mtxGridView1.Location = new Point(0, 20);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "";
            mtxGridView1.ReadOnly = true;
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.Size = new Size(836, 147);
            mtxGridView1.TabIndex = 6;
            mtxGridView1.VirtualMode = true;
            // 
            // PrecisionForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(1018, 594);
            Name = "PrecisionForm";
            Load += PrecisionForm_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView2).EndInit();
            panel5.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView1).EndInit();
            ResumeLayout(false);

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

