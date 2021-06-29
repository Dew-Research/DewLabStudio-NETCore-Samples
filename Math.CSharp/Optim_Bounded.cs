using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;


namespace MtxVecDemo
{
    public class Optim_Bounded : MtxVecDemo.BasicForm2
    {
        public Optim_Bounded()
        {
            InitializeComponent();
            dataGridView1.DataSource = dataSet1.Tables["TablePars"];
            dataSet1.Tables["TablePars"].DefaultView.AllowNew = false;
            dataGridView2.DataSource = dataSet1.Tables["TableResults"];
            variables = new TVariableCollection();
			fundelegate = new TRealFunction(OptimObjFun);

        }
        private DataSet dataSet1;
        private DataTable dataTablePars;
        private DataColumn dataColumn1;
        private DataColumn dataColumn2;
        private DataColumn dataColumn3;
        private DataColumn dataColumn4;
        private DataTable dataTableResults;
        private DataColumn dataColumn5;
        private DataColumn dataColumn6;
        private TextBox textBoxFunction;
        private Label label1;
        private Button buttonMinimize;
        private Button buttonDetect;
        private RichTextBox richTextBox2;
        private GroupBox groupBox1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private CheckBox checkBox1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private Label label4;
        private Label label5;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optim_Bounded));
            this.dataSet1 = new System.Data.DataSet();
            this.dataTablePars = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataTableResults = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFunction = new System.Windows.Forms.TextBox();
            this.buttonDetect = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Controls.Add(this.buttonDetect);
            this.panel2.Controls.Add(this.textBoxFunction);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(767, 444);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 582);
            this.panel3.Size = new System.Drawing.Size(767, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(767, 138);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePars,
            this.dataTableResults});
            // 
            // dataTablePars
            // 
            this.dataTablePars.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTablePars.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Name"}, true)});
            this.dataTablePars.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataTablePars.Namespace = "";
            this.dataTablePars.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn1};
            this.dataTablePars.TableName = "TablePars";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.Caption = "Name";
            this.dataColumn1.ColumnName = "Name";
            this.dataColumn1.DefaultValue = ((object)(resources.GetObject("dataColumn1.DefaultValue")));
            this.dataColumn1.Namespace = "";
            this.dataColumn1.ReadOnly = true;
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Lower bound";
            this.dataColumn2.ColumnName = "Lower bound";
            this.dataColumn2.DataType = typeof(double);
            this.dataColumn2.DefaultValue = ((object)(resources.GetObject("dataColumn2.DefaultValue")));
            this.dataColumn2.Namespace = "";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Upper bound";
            this.dataColumn3.ColumnName = "Upper bound";
            this.dataColumn3.DataType = typeof(double);
            this.dataColumn3.DefaultValue = ((object)(resources.GetObject("dataColumn3.DefaultValue")));
            this.dataColumn3.Namespace = "";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Initial value";
            this.dataColumn4.ColumnName = "Initial value";
            this.dataColumn4.DataType = typeof(double);
            this.dataColumn4.DefaultValue = ((object)(resources.GetObject("dataColumn4.DefaultValue")));
            this.dataColumn4.Namespace = "";
            // 
            // dataTableResults
            // 
            this.dataTableResults.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6});
            this.dataTableResults.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Name"}, true)});
            this.dataTableResults.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataTableResults.Namespace = "";
            this.dataTableResults.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn5};
            this.dataTableResults.TableName = "TableResults";
            // 
            // dataColumn5
            // 
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.Caption = "Name";
            this.dataColumn5.ColumnName = "Name";
            this.dataColumn5.DefaultValue = ((object)(resources.GetObject("dataColumn5.DefaultValue")));
            this.dataColumn5.Namespace = "";
            this.dataColumn5.ReadOnly = true;
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Value";
            this.dataColumn6.ColumnName = "Value";
            this.dataColumn6.DataType = typeof(double);
            this.dataColumn6.DefaultValue = ((object)(resources.GetObject("dataColumn6.DefaultValue")));
            this.dataColumn6.Namespace = "";
            this.dataColumn6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Function";
            // 
            // textBoxFunction
            // 
            this.textBoxFunction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFunction.Location = new System.Drawing.Point(66, 18);
            this.textBoxFunction.Name = "textBoxFunction";
            this.textBoxFunction.Size = new System.Drawing.Size(689, 23);
            this.textBoxFunction.TabIndex = 5;
            this.textBoxFunction.Text = "100*Sqr(b-Sqr(a)) + Sqr(1-a)";
            this.textBoxFunction.TextChanged += new System.EventHandler(this.textBoxFunction_TextChanged);
            // 
            // buttonDetect
            // 
            this.buttonDetect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDetect.Location = new System.Drawing.Point(66, 44);
            this.buttonDetect.Name = "buttonDetect";
            this.buttonDetect.Size = new System.Drawing.Size(75, 23);
            this.buttonDetect.TabIndex = 6;
            this.buttonDetect.Text = "Detect";
            this.buttonDetect.UseVisualStyleBackColor = true;
            this.buttonDetect.Click += new System.EventHandler(this.buttonDetect_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Enabled = false;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMinimize.Location = new System.Drawing.Point(147, 44);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(75, 23);
            this.buttonMinimize.TabIndex = 7;
            this.buttonMinimize.Text = "Minimize";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Location = new System.Drawing.Point(15, 223);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(512, 215);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(546, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(67, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Show log";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(67, 59);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max. iter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tolerance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 97);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(512, 120);
            this.dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(546, 253);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(209, 185);
            this.dataGridView2.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Optimization results";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Function variables";
            // 
            // Optim_Bounded
            // 
            this.ClientSize = new System.Drawing.Size(767, 630);
            this.Name = "Optim_Bounded";
            this.Load += new System.EventHandler(this.Optim_Bounded_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private TVariableCollection variables;
        private double tol = 1.0e-6;
		private TRealFunction fundelegate;

        // A bit tricky, but OptimObjConsts hold all necessary objects, strings, etc..
        // needed for calculation of f(parameters)
        // obj[0] = TMtxExpression
        // obj[1] = iVariables
        // pars = parameter values

        private double OptimObjFun(TVec Parameters, TVec Constants, params object[] ObjConst)
        {
            TMtxExpression expr = (ObjConst[0] as TMtxExpression);
            TVariableCollection vars = (ObjConst[1] as TVariableCollection);
            TValueRec var;


            for (int t = 0; t < Parameters.Length; t++)
            {
                var = expr.VarByName[vars[t].VarName];
                var.DoubleValue = Parameters.Values[t];
            }
            return expr.EvaluateDouble();
        }


        private void Detect()
        {
            TMtxExpression expr = new TMtxExpression();
            TStringList vars = new TStringList();
            TNamedVariable v;

            variables.Clear();
            dataTablePars.Rows.Clear();
            dataTableResults.Rows.Clear();

            expr.AddExpr(textBoxFunction.Text);
            expr.GetVarList(vars);
            for (int i = 0; i < vars.Count; i++)
            {
                v = variables.Add(vars[i]);
                v.Value.DefineDouble();
                // add to TableParameters and TableResults
                dataTablePars.Rows.Add(new object[4] { v.VarName, -Math387.INF,Math387.INF, v.Value.DoubleValue });
                dataTableResults.Rows.Add(new object[2] { v.VarName, v.Value.DoubleValue});
            }

            buttonMinimize.Enabled = true;
        }

        private void SolveProblem()
        {
            richTextBox2.Clear();
            TStringList log = new TStringList();
            double[] pars = new double[variables.Count];
            double[] lb = new double[variables.Count];
            double[] ub = new double[variables.Count];
            
            // #1: Setup parser and objective function
            TMtxExpression expr = new TMtxExpression();
            expr.Expressions = textBoxFunction.Text;
            for (int t = 0; t < variables.Count; t++)
            {
                DataRow row = dataTablePars.Rows.Find(variables[t].VarName);
                if (row != null)
                {
                    pars[t] = Convert.ToDouble(row[3]);
                    lb[t] = Convert.ToDouble(row[1]);
                    ub[t] = Convert.ToDouble(row[2]);
                    expr.DefineDouble(variables[t].VarName).Value = pars[t];
                }
            }


            // #2: Optimization
            tol = Convert.ToDouble(textBox1.Text);
            int maxiter = (int)numericUpDown1.Value;
            int iter;
            double fmin;
            TOptStopReason stopreason;
            if (checkBox1.Checked)
            {
                iter = Optimization.Simplex(fundelegate, ref pars, null, new object[2] { expr, variables }, lb, ub, out fmin, out stopreason, TMtxFloatPrecision.mvDouble, maxiter, tol, log);
                richTextBox2.Text += log.Text;
            }
            else
                iter = Optimization.Simplex(fundelegate, ref pars, null, new object[2] { expr, variables }, lb,ub,out fmin, out stopreason, TMtxFloatPrecision.mvDouble,  maxiter, tol, null);

            // #3: Format results

            Vector parsVec = new Vector();
            parsVec.CopyFromArray(pars);
            double result = OptimObjFun(parsVec, null, new object[2] { expr, variables });

            switch (stopreason)
            {
                case TOptStopReason.OptResNotFound: richTextBox2.Text +="Minimum not found.\r\n"; break;
                case TOptStopReason.OptResSmallGrad : richTextBox2.Text +="Small gradient step.\r\n"; break;
                case TOptStopReason.OptResSingular : richTextBox2.Text +="Singularity.\r\n"; break;
                case TOptStopReason.OptResSmallStep : richTextBox2.Text += "Small step.\r\n"; break;
                case TOptStopReason.OptResMaxIter : richTextBox2.Text += "Maximum number of iterations reached.\r\n"; break;
                case TOptStopReason.OptResBigLambda: richTextBox2.Text += "Big lambda.\r\n"; break;
                case TOptStopReason.optResSmallJacobian: richTextBox2.Text += "Small Jacobian.\r\n"; break;
                default : richTextBox2.Text += "Converged within given tolerance and allowed iterations.\r\n"; break;


            }
            richTextBox2.Text += "\r\nNumber of iterations:\t" + iter.ToString()+"\r\n";
            richTextBox2.Text += "Function value:\t" + Math387.SampleToStr(fmin, 3, 6)+"\r\n";

            dataTableResults.Rows.Clear();
            for (int t = 0; t < variables.Count; t++)
            {
                dataTableResults.Rows.Add(new object[2] { variables[t].VarName, pars[t] });
            }

        }

        private void buttonDetect_Click(object sender, EventArgs e)
        {
            Detect();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            SolveProblem();
        }

        private void Optim_Bounded_Load(object sender, EventArgs e)
        {
            Add("Optimization now supports bounded constraints. Invididual parameter can have no, lower, upper or both limits. This is done by:\r\n");
            Add("1. No limit: lower bound is -INF, upper bound is INF.");
            Add("2. Lower bound: lower bound is lb, upper bound is INF.");
            Add("3. Upper bound: lower bound is -INF, upper bound is ub.");
            Add("4. Lower and upper bound: lower bound is lb, upper bound is ub.\r\n");
            Add("1. Enter any function in the \"Functon\" edit box.");
            Add("2. Click the \"Detect\" button to get the list of variables in function.");
            Add("3. Define bounds (if any) for individual variables.");
            Add("4. Define starting values for individual variables.");
            Add("5. Press the \"Minimize\" button to minimize function.");

            textBox1.Text = tol.ToString();
            Detect();
        }

        private void textBoxFunction_TextChanged(object sender, EventArgs e)
        {
            buttonMinimize.Enabled = false;
            buttonDetect.Enabled = true;
        }

    }
}

