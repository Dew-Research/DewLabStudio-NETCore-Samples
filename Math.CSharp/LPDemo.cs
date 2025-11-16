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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tMtxLP1 = new TMtxLP(components);
            splitContainer1 = new SplitContainer();
            buttonSolve = new Button();
            groupBox1 = new GroupBox();
            numericUpDownConstraints = new NumericUpDown();
            label6 = new Label();
            numericUpDownEquations = new NumericUpDown();
            label5 = new Label();
            checkBoxLog = new CheckBox();
            checkBoxMinimize = new CheckBox();
            comboBoxAlgorithm = new ComboBox();
            label1 = new Label();
            richTextBoxLog = new RichTextBox();
            panelSystem = new Panel();
            textBoxRelations = new TextBox();
            labelRelations = new Label();
            mtxGridViewc = new Dew.Math.Controls.MtxGridView();
            label4 = new Label();
            mtxGridViewb = new Dew.Math.Controls.MtxGridView();
            label3 = new Label();
            mtxGridViewA = new Dew.Math.Controls.MtxGridView();
            label2 = new Label();
            panel2.SuspendLayout();
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)numericUpDownConstraints).BeginInit();
            ((ISupportInitialize)numericUpDownEquations).BeginInit();
            panelSystem.SuspendLayout();
            ((ISupportInitialize)mtxGridViewc).BeginInit();
            ((ISupportInitialize)mtxGridViewb).BeginInit();
            ((ISupportInitialize)mtxGridViewA).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(splitContainer1);
            panel2.Size = new Size(967, 418);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 556);
            panel3.Size = new Size(967, 48);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(967, 138);
            // 
            // tMtxLP1
            // 
            tMtxLP1.Algorithm = TLPAlgorithm.LPAlgoTwoPhaseSimplex;
            tMtxLP1.Relations = null;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSolve);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(checkBoxLog);
            splitContainer1.Panel1.Controls.Add(checkBoxMinimize);
            splitContainer1.Panel1.Controls.Add(comboBoxAlgorithm);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBoxLog);
            splitContainer1.Panel2.Controls.Add(panelSystem);
            splitContainer1.Size = new Size(967, 418);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 3;
            // 
            // buttonSolve
            // 
            buttonSolve.FlatStyle = FlatStyle.System;
            buttonSolve.Location = new Point(12, 206);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(75, 23);
            buttonSolve.TabIndex = 8;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownConstraints);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numericUpDownEquations);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(12, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(167, 94);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "System";
            // 
            // numericUpDownConstraints
            // 
            numericUpDownConstraints.Location = new Point(96, 59);
            numericUpDownConstraints.Name = "numericUpDownConstraints";
            numericUpDownConstraints.Size = new Size(59, 23);
            numericUpDownConstraints.TabIndex = 3;
            numericUpDownConstraints.ValueChanged += numericUpDownConstraints_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 2;
            label6.Text = "# of constraints";
            // 
            // numericUpDownEquations
            // 
            numericUpDownEquations.Location = new Point(96, 25);
            numericUpDownEquations.Name = "numericUpDownEquations";
            numericUpDownEquations.Size = new Size(59, 23);
            numericUpDownEquations.TabIndex = 1;
            numericUpDownEquations.ValueChanged += numericUpDownEquations_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 27);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 0;
            label5.Text = "# of equations";
            // 
            // checkBoxLog
            // 
            checkBoxLog.AutoSize = true;
            checkBoxLog.Checked = true;
            checkBoxLog.CheckState = CheckState.Checked;
            checkBoxLog.Location = new Point(34, 73);
            checkBoxLog.Name = "checkBoxLog";
            checkBoxLog.Size = new Size(75, 19);
            checkBoxLog.TabIndex = 6;
            checkBoxLog.Text = "Show log";
            checkBoxLog.UseVisualStyleBackColor = true;
            checkBoxLog.CheckedChanged += checkBoxLog_CheckedChanged;
            // 
            // checkBoxMinimize
            // 
            checkBoxMinimize.AutoSize = true;
            checkBoxMinimize.Checked = true;
            checkBoxMinimize.CheckState = CheckState.Checked;
            checkBoxMinimize.FlatStyle = FlatStyle.System;
            checkBoxMinimize.Location = new Point(34, 49);
            checkBoxMinimize.Name = "checkBoxMinimize";
            checkBoxMinimize.Size = new Size(111, 20);
            checkBoxMinimize.TabIndex = 5;
            checkBoxMinimize.Text = "Find minimum";
            checkBoxMinimize.UseVisualStyleBackColor = true;
            checkBoxMinimize.CheckedChanged += checkBoxMaximize_CheckedChanged;
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.FlatStyle = FlatStyle.System;
            comboBoxAlgorithm.FormattingEnabled = true;
            comboBoxAlgorithm.Items.AddRange(new object[] { "Dual Simplex", "Two Phase Simplex", "Simplex", "Gomory' CPA" });
            comboBoxAlgorithm.Location = new Point(87, 18);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new Size(92, 23);
            comboBoxAlgorithm.TabIndex = 4;
            comboBoxAlgorithm.SelectedIndexChanged += comboBoxAlgorithm_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Algorithm";
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.BackColor = SystemColors.Window;
            richTextBoxLog.Dock = DockStyle.Fill;
            richTextBoxLog.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBoxLog.Location = new Point(0, 226);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.ReadOnly = true;
            richTextBoxLog.Size = new Size(777, 192);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "";
            richTextBoxLog.WordWrap = false;
            // 
            // panelSystem
            // 
            panelSystem.Controls.Add(textBoxRelations);
            panelSystem.Controls.Add(labelRelations);
            panelSystem.Controls.Add(mtxGridViewc);
            panelSystem.Controls.Add(label4);
            panelSystem.Controls.Add(mtxGridViewb);
            panelSystem.Controls.Add(label3);
            panelSystem.Controls.Add(mtxGridViewA);
            panelSystem.Controls.Add(label2);
            panelSystem.Dock = DockStyle.Top;
            panelSystem.Location = new Point(0, 0);
            panelSystem.Name = "panelSystem";
            panelSystem.Size = new Size(777, 226);
            panelSystem.TabIndex = 0;
            // 
            // textBoxRelations
            // 
            textBoxRelations.Location = new Point(67, 203);
            textBoxRelations.Name = "textBoxRelations";
            textBoxRelations.Size = new Size(135, 23);
            textBoxRelations.TabIndex = 7;
            textBoxRelations.TextChanged += textBoxRelations_TextChanged;
            // 
            // labelRelations
            // 
            labelRelations.AutoSize = true;
            labelRelations.Location = new Point(10, 206);
            labelRelations.Name = "labelRelations";
            labelRelations.Size = new Size(55, 15);
            labelRelations.TabIndex = 6;
            labelRelations.Text = "Relations";
            // 
            // mtxGridViewc
            // 
            mtxGridViewc.AllowUserToAddRows = false;
            mtxGridViewc.AllowUserToDeleteRows = false;
            mtxGridViewc.AllowUserToResizeColumns = false;
            mtxGridViewc.AllowUserToResizeRows = false;
            mtxGridViewc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridViewc.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridViewc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "0.0000";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            mtxGridViewc.DefaultCellStyle = dataGridViewCellStyle1;
            mtxGridViewc.Location = new Point(341, 34);
            mtxGridViewc.MultiSelect = false;
            mtxGridViewc.Name = "mtxGridViewc";
            mtxGridViewc.numberFormat = "0.0000";
            mtxGridViewc.ObjectInfoText = "";
            mtxGridViewc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridViewc.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridViewc.Size = new Size(102, 156);
            mtxGridViewc.TabIndex = 5;
            mtxGridViewc.VirtualMode = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(338, 18);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 4;
            label4.Text = "c in f(x) = c(T)x";
            // 
            // mtxGridViewb
            // 
            mtxGridViewb.AllowUserToAddRows = false;
            mtxGridViewb.AllowUserToDeleteRows = false;
            mtxGridViewb.AllowUserToResizeColumns = false;
            mtxGridViewb.AllowUserToResizeRows = false;
            mtxGridViewb.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridViewb.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridViewb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0.0000";
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            mtxGridViewb.DefaultCellStyle = dataGridViewCellStyle2;
            mtxGridViewb.Location = new Point(220, 34);
            mtxGridViewb.MultiSelect = false;
            mtxGridViewb.Name = "mtxGridViewb";
            mtxGridViewb.numberFormat = "0.0000";
            mtxGridViewb.ObjectInfoText = "";
            mtxGridViewb.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridViewb.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridViewb.Size = new Size(102, 156);
            mtxGridViewb.TabIndex = 3;
            mtxGridViewb.VirtualMode = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 18);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "b in Ax<=b";
            // 
            // mtxGridViewA
            // 
            mtxGridViewA.AllowUserToAddRows = false;
            mtxGridViewA.AllowUserToDeleteRows = false;
            mtxGridViewA.AllowUserToResizeColumns = false;
            mtxGridViewA.AllowUserToResizeRows = false;
            mtxGridViewA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            mtxGridViewA.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            mtxGridViewA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "0.0000";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            mtxGridViewA.DefaultCellStyle = dataGridViewCellStyle3;
            mtxGridViewA.Location = new Point(6, 34);
            mtxGridViewA.MultiSelect = false;
            mtxGridViewA.Name = "mtxGridViewA";
            mtxGridViewA.numberFormat = "0.0000";
            mtxGridViewA.ObjectInfoText = "";
            mtxGridViewA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            mtxGridViewA.SelectionMode = DataGridViewSelectionMode.CellSelect;
            mtxGridViewA.Size = new Size(196, 156);
            mtxGridViewA.TabIndex = 1;
            mtxGridViewA.VirtualMode = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "A in Ax<=b";
            // 
            // LPDemo
            // 
            ClientSize = new Size(967, 604);
            Name = "LPDemo";
            Load += LPDemo_Load;
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)numericUpDownConstraints).EndInit();
            ((ISupportInitialize)numericUpDownEquations).EndInit();
            panelSystem.ResumeLayout(false);
            panelSystem.PerformLayout();
            ((ISupportInitialize)mtxGridViewc).EndInit();
            ((ISupportInitialize)mtxGridViewb).EndInit();
            ((ISupportInitialize)mtxGridViewA).EndInit();
            ResumeLayout(false);

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

