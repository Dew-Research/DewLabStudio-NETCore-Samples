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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSci = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mtxGridView1 = new Dew.Math.Controls.MtxGridView();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtxGridView1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Size = new System.Drawing.Size(687, 372);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 484);
            this.panel3.Size = new System.Drawing.Size(687, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(687, 112);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.checkBox4);
            this.panel4.Controls.Add(this.checkBox3);
            this.panel4.Controls.Add(this.checkBox2);
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 372);
            this.panel4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFormat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxSci);
            this.groupBox1.Location = new System.Drawing.Point(12, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cell format";
            // 
            // textBoxFormat
            // 
            this.textBoxFormat.Location = new System.Drawing.Point(6, 86);
            this.textBoxFormat.Name = "textBoxFormat";
            this.textBoxFormat.Size = new System.Drawing.Size(100, 20);
            this.textBoxFormat.TabIndex = 2;
            this.textBoxFormat.TextChanged += new System.EventHandler(this.textBoxFormat_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Format";
            // 
            // checkBoxSci
            // 
            this.checkBoxSci.AutoSize = true;
            this.checkBoxSci.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxSci.Location = new System.Drawing.Point(6, 30);
            this.checkBoxSci.Name = "checkBoxSci";
            this.checkBoxSci.Size = new System.Drawing.Size(107, 18);
            this.checkBoxSci.TabIndex = 0;
            this.checkBoxSci.Text = "Scientific format";
            this.checkBoxSci.UseVisualStyleBackColor = true;
            this.checkBoxSci.CheckedChanged += new System.EventHandler(this.checkBoxSci_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Location = new System.Drawing.Point(12, 87);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 18);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Cplx as sigle column";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Location = new System.Drawing.Point(12, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Object info";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(12, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show indexes";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(12, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Read only";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtxGridView1.Location = new System.Drawing.Point(153, 0);
            this.mtxGridView1.MultiSelect = false;
            this.mtxGridView1.Name = "mtxGridView1";
            this.mtxGridView1.numberFormat = "0.0000";
            this.mtxGridView1.ObjectInfoText = "";
            this.mtxGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridView1.ShowObjectInfo = true;
            this.mtxGridView1.Size = new System.Drawing.Size(534, 372);
            this.mtxGridView1.TabIndex = 1;
            this.mtxGridView1.VirtualMode = true;
            // 
            // MtxGridViewDemo
            // 
            this.ClientSize = new System.Drawing.Size(687, 532);
            this.Name = "MtxGridViewDemo";
            this.Load += new System.EventHandler(this.MtxGridViewDemo_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridView1)).EndInit();
            this.ResumeLayout(false);

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

