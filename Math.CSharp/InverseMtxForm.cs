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
	public class InverseMtxForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelDim;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private Dew.Math.Controls.MtxGridView mtxGridView2;
        private Dew.Math.Controls.MtxGridView mtxGridView1;
		private System.ComponentModel.IContainer components = null;

		public InverseMtxForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            a = new Matrix(0, 0);
            b = new Matrix(0, 0);
            c = new Matrix(0, 0);

            mtxGridView1.DataObject = a;
            mtxGridView2.DataObject = b;

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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDim = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.labelDim);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Size = new System.Drawing.Size(907, 425);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Size = new System.Drawing.Size(907, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(907, 112);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 48);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(168, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 4;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Value = 4;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrix dimension (rows/cols) :";
            // 
            // labelDim
            // 
            this.labelDim.AutoSize = true;
            this.labelDim.Location = new System.Drawing.Point(160, 32);
            this.labelDim.Name = "labelDim";
            this.labelDim.Size = new System.Drawing.Size(13, 13);
            this.labelDim.TabIndex = 2;
            this.labelDim.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate random matrix";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(184, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Inverse of matrix";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(296, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "A*A-1=?";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.mtxGridView2);
            this.panel4.Controls.Add(this.mtxGridView1);
            this.panel4.Location = new System.Drawing.Point(184, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(723, 428);
            this.panel4.TabIndex = 3;
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxGridView2.Location = new System.Drawing.Point(0, 150);
            this.mtxGridView2.MultiSelect = false;
            this.mtxGridView2.Name = "mtxGridView2";
            this.mtxGridView2.numberFormat = "0.0000";
            this.mtxGridView2.ObjectInfoText = "";
            this.mtxGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView2.ShowObjectInfo = true;
            this.mtxGridView2.Size = new System.Drawing.Size(723, 278);
            this.mtxGridView2.TabIndex = 1;
            this.mtxGridView2.VirtualMode = true;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mtxGridView1.Location = new System.Drawing.Point(0, 0);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.numberFormat = "0.0000";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(723, 150);
            this.mtxGridView1.TabIndex = 0;
            this.mtxGridView1.VirtualMode = true;
            // 
            // InverseMtxForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(907, 585);
            this.Name = "InverseMtxForm";
            this.Load += new System.EventHandler(this.InverseMtxForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private int dim;
		private Matrix a,b,c;

		private void panel4_Resize(object sender, System.EventArgs e) 
        {
            mtxGridView1.Height = panel4.Height / 2;
		}

		private void trackBar1_ValueChanged(object sender, System.EventArgs e) {
		  dim = (sender as TrackBar).Value;
			labelDim.Text = dim.ToString();
			button2.Enabled = false;
			button3.Enabled = false;
		}

		private void InverseMtxForm_Load(object sender, System.EventArgs e) {

			Add("Calculating the inverse matrix is a peace of "
				+ "cake. It can be done with just one function call :");
			Add("");
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", richTextBox1.SelectionFont.Size);
			Add("a.Inv();");
			Add("");
			Add("The Inv method optionally accepts the matrix type "
				+ "parameter. Depending of matrix type (symmetric, "
				+ "triangular, etc..)  optimized methods will be used "
				+ "to calculate the inverse matrix.");


			trackBar1_ValueChanged(trackBar1,null);
			button1_Click(null,null);
		}

		private void button1_Click(object sender, System.EventArgs e) {
			// generate random matrix
			a.Size(dim,dim,false);
			a.RandUniform(-5,5);
            mtxGridView1.UpdateGrid();

            button2.Enabled = true;
			button3.Enabled = false;
		}

		private void button2_Click(object sender, System.EventArgs e) {
			// inverse matrix
            b.Copy(a);
			b.AutoMtxType = true;
			b.Inv();
            mtxGridView2.UpdateGrid();

            button3.Enabled = true;
		}

		private void button3_Click(object sender, System.EventArgs e) {
			// A*A-1=?
			c.Mul(a,b);
            MtxVecEdit.ViewValues(c,"A*A-1=?",true,false,false);
		}


	}
}

