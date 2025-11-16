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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            trackBar1 = new TrackBar();
            label1 = new Label();
            labelDim = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            mtxGridView2 = new Dew.Math.Controls.MtxGridView();
            mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((ISupportInitialize)trackBar1).BeginInit();
            panel4.SuspendLayout();
            ((ISupportInitialize)mtxGridView2).BeginInit();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(labelDim);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(trackBar1);
            panel2.Size = new Size(997, 451);
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(0, 589);
            panel3.Size = new Size(997, 59);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(997, 138);
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(10, 59);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(201, 45);
            trackBar1.TabIndex = 0;
            trackBar1.TickFrequency = 4;
            trackBar1.TickStyle = TickStyle.TopLeft;
            trackBar1.Value = 4;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 39);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 1;
            label1.Text = "Matrix dimension (rows/cols) :";
            // 
            // labelDim
            // 
            labelDim.AutoSize = true;
            labelDim.Location = new Point(192, 39);
            labelDim.Name = "labelDim";
            labelDim.Size = new Size(13, 15);
            labelDim.TabIndex = 2;
            labelDim.Text = "0";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(19, 20);
            button1.Name = "button1";
            button1.Size = new Size(173, 29);
            button1.TabIndex = 0;
            button1.Text = "Generate random matrix";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(221, 20);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 1;
            button2.Text = "Inverse of matrix";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(355, 20);
            button3.Name = "button3";
            button3.Size = new Size(96, 29);
            button3.TabIndex = 2;
            button3.Text = "A*A-1=?";
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(mtxGridView2);
            panel4.Controls.Add(mtxGridView1);
            panel4.Location = new Point(221, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(776, 455);
            panel4.TabIndex = 3;
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
            mtxGridView2.Location = new Point(0, 185);
            mtxGridView2.MultiSelect = false;
            mtxGridView2.Name = "mtxGridView2";
            mtxGridView2.numberFormat = "0.0000";
            mtxGridView2.ObjectInfoText = "";
            mtxGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView2.ShowObjectInfo = true;
            mtxGridView2.Size = new Size(776, 270);
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
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(776, 185);
            mtxGridView1.TabIndex = 0;
            mtxGridView1.VirtualMode = true;
            // 
            // InverseMtxForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(997, 648);
            Name = "InverseMtxForm";
            Load += InverseMtxForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((ISupportInitialize)trackBar1).EndInit();
            panel4.ResumeLayout(false);
            ((ISupportInitialize)mtxGridView2).EndInit();
            ((ISupportInitialize)mtxGridView1).EndInit();
            ResumeLayout(false);

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

