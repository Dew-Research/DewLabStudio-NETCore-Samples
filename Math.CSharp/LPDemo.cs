using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Math;

namespace MtxVecDemo
{
    public class LPDemo : MtxVecDemo.BasicForm2
    {
        private TStringList log;
        private Label labelRelations;
        private TextBox textBoxRelations;
        private Button buttonSolve;
        private bool formloading = true;
        
        public LPDemo()
        {
            InitializeComponent();
            // By default, use log
            log = new TStringList();
            tMtxLP1.Verbose = log;

            mtxGridViewA.DataObject = tMtxLP1.A;
            mtxGridViewb.DataObject = tMtxLP1.b;
            mtxGridViewc.DataObject = tMtxLP1.c;
        }

        private Dew.Math.TMtxLP tMtxLP1;
        private SplitContainer splitContainer1;
        private CheckBox checkBoxMinimize;
        private ComboBox comboBoxAlgorithm;
        private Label label1;
        private CheckBox checkBoxLog;
        private RichTextBox richTextBoxLog;
        private Panel panelSystem;
        private Dew.Math.Controls.MtxGridView mtxGridViewA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Dew.Math.Controls.MtxGridView mtxGridViewb;
        private Dew.Math.Controls.MtxGridView mtxGridViewc;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDownEquations;
        private Label label5;
        private NumericUpDown numericUpDownConstraints;
        private Label label6;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tMtxLP1 = new Dew.Math.TMtxLP(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownConstraints = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownEquations = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.checkBoxMinimize = new System.Windows.Forms.CheckBox();
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.panelSystem = new System.Windows.Forms.Panel();
            this.textBoxRelations = new System.Windows.Forms.TextBox();
            this.labelRelations = new System.Windows.Forms.Label();
            this.mtxGridViewc = new Dew.Math.Controls.MtxGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxGridViewb = new Dew.Math.Controls.MtxGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxGridViewA = new Dew.Math.Controls.MtxGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstraints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEquations)).BeginInit();
            this.panelSystem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Size = new System.Drawing.Size(918, 425);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 537);
            this.panel3.Size = new System.Drawing.Size(918, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(918, 112);
            // 
            // tMtxLP1
            // 
            this.tMtxLP1.Algorithm = Dew.Math.TLPAlgorithm.LPAlgoTwoPhaseSimplex;
            this.tMtxLP1.Relations = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonSolve);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxLog);
            this.splitContainer1.Panel1.Controls.Add(this.checkBoxMinimize);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxAlgorithm);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxLog);
            this.splitContainer1.Panel2.Controls.Add(this.panelSystem);
            this.splitContainer1.Size = new System.Drawing.Size(918, 425);
            this.splitContainer1.SplitterDistance = 186;
            this.splitContainer1.TabIndex = 3;
            // 
            // buttonSolve
            // 
            this.buttonSolve.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSolve.Location = new System.Drawing.Point(12, 206);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(75, 23);
            this.buttonSolve.TabIndex = 8;
            this.buttonSolve.Text = "Solve";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownConstraints);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownEquations);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System";
            // 
            // numericUpDownConstraints
            // 
            this.numericUpDownConstraints.Location = new System.Drawing.Point(96, 59);
            this.numericUpDownConstraints.Name = "numericUpDownConstraints";
            this.numericUpDownConstraints.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownConstraints.TabIndex = 3;
            this.numericUpDownConstraints.ValueChanged += new System.EventHandler(this.numericUpDownConstraints_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "# of constraints";
            // 
            // numericUpDownEquations
            // 
            this.numericUpDownEquations.Location = new System.Drawing.Point(96, 25);
            this.numericUpDownEquations.Name = "numericUpDownEquations";
            this.numericUpDownEquations.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownEquations.TabIndex = 1;
            this.numericUpDownEquations.ValueChanged += new System.EventHandler(this.numericUpDownEquations_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "# of equations";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Checked = true;
            this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLog.Location = new System.Drawing.Point(34, 73);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(70, 17);
            this.checkBoxLog.TabIndex = 6;
            this.checkBoxLog.Text = "Show log";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            this.checkBoxLog.CheckedChanged += new System.EventHandler(this.checkBoxLog_CheckedChanged);
            // 
            // checkBoxMinimize
            // 
            this.checkBoxMinimize.AutoSize = true;
            this.checkBoxMinimize.Checked = true;
            this.checkBoxMinimize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMinimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxMinimize.Location = new System.Drawing.Point(34, 49);
            this.checkBoxMinimize.Name = "checkBoxMinimize";
            this.checkBoxMinimize.Size = new System.Drawing.Size(95, 18);
            this.checkBoxMinimize.TabIndex = 5;
            this.checkBoxMinimize.Text = "Find minimum";
            this.checkBoxMinimize.UseVisualStyleBackColor = true;
            this.checkBoxMinimize.CheckedChanged += new System.EventHandler(this.checkBoxMaximize_CheckedChanged);
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Items.AddRange(new object[] {
            "Dual Simplex",
            "Two Phase Simplex",
            "Simplex",
            "Gomory\' CPA"});
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(87, 18);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(92, 21);
            this.comboBoxAlgorithm.TabIndex = 4;
            this.comboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Algorithm";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 226);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(728, 199);
            this.richTextBoxLog.TabIndex = 1;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.WordWrap = false;
            // 
            // panelSystem
            // 
            this.panelSystem.Controls.Add(this.textBoxRelations);
            this.panelSystem.Controls.Add(this.labelRelations);
            this.panelSystem.Controls.Add(this.mtxGridViewc);
            this.panelSystem.Controls.Add(this.label4);
            this.panelSystem.Controls.Add(this.mtxGridViewb);
            this.panelSystem.Controls.Add(this.label3);
            this.panelSystem.Controls.Add(this.mtxGridViewA);
            this.panelSystem.Controls.Add(this.label2);
            this.panelSystem.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSystem.Location = new System.Drawing.Point(0, 0);
            this.panelSystem.Name = "panelSystem";
            this.panelSystem.Size = new System.Drawing.Size(728, 226);
            this.panelSystem.TabIndex = 0;
            // 
            // textBoxRelations
            // 
            this.textBoxRelations.Location = new System.Drawing.Point(67, 203);
            this.textBoxRelations.Name = "textBoxRelations";
            this.textBoxRelations.Size = new System.Drawing.Size(135, 20);
            this.textBoxRelations.TabIndex = 7;
            this.textBoxRelations.TextChanged += new System.EventHandler(this.textBoxRelations_TextChanged);
            // 
            // labelRelations
            // 
            this.labelRelations.AutoSize = true;
            this.labelRelations.Location = new System.Drawing.Point(10, 206);
            this.labelRelations.Name = "labelRelations";
            this.labelRelations.Size = new System.Drawing.Size(51, 13);
            this.labelRelations.TabIndex = 6;
            this.labelRelations.Text = "Relations";
            // 
            // mtxGridViewc
            // 
            this.mtxGridViewc.AllowUserToAddRows = false;
            this.mtxGridViewc.AllowUserToDeleteRows = false;
            this.mtxGridViewc.AllowUserToResizeColumns = false;
            this.mtxGridViewc.AllowUserToResizeRows = false;
            this.mtxGridViewc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridViewc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridViewc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridViewc.DefaultCellStyle = dataGridViewCellStyle1;
            this.mtxGridViewc.Location = new System.Drawing.Point(341, 34);
            this.mtxGridViewc.MultiSelect = false;
            this.mtxGridViewc.Name = "mtxGridViewc";
            this.mtxGridViewc.numberFormat = "0.0000";
            this.mtxGridViewc.ObjectInfoText = "";
            this.mtxGridViewc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridViewc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridViewc.Size = new System.Drawing.Size(102, 156);
            this.mtxGridViewc.TabIndex = 5;
            this.mtxGridViewc.VirtualMode = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "c in f(x) = c(T)x";
            // 
            // mtxGridViewb
            // 
            this.mtxGridViewb.AllowUserToAddRows = false;
            this.mtxGridViewb.AllowUserToDeleteRows = false;
            this.mtxGridViewb.AllowUserToResizeColumns = false;
            this.mtxGridViewb.AllowUserToResizeRows = false;
            this.mtxGridViewb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridViewb.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridViewb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridViewb.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtxGridViewb.Location = new System.Drawing.Point(220, 34);
            this.mtxGridViewb.MultiSelect = false;
            this.mtxGridViewb.Name = "mtxGridViewb";
            this.mtxGridViewb.numberFormat = "0.0000";
            this.mtxGridViewb.ObjectInfoText = "";
            this.mtxGridViewb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridViewb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridViewb.Size = new System.Drawing.Size(102, 156);
            this.mtxGridViewb.TabIndex = 3;
            this.mtxGridViewb.VirtualMode = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "b in Ax<=b";
            // 
            // mtxGridViewA
            // 
            this.mtxGridViewA.AllowUserToAddRows = false;
            this.mtxGridViewA.AllowUserToDeleteRows = false;
            this.mtxGridViewA.AllowUserToResizeColumns = false;
            this.mtxGridViewA.AllowUserToResizeRows = false;
            this.mtxGridViewA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.mtxGridViewA.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.mtxGridViewA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtxGridViewA.DefaultCellStyle = dataGridViewCellStyle3;
            this.mtxGridViewA.Location = new System.Drawing.Point(6, 34);
            this.mtxGridViewA.MultiSelect = false;
            this.mtxGridViewA.Name = "mtxGridViewA";
            this.mtxGridViewA.numberFormat = "0.0000";
            this.mtxGridViewA.ObjectInfoText = "";
            this.mtxGridViewA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.mtxGridViewA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mtxGridViewA.Size = new System.Drawing.Size(196, 156);
            this.mtxGridViewA.TabIndex = 1;
            this.mtxGridViewA.VirtualMode = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "A in Ax<=b";
            // 
            // LPDemo
            // 
            this.ClientSize = new System.Drawing.Size(918, 585);
            this.Name = "LPDemo";
            this.Load += new System.EventHandler(this.LPDemo_Load);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstraints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEquations)).EndInit();
            this.panelSystem.ResumeLayout(false);
            this.panelSystem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtxGridViewA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private void LPDemo_Load(object sender, EventArgs e)
        {
            Add("New in Dew Math 3.1: Optimization unit now includes several routines plus component "
                + "for solving linear programming problems (LP). Routines include support for solving "
                + "dual, two phase and ordinary LP problems. Now the following LP problems can be solved:\n");
            Add(" f(x) =c(T)*x ; A*x>=b; x=>0  (Dual Simplex)");
            Add(" f(x) =c(T)*x ; A*x relation b; x=>0 (Two Phase Simplex)");
            Add(" f(x) =c(T)*x ; A*x<=b; x=>0 (Simplex)");
            Add(" f(x) =c(T)*x ; A*x<=b; x=>0, integers (Gomory's CPA)");
            Add("\nIn the example bellow a system with 7 equations and 2 constraints is minimized. The system is "
                +   "defined by:\nf(x) = 3x1 + 4x2 + 6x3 + 7x4 +x5\nsubject to:\n2x1 - x2 + x3 +6x4 -5x5 -x6 = 6\nx1 + x2 +2x3 + x4 +2x5 -x7 = 3\n");
            Add("In this case a two-phase Simplex algorithm (because of the constraints) should be used to solve the LP problem.");
            Add("Also try changing LP problem parameters (number of equations, constraint type, ... and use other appropriate algorithms to solve the problem.");

            // Load some prepared data for two-phase problem,
            // Two equations with seven variables and two constraints.
            tMtxLP1.Algorithm = TLPAlgorithm.LPAlgoTwoPhaseSimplex;
            tMtxLP1.A.SetIt(2, 7, false, new double[] {2,-1,1,6,-5,-1,0,
                                                    1,1,2,1,2,0,-1});
            tMtxLP1.b.SetIt(new double[] { 6, 3 });
            tMtxLP1.c.SetIt(new double[] { 3, 4, 6, 7, 1, 0, 0 });
            tMtxLP1.Relations = "==";

            mtxGridViewA.UpdateGrid();
            mtxGridViewb.UpdateGrid();
            mtxGridViewc.UpdateGrid();

            comboBoxAlgorithm.SelectedIndex = (int)tMtxLP1.Algorithm;
            checkBoxMinimize.Checked = tMtxLP1.Minimize;
            numericUpDownEquations.Value = tMtxLP1.c.Length;
            numericUpDownConstraints.Value = tMtxLP1.b.Length;
            textBoxRelations.Text = tMtxLP1.Relations;
            formloading = false;
        }

        private void checkBoxMaximize_CheckedChanged(object sender, EventArgs e)
        {
            if (!formloading)
                tMtxLP1.Minimize = checkBoxMinimize.Checked;
        }

        private void checkBoxLog_CheckedChanged(object sender, EventArgs e)
        {
            tMtxLP1.Verbose = (checkBoxLog.Checked) ? log : null;
        }

        private void numericUpDownEquations_ValueChanged(object sender, EventArgs e)
        {
            if (!formloading)
            {
                tMtxLP1.c.Length = (int)numericUpDownEquations.Value;
                tMtxLP1.A.Cols = tMtxLP1.c.Length;
            }
        }

        private void numericUpDownConstraints_ValueChanged(object sender, EventArgs e)
        {
            if (!formloading)
            {
                tMtxLP1.b.Length = (int)numericUpDownConstraints.Value;
                tMtxLP1.A.Rows = tMtxLP1.b.Length;
            }
        }

        private void comboBoxAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            tMtxLP1.Algorithm = (TLPAlgorithm)comboBoxAlgorithm.SelectedIndex;
            textBoxRelations.Visible = tMtxLP1.Algorithm == TLPAlgorithm.LPAlgoTwoPhaseSimplex;
            labelRelations.Visible = textBoxRelations.Visible;
        }

        private void textBoxRelations_TextChanged(object sender, EventArgs e)
        {
            if (!formloading)
                tMtxLP1.Relations = textBoxRelations.Text;

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            log.Clear();
            log.Add("Algorithm log\n\n");
            richTextBoxLog.Clear();

            tMtxLP1.Recalculate();
            if (checkBoxLog.Checked)
            {
                richTextBoxLog.SelectedText = log.Text;
            }
            switch (tMtxLP1.SolutionType)
            {
                case TLPSolution.LPFiniteSolution: richTextBoxLog.SelectedText += "Problem has finite optimal solution.\n"; break;
                case TLPSolution.LPEmptyFeasableRegion: richTextBoxLog.SelectedText += "Empty feasable region.\n"; break;
                case TLPSolution.LPUnboundedObjectiveFunction: richTextBoxLog.SelectedText += "Unbounded optimal solution.\n"; break;
            }
            richTextBoxLog.SelectedText += "Values of legitimate variables:\n";
            string st;
            tMtxLP1.x.ValuesToText(out st, "0.000", "0.000");
            richTextBoxLog.SelectedText += st + "\nf(x) value at optimal point:\t"+tMtxLP1.z.ToString("0.000")+"\n";

        }

    }
}

