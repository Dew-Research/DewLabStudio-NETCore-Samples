using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;

namespace MtxVecDemo
{
    public class MtxGridViewDemo : MtxVecDemo.BasicForm2
    {
        private Panel panel4;
        private Dew.Math.Controls.MtxGridView mtxGridView1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private GroupBox groupBox1;
        private CheckBox checkBoxSci;
        private TextBox textBoxFormat;
        private Label label1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            textBoxFormat = new TextBox();
            label1 = new Label();
            checkBoxSci = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)mtxGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(mtxGridView1);
            panel2.Controls.Add(panel4);
            panel2.Size = new Size(763, 377);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 515);
            panel3.Size = new Size(763, 48);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(763, 138);
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(checkBox4);
            panel4.Controls.Add(checkBox3);
            panel4.Controls.Add(checkBox2);
            panel4.Controls.Add(checkBox1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 377);
            panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFormat);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(checkBoxSci);
            groupBox1.Location = new Point(12, 131);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(127, 112);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cell format";
            // 
            // textBoxFormat
            // 
            textBoxFormat.Location = new Point(6, 86);
            textBoxFormat.Name = "textBoxFormat";
            textBoxFormat.Size = new Size(100, 23);
            textBoxFormat.TabIndex = 2;
            textBoxFormat.TextChanged += textBoxFormat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 70);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Format";
            // 
            // checkBoxSci
            // 
            checkBoxSci.AutoSize = true;
            checkBoxSci.FlatStyle = FlatStyle.System;
            checkBoxSci.Location = new Point(6, 30);
            checkBoxSci.Name = "checkBoxSci";
            checkBoxSci.Size = new Size(119, 20);
            checkBoxSci.TabIndex = 0;
            checkBoxSci.Text = "Scientific format";
            checkBoxSci.UseVisualStyleBackColor = true;
            checkBoxSci.CheckedChanged += checkBoxSci_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatStyle = FlatStyle.System;
            checkBox4.Location = new Point(12, 87);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(141, 20);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Cplx as sigle column";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.FlatStyle = FlatStyle.System;
            checkBox3.Location = new Point(12, 63);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(91, 20);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Object info";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.FlatStyle = FlatStyle.System;
            checkBox2.Location = new Point(12, 39);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(104, 20);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Show indexes";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(12, 15);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(84, 20);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Read only";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridView1.Dock = DockStyle.Fill;
            mtxGridView1.Location = new Point(153, 0);
            mtxGridView1.MultiSelect = false;
            mtxGridView1.Name = "mtxGridView1";
            mtxGridView1.numberFormat = "0.0000";
            mtxGridView1.ObjectInfoText = "";
            mtxGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridView1.ShowObjectInfo = true;
            mtxGridView1.Size = new Size(610, 377);
            mtxGridView1.TabIndex = 1;
            mtxGridView1.VirtualMode = true;
            // 
            // MtxGridViewDemo
            // 
            ClientSize = new Size(763, 563);
            Name = "MtxGridViewDemo";
            Load += MtxGridViewDemo_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)mtxGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Matrix m;
        private bool formloading = true;

        public MtxGridViewDemo()
        {
            InitializeComponent();
            // create complex matrix
            m = new Matrix(20, 5, true);
            m.RandGauss();

            // connect it to MtxGridView
            mtxGridView1.DataObject = m;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mtxGridView1.ReadOnly = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mtxGridView1.ShowRowColIndexes = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            mtxGridView1.ShowObjectInfo = checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            mtxGridView1.SplitCplx = !checkBox4.Checked;
        }

        private void MtxGridViewDemo_Load(object sender, EventArgs e)
        {
            Add("MtxGridView control allows you easy viewing/editing of real or complex matrices or "
            + "vectors. The control is derived from DataGridView and inherits all it's "
            + "properties/methods and introduces some full support for complex numbers.\n\nWith just few "
            + "lines of code you can easily change matrix or vector values.");

            textBoxFormat.Text = mtxGridView1.DefaultCellStyle.Format;
            formloading = false;
        }

        private void checkBoxSci_CheckedChanged(object sender, EventArgs e)
        {
            if (!formloading)
            {
                textBoxFormat.Visible = !checkBoxSci.Checked;
                label1.Visible = !checkBoxSci.Checked;
                if (checkBoxSci.Checked) mtxGridView1.DefaultCellStyle.Format = "";
                else mtxGridView1.DefaultCellStyle.Format = textBoxFormat.Text;
            }
        }

        private void textBoxFormat_TextChanged(object sender, EventArgs e)
        {
            if (!formloading)
                mtxGridView1.DefaultCellStyle.Format = textBoxFormat.Text;
        }
    }
}

