using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using Dew.Math.Editors;

namespace MtxVecDemo
{
    public class MathParser : MtxVecDemo.BasicForm2
    {
        private TVariableCollection vars;
        private TMtxFunctionEvaluator fe;
        private ToolTip toolTipHelp;
        private Panel panelEditor;
        private Panel panel5;
        private Button buttonEvaluate;
        private RichTextBox richTextBoxErrors;
        private Label label5;
        private Label label4;
        private ListBox listBoxResults;
        private Panel panel4;
        private ComboBox comboBox1;
        private Label label2;
        private Dew.Math.Editors.ExprContextEditor expEditor;

        public MathParser()
        {
            InitializeComponent();
            vars = new TVariableCollection();
            fe = new TMtxFunctionEvaluator();

            // Setup expression editor.
            expEditor = new ExprContextEditor();
            expEditor.Context = fe.Context;
            expEditor.Owner = this;
            expEditor.FormBorderStyle = FormBorderStyle.None;
            expEditor.TopLevel = false;
            expEditor.Dock = DockStyle.Fill;
            expEditor.ShowOkCancel = false;
            expEditor.Parent = panelEditor as Control;
        }

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
            toolTipHelp = new ToolTip(components);
            panelEditor = new Panel();
            panel4 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            buttonEvaluate = new Button();
            richTextBoxErrors = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            listBoxResults = new ListBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(panelEditor);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Size = new Size(1080, 432);
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 570);
            panel3.Size = new Size(1080, 42);
            panel3.Visible = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Size = new Size(1080, 138);
            // 
            // panelEditor
            // 
            panelEditor.Dock = DockStyle.Fill;
            panelEditor.Location = new Point(0, 29);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(1080, 326);
            panelEditor.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1080, 29);
            panel4.TabIndex = 22;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "a+b", "sin(x)", "x := y", "v1*v2'", "A*B", "Custom (user)" });
            comboBox1.Location = new Point(125, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(340, 23);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 3);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 5;
            label2.Text = "Predefined examples";
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonEvaluate);
            panel5.Controls.Add(richTextBoxErrors);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(listBoxResults);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 355);
            panel5.Name = "panel5";
            panel5.Size = new Size(1080, 77);
            panel5.TabIndex = 23;
            // 
            // buttonEvaluate
            // 
            buttonEvaluate.FlatStyle = FlatStyle.System;
            buttonEvaluate.Location = new Point(269, 44);
            buttonEvaluate.Name = "buttonEvaluate";
            buttonEvaluate.Size = new Size(63, 23);
            buttonEvaluate.TabIndex = 22;
            buttonEvaluate.Text = "Evaluate";
            buttonEvaluate.UseVisualStyleBackColor = true;
            buttonEvaluate.Click += buttonEvaluate_Click;
            // 
            // richTextBoxErrors
            // 
            richTextBoxErrors.BackColor = SystemColors.Window;
            richTextBoxErrors.BorderStyle = BorderStyle.None;
            richTextBoxErrors.DetectUrls = false;
            richTextBoxErrors.Location = new Point(348, 11);
            richTextBoxErrors.Name = "richTextBoxErrors";
            richTextBoxErrors.ReadOnly = true;
            richTextBoxErrors.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxErrors.Size = new Size(201, 56);
            richTextBoxErrors.TabIndex = 21;
            richTextBoxErrors.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 11);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 20;
            label5.Text = "Errors:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 11);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 19;
            label4.Text = "Results";
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(51, 11);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(201, 49);
            listBoxResults.TabIndex = 18;
            // 
            // MathParser
            // 
            ClientSize = new Size(1080, 612);
            Name = "MathParser";
            Load += MathParser_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);

        }

        #endregion


        private void MathParser_Load(object sender, EventArgs e)
        {
            Add("TMtxExpression class is used for evaluating math formulas. Real numbers, complex numbers, vectors and matrices are supported.\r\n");
            Add("1. Enter arithmetic expression (or select one of the predefined list).");
            Add("2. Press [Detect] button to collect variables to the list (already done for predefined examples).");
            Add("3. Define each variable with type and value (already done for predefined examples).");
            Add("4. Press [Evaluate] button and look at the results.");
            
            expEditor.Show();
            comboBox1.SelectedIndex = 0; // a+b
        }

        private void buttonEvaluate_Click(object sender, EventArgs e)
        {
            TValueRec result;
            try
            {
                listBoxResults.Items.Clear();
                richTextBoxErrors.Clear();

                // assign only in this special case as only ShowDialog updates original function evaluator
                fe.Context.Assign(expEditor.Context);

                result = fe.Recalculate();
                listBoxResults.Items.Add("Result : " + result.AsString);

                TStringList list = new TStringList();
                fe.Expressions.GetVarList(list);
                for (int i = 0; i < list.Count; i++)
                {
                    listBoxResults.Items.Add(list[i] + " : " + fe.Expressions.VarByName[list[i]].AsString);
                }

                listBoxResults.SelectedIndex = 0;

            }
            catch (Exception exception)
            {
                richTextBoxErrors.Text = exception.Message;
            }
        }

        /// Construct and repopulate with examples
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dew.Math.TExprContext context = fe.Context;
            context.Variables.Clear();
            context.Expression = comboBox1.SelectedItem.ToString();
            


            // Define formula and variable values
            TNamedVariable var;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        var = context.Variables.Add("a");
                        var.Value.DefineDouble();
                        var.Value.DoubleValue = 2.2;
                        var = context.Variables.Add("b");
                        var.Value.DefineDouble();
                        var.Value.DoubleValue = -5.5;
                    }; break;
                case 1:
                    {
                        var = context.Variables.Add("x");
                        var.Value.DefineDouble();
                        var.Value.DoubleValue = Math387.PI;
                    }; break;
                case 2:
                    {
                        context.Variables.Add("x");
                        var = context.Variables.Add("y");
                        var.Value.DefineComplex();
                        TCplx z;
                        z.Re = 2;
                        z.Im = -5.5;
                        var.Value.ComplexValue = z;
                    }; break;
                case 3:
                    {
                        var = context.Variables.Add("v1");
                        var.Value.DefineVector();
                        var.Value.VectorValue.SetIt(new double[] { 1, 2, 0, -3 });
                        var = context.Variables.Add("v2");
                        var.Value.DefineVector();
                        var.Value.VectorValue.SetIt(new double[] { 1, -1, 1, 1 });
                    }; break;
                case 4:
                    {
                        var = context.Variables.Add("A");
                        var.Value.DefineMatrix();
                        var.Value.MatrixValue.SetIt(3, 3, false, new double[] { 1, 2, 3, 4, 5, 6, 1, 1, 1 });
                        var = context.Variables.Add("B");
                        var.Value.DefineMatrix();
                        var.Value.MatrixValue.SetIt(3, 3, false, new double[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 });
                    }; break;
                default:
                    {
                        context.Expression = "";

                    } break;
            }

            expEditor.Context = fe.Context;

            // Evaluate
            buttonEvaluate_Click(this, new EventArgs());
        }

    }
}

