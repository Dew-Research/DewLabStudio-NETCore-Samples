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
            this.components = new System.ComponentModel.Container();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panelEditor = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.richTextBoxErrors = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelEditor);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Size = new System.Drawing.Size(798, 437);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 575);
            this.panel3.Size = new System.Drawing.Size(798, 42);
            this.panel3.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(798, 138);
            // 
            // panelEditor
            // 
            this.panelEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditor.Location = new System.Drawing.Point(0, 29);
            this.panelEditor.Name = "panelEditor";
            this.panelEditor.Size = new System.Drawing.Size(798, 331);
            this.panelEditor.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 29);
            this.panel4.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "a+b",
            "sin(x)",
            "x := y",
            "v1*v2\'",
            "A*B",
            "Custom (user)"});
            this.comboBox1.Location = new System.Drawing.Point(147, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(340, 23);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Predefined examples";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonEvaluate);
            this.panel5.Controls.Add(this.richTextBoxErrors);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.listBoxResults);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 360);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(798, 77);
            this.panel5.TabIndex = 23;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEvaluate.Location = new System.Drawing.Point(269, 44);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(63, 23);
            this.buttonEvaluate.TabIndex = 22;
            this.buttonEvaluate.Text = "Evaluate";
            this.buttonEvaluate.UseVisualStyleBackColor = true;
            this.buttonEvaluate.Click += new System.EventHandler(this.buttonEvaluate_Click);
            // 
            // richTextBoxErrors
            // 
            this.richTextBoxErrors.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxErrors.DetectUrls = false;
            this.richTextBoxErrors.Location = new System.Drawing.Point(348, 11);
            this.richTextBoxErrors.Name = "richTextBoxErrors";
            this.richTextBoxErrors.ReadOnly = true;
            this.richTextBoxErrors.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxErrors.Size = new System.Drawing.Size(201, 56);
            this.richTextBoxErrors.TabIndex = 21;
            this.richTextBoxErrors.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Errors:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Results";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 15;
            this.listBoxResults.Location = new System.Drawing.Point(51, 11);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(201, 49);
            this.listBoxResults.TabIndex = 18;
            // 
            // MathParser
            // 
            this.ClientSize = new System.Drawing.Size(798, 617);
            this.Name = "MathParser";
            this.Load += new System.EventHandler(this.MathParser_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

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

