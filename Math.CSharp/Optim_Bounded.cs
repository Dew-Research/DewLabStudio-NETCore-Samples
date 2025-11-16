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
            dataSet1 = new DataSet();
            dataTablePars = new DataTable();
            dataColumn1 = new DataColumn();
            dataColumn2 = new DataColumn();
            dataColumn3 = new DataColumn();
            dataColumn4 = new DataColumn();
            dataTableResults = new DataTable();
            dataColumn5 = new DataColumn();
            dataColumn6 = new DataColumn();
            label1 = new Label();
            textBoxFunction = new TextBox();
            buttonDetect = new Button();
            buttonMinimize = new Button();
            richTextBox2 = new RichTextBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            ((ISupportInitialize)dataSet1).BeginInit();
            ((ISupportInitialize)dataTablePars).BeginInit();
            ((ISupportInitialize)dataTableResults).BeginInit();
            groupBox1.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            ((ISupportInitialize)dataGridView1).BeginInit();
            ((ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(buttonMinimize);
            panel2.Controls.Add(buttonDetect);
            panel2.Controls.Add(textBoxFunction);
            panel2.Controls.Add(label1);
            panel2.Size = new Size(1009, 442);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 580);
            panel3.Size = new Size(1009, 48);
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1009, 138);
            // 
            // dataSet1
            // 
            dataSet1.DataSetName = "NewDataSet";
            dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            dataSet1.Tables.AddRange(new DataTable[] { dataTablePars, dataTableResults });
            // 
            // dataTablePars
            // 
            dataTablePars.Columns.AddRange(new DataColumn[] { dataColumn1, dataColumn2, dataColumn3, dataColumn4 });
            dataTablePars.Constraints.AddRange(new Constraint[] { new UniqueConstraint("Constraint1", new string[] { "Name" }, true) });
            dataTablePars.Locale = new System.Globalization.CultureInfo("en-US");
            dataTablePars.Namespace = "";
            dataTablePars.PrimaryKey = new DataColumn[]
    {
    dataColumn1
    };
            dataTablePars.TableName = "TablePars";
            // 
            // dataColumn1
            // 
            dataColumn1.AllowDBNull = false;
            dataColumn1.Caption = "Name";
            dataColumn1.ColumnName = "Name";
            dataColumn1.Namespace = "";
            dataColumn1.ReadOnly = true;
            // 
            // dataColumn2
            // 
            dataColumn2.Caption = "Lower bound";
            dataColumn2.ColumnName = "Lower bound";
            dataColumn2.DataType = typeof(double);
            dataColumn2.Namespace = "";
            // 
            // dataColumn3
            // 
            dataColumn3.Caption = "Upper bound";
            dataColumn3.ColumnName = "Upper bound";
            dataColumn3.DataType = typeof(double);
            dataColumn3.Namespace = "";
            // 
            // dataColumn4
            // 
            dataColumn4.Caption = "Initial value";
            dataColumn4.ColumnName = "Initial value";
            dataColumn4.DataType = typeof(double);
            dataColumn4.Namespace = "";
            // 
            // dataTableResults
            // 
            dataTableResults.Columns.AddRange(new DataColumn[] { dataColumn5, dataColumn6 });
            dataTableResults.Constraints.AddRange(new Constraint[] { new UniqueConstraint("Constraint1", new string[] { "Name" }, true) });
            dataTableResults.Locale = new System.Globalization.CultureInfo("en-US");
            dataTableResults.Namespace = "";
            dataTableResults.PrimaryKey = new DataColumn[]
    {
    dataColumn5
    };
            dataTableResults.TableName = "TableResults";
            // 
            // dataColumn5
            // 
            dataColumn5.AllowDBNull = false;
            dataColumn5.Caption = "Name";
            dataColumn5.ColumnName = "Name";
            dataColumn5.Namespace = "";
            dataColumn5.ReadOnly = true;
            // 
            // dataColumn6
            // 
            dataColumn6.Caption = "Value";
            dataColumn6.ColumnName = "Value";
            dataColumn6.DataType = typeof(double);
            dataColumn6.Namespace = "";
            dataColumn6.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Function";
            // 
            // textBoxFunction
            // 
            textBoxFunction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFunction.Location = new Point(66, 18);
            textBoxFunction.Name = "textBoxFunction";
            textBoxFunction.Size = new Size(931, 23);
            textBoxFunction.TabIndex = 5;
            textBoxFunction.Text = "100*Sqr(b-Sqr(a)) + Sqr(1-a)";
            textBoxFunction.TextChanged += textBoxFunction_TextChanged;
            // 
            // buttonDetect
            // 
            buttonDetect.FlatStyle = FlatStyle.System;
            buttonDetect.Location = new Point(66, 44);
            buttonDetect.Name = "buttonDetect";
            buttonDetect.Size = new Size(75, 23);
            buttonDetect.TabIndex = 6;
            buttonDetect.Text = "Detect";
            buttonDetect.UseVisualStyleBackColor = true;
            buttonDetect.Click += buttonDetect_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Enabled = false;
            buttonMinimize.FlatStyle = FlatStyle.System;
            buttonMinimize.Location = new Point(147, 44);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(75, 23);
            buttonMinimize.TabIndex = 7;
            buttonMinimize.Text = "Minimize";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox2.BackColor = SystemColors.Window;
            richTextBox2.Location = new Point(15, 223);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(754, 213);
            richTextBox2.TabIndex = 8;
            richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(788, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 144);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Settings";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.System;
            checkBox1.Location = new Point(67, 98);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(81, 20);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show log";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Location = new Point(67, 59);
            numericUpDown1.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 500, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 61);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Max. iter";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 27);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 0;
            label2.Text = "Tolerance";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 97);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(754, 120);
            dataGridView1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(788, 253);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(209, 183);
            dataGridView2.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(785, 226);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 12;
            label4.Text = "Optimization results";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 73);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 13;
            label5.Text = "Function variables";
            // 
            // Optim_Bounded
            // 
            ClientSize = new Size(1009, 628);
            Name = "Optim_Bounded";
            Load += Optim_Bounded_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)dataSet1).EndInit();
            ((ISupportInitialize)dataTablePars).EndInit();
            ((ISupportInitialize)dataTableResults).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ((ISupportInitialize)dataGridView1).EndInit();
            ((ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);

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

