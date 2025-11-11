using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;
using static Dew.Math.Units.MtxParseClass;

namespace MtxVecDemo
{
    public class Scripting : Form
    {
        public Scripting()
        {
            InitializeComponent();
            listBoxHistory.Items.Clear();

            //TMtx a,b;
            //MtxVec.CreateIt(out a, out b);
            //b.SetIt(2, 2, true, new double[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            //b.CValues[1, 1] = Math387.Cplx(16, 17);

            //MtxVec.FreeIt(ref a, ref b);

            expr = new TMtxExpression();

            richTextBoxResult.SuspendLayout();
            dataGridViewVariables.SuspendLayout();
            try
            {
                richTextBoxResult.Clear();

                textBox1.Text = "clear";
                EvaluateExpression();

                textBox1.Text = "help";
                EvaluateExpression();
                
                textBox1.Text = "j = -2";
                EvaluateExpression();

                textBox1.Text = "x = j + 10:15";
                EvaluateExpression();

                textBox1.Text = "x = x(:)";
                EvaluateExpression();

                textBox1.Text = "y = double(x)";
                EvaluateExpression();

                textBox1.Text = "m = y(0:2)'*y(2:-1:0)";
                EvaluateExpression();

                textBox1.Text = "m'";
                EvaluateExpression();

                textBox1.Text = "rows(m)";
                EvaluateExpression();

                textBox1.Text = "length(x)";
                EvaluateExpression();

                textBox1.Text = "m(0:2) = 2:-1:0";
                EvaluateExpression();

                textBox1.Text = "b = m\\y(0:2)";
                EvaluateExpression();

                textBox1.Text = "m*b'";
                EvaluateExpression();

                textBox1.Text = "c = fft(b)";
                EvaluateExpression();
            }
            finally
            {
                richTextBoxResult.ResumeLayout();
                dataGridViewVariables.ResumeLayout();
            }

            textBox1.Text = "m*b'";  
           
        }

        private TMtxExpression expr;

        private SplitContainer splitContainer1;
        private TextBox textBox1;
        private RichTextBox richTextBoxResult;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private ListBox listBoxHistory;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private DataGridView dataGridViewVariables;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
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

        void UpdateVariablesView()
        {
            dataGridViewVariables.Rows.Clear();
            TStrings varNames = new TStringList();
            expr.GetVarList(varNames);

            TValueRec aVar;

            for (int t = 0; t < varNames.Count; t++)
            {
                aVar = expr.VarByName[varNames[t]];
                string[] objstr = new string[3];
                objstr[0] = varNames[t];

                switch (aVar.ValueType)
                {
                    case vtString: objstr[1] = "string" ; break;
                    case vtDoubleValue: objstr[1] = "double" ; break;
                    case vtIntegerValue: objstr[1] = "integer"; break;
                    case vtRangeValue: objstr[1] = "range"; break;
                    case vtBoolValue:    objstr[1] = "boolean"; break;
                    case vtComplexValue: objstr[1] = "complex" ; break;
                    case vtVectorValue: objstr[1] = "vector" ; break;
                    case vtMatrixValue: objstr[1] = "matrix" ; break;
                    case vtIntVectorValue: objstr[1] = "int vector"; break;
                    case vtIntMatrixValue: objstr[1] = "int matrix"; break;
                    case vtBoolVectorValue: objstr[1] = "bool vector"; break;
                    case vtBoolMatrixValue: objstr[1] = "bool matrix"; break;
                    default: objstr[1] = "undefined"; break;
                }

                switch (aVar.ValueType)
                {
                    case vtString: objstr[2] = aVar.StringValue; break;
                    case vtDoubleValue: objstr[2] = Math387.SampleToStr(aVar.DoubleValue,5,5); break;
                    case vtIntegerValue: objstr[2] = aVar.IntegerValue.ToString(); break;
                    case vtRangeValue: if (aVar.ExtRange)
                                                  {
                                                    switch (aVar.ExtRangeValue.Length)
                                                    {
                                                        case 2: objstr[2] = Math387.SampleToStr(aVar.ExtRangeValue[0]) + ":" + Math387.SampleToStr(aVar.ExtRangeValue[1]); break;
                                                        case 3: objstr[2] = Math387.SampleToStr(aVar.ExtRangeValue[0]) + ":" + Math387.SampleToStr(aVar.ExtRangeValue[1]) + ":" + Math387.SampleToStr(aVar.ExtRangeValue[2]); break;
                                                    }
                                                  }
                                                  else
                                                  {
                                                    switch (aVar.fRange.Length)
                                                    {
                                                        case 2: objstr[2] = aVar.fRange[0].ToString() + ":" + aVar.fRange[1].ToString(); break;
                                                        case 3: objstr[2] = aVar.fRange[0].ToString() + ":" + aVar.fRange[1].ToString() + ":" + aVar.fRange[2].ToString(); break;
                                                    }
                                                  }; break;                                                    
                    case vtBoolValue: objstr[1] = aVar.BoolValue.ToString(); break;
                    case vtComplexValue: objstr[2] = Math387.CplxToStr(aVar.ComplexValue,5,5); break;
                    case vtVectorValue: objstr[2] = aVar.VectorValue.Length.ToString() + " x 1"; break;
                    case vtMatrixValue: objstr[2] = aVar.MatrixValue.Rows.ToString() + " x " + aVar.MatrixValue.Cols.ToString(); break;
                    case vtIntVectorValue: objstr[2] = aVar.IntVectorValue.Length.ToString() + " x 1"; break;
                    case vtIntMatrixValue: objstr[2] = aVar.IntMatrixValue.Rows.ToString() + " x " + aVar.IntMatrixValue.Cols.ToString(); break;
                    case vtBoolVectorValue: objstr[2] = aVar.BoolVectorValue.Length.ToString() + " x 1"; break;
                    case vtBoolMatrixValue: objstr[2] = aVar.BoolMatrixValue.Rows.ToString() + " x " + aVar.BoolMatrixValue.Cols.ToString(); break;
                    default: objstr[2] = ""; break;
                }
                
                dataGridViewVariables.Rows.Add(new object[3] { objstr[0],objstr[1],objstr[2]});
           }
       }

        void EvaluateExpression()
        {
            int i; 
            TValueRec a;
            TStringList funcList = new TStringList();
            TStringList hlpList = new TStringList();
            TStringList valList = new TStringList();
            valList.LineBreak = "\n";

            expr.ClearExpressions();
            string Cmd = textBox1.Text.Trim().ToLower();
            if (Cmd == "cls")
            {
                richTextBoxResult.Clear();
                return;
            }
            else if (Cmd == "clear")
            {
                expr.ClearAll();
                richTextBoxResult.Clear();
                listBoxHistory.Items.Clear();
                dataGridViewVariables.Rows.Clear();
                return;
            }
            else if (Cmd == "help")
            {
                expr.GetFuncList(funcList, hlpList, true);
                richTextBoxResult.AppendText("\nFunction listing:\n");
                richTextBoxResult.AppendText("\n");
                for (i = 0; i < hlpList.Count; i++) 
                {
                    richTextBoxResult.AppendText(hlpList[i] + "\n");
                }

                expr.GetOperList(funcList, hlpList);
                richTextBoxResult.AppendText("\nOperator listing:\n");
                richTextBoxResult.AppendText("\n");
                for (i = 0; i < hlpList.Count; i++) 
                {
                    richTextBoxResult.AppendText(hlpList[i] + "\n");
                }

                if (textBox1.Text != null)
                {
                    int selIndex = listBoxHistory.Items.IndexOf(textBox1.Text);
                    if (selIndex == -1)
                    {
                        selIndex = listBoxHistory.Items.Add(textBox1.Text);
                        listBoxHistory.SelectedIndex = selIndex;
                    }
                    textBox1.Text = "";
                }

                return;
            }

            try
            {
                expr.AddExpr(textBox1.Text);
                a = expr.Evaluate();
                richTextBoxResult.AppendText("\n> " + textBox1.Text + "\n");
            }
            catch (Exception e)
            {
                richTextBoxResult.AppendText("\n> " + textBox1.Text + "\n");
                richTextBoxResult.AppendText("\n " + e.Message + "\n");
                return;
            }

            if (textBox1.Text != null)
            {
                int selIndex = listBoxHistory.Items.IndexOf(textBox1.Text);
                if (selIndex == -1)
                {
                    selIndex = listBoxHistory.Items.Add(textBox1.Text);
                    listBoxHistory.SelectedIndex = selIndex;
                }
                textBox1.Text = "";
            }

            UpdateVariablesView();
            string aName = expr.EvaluatedVarName(0);

            richTextBoxResult.AppendText("\n");
            switch (a.ValueType)
            {
                case vtUndefined: richTextBoxResult.AppendText("Result type is undefined."); break;
                case vtDoubleValue: richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int) a.ValueType] +  ") = " + Math387.SampleToStr(a.DoubleValue)); break;
                case vtIntegerValue: richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = " + a.IntegerValue.ToString()); break;
                case vtComplexValue: richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = " + Math387.CplxToStr(a.ComplexValue, 0, 7)); break;
                case vtRangeValue: if (a.ExtRange)
                                              {
                                                  switch (a.ExtRangeValue.Length) 
                                                  {
                                                  case 2: richTextBoxResult.AppendText(aName + "(range) = " + Math387.SampleToStr(a.ExtRangeValue[0]) + ":" + Math387.SampleToStr(a.ExtRangeValue[1])); break;
                                                  case 3: richTextBoxResult.AppendText(aName + "(range) = " + Math387.SampleToStr(a.ExtRangeValue[0]) + ":" + Math387.SampleToStr(a.ExtRangeValue[1]) + ":" + Math387.SampleToStr(a.ExtRangeValue[2])); break;
                                                  }
                                              } else
                                              {
                                                  switch (a.fRange.Length)
                                                  {
                                                  case 2: richTextBoxResult.AppendText(aName + "(range) = " + a.fRange[0].ToString() + ":" + a.fRange[1].ToString()); break;
                                                  case 3: richTextBoxResult.AppendText(aName + "(range) = " + a.fRange[0].ToString() + ":" + a.fRange[1].ToString() + ":" + a.fRange[2].ToString()); break;
                                                  }
                                               }; break; 
                case vtString: richTextBoxResult.Text += aName + "(" + MtxParseClass.ValTypeAsStr[(int) a.ValueType] +  ") = " +  a.StringValue; break;
                case vtBoolValue: richTextBoxResult.Text += aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = " + a.BoolValue.ToString(); break;
                case vtVectorValue:
                    {
                        a.VectorValue.ValuesToStrings( valList, TFixedTextAlign.ftaRightAlign, "0.0000", "+0.0000i;-0.0000i", true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
                case vtMatrixValue:
                    {
                        a.MatrixValue.ValuesToStrings(valList, "\t", TFixedTextAlign.ftaRightAlign, "0.0000", "+0.0000i;-0.0000i", true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
                case vtIntVectorValue:
                    {
                        a.IntVectorValue.ValuesToStrings(valList, TFixedTextAlign.ftaNone, true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
                case vtIntMatrixValue:
                    {
                        a.IntMatrixValue.ValuesToStrings(valList, "\t", TFixedTextAlign.ftaRightAlign, true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
                case vtBoolVectorValue:
                    {
                        a.BoolVectorValue.ValuesToStrings(valList, TFixedTextAlign.ftaRightAlign, true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
                case vtBoolMatrixValue:
                    {
                        a.BoolMatrixValue.ValuesToStrings(valList, "\t", TFixedTextAlign.ftaRightAlign, true, -1);
                        richTextBoxResult.AppendText(aName + "(" + MtxParseClass.ValTypeAsStr[(int)a.ValueType] + ") = \n\n" + valList.Text);
                    } break;
            }
            richTextBoxResult.AppendText("\n\n");
            richTextBoxResult.ScrollToCaret();

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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxHistory = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVariables = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit(); //only framework v4 or newer
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout(); 
            this.panel4.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).BeginInit(); //only framework v4 or newer
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxHistory);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewVariables);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxResult);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(572, 434);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxHistory
            // 
            this.listBoxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHistory.FormattingEnabled = true;
            this.listBoxHistory.Location = new System.Drawing.Point(0, 201);
            this.listBoxHistory.Name = "listBoxHistory";
            this.listBoxHistory.Size = new System.Drawing.Size(189, 233);
            this.listBoxHistory.TabIndex = 1;
            this.toolTip2.SetToolTip(this.listBoxHistory, "Double click to select command");
            this.listBoxHistory.DoubleClick += new System.EventHandler(this.listBoxHistory_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 175);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 26);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command history";
            // 
            // dataGridViewVariables
            // 
            this.dataGridViewVariables.AllowUserToAddRows = false;
            this.dataGridViewVariables.AllowUserToDeleteRows = false;
            this.dataGridViewVariables.AllowUserToResizeColumns = false;
            this.dataGridViewVariables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.dataGridViewVariables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridViewVariables.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewVariables.Location = new System.Drawing.Point(0, 15);
            this.dataGridViewVariables.Name = "dataGridViewVariables";
            this.dataGridViewVariables.ReadOnly = true;
            this.dataGridViewVariables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewVariables.RowHeadersVisible = false;
            this.dataGridViewVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVariables.ShowEditingIcon = false;
            this.dataGridViewVariables.Size = new System.Drawing.Size(189, 160);
            this.dataGridViewVariables.TabIndex = 1;
            this.dataGridViewVariables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVariables_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 60;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(189, 15);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Workspace variables";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.Color.FloralWhite;
            this.richTextBoxResult.DetectUrls = false;
            this.richTextBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxResult.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxResult.ShortcutsEnabled = false;
            this.richTextBoxResult.Size = new System.Drawing.Size(379, 414);
            this.richTextBoxResult.TabIndex = 0;
            this.richTextBoxResult.Text = "";
            this.richTextBoxResult.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 414);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.UseFading = false;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 100;
            this.toolTip2.AutoPopDelay = 5000;
            this.toolTip2.InitialDelay = 100;
            this.toolTip2.ReshowDelay = 20;
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.UseFading = false;
            // 
            // Scripting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 434);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Scripting";
            this.Text = "Scripting";
            this.Load += new System.EventHandler(this.Scripting_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            //((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void listBoxHistory_DoubleClick(object sender, EventArgs e)
        {
            if(listBoxHistory.SelectedItem !=null)
            {
                textBox1.Text = listBoxHistory.SelectedItem.ToString();
                EvaluateExpression();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int i = listBoxHistory.SelectedIndex;

            if (e.KeyCode == Keys.Up && textBox1.Text != null)
            {
                if (i > 0) i--;
                if (i > -1)
                {
                    listBoxHistory.SelectedIndex = i;
                    textBox1.Text = listBoxHistory.SelectedItem.ToString();
                }
            }
            else if (e.KeyCode == Keys.Down && textBox1.Text != null)
            {
                if (i < listBoxHistory.Items.Count - 1) i++;
                if (i > -1)
                {
                    listBoxHistory.SelectedIndex = i;
                    textBox1.Text = listBoxHistory.SelectedItem.ToString();
                }
            }
            else if (e.KeyCode == Keys.Return) EvaluateExpression();
        }

        private void Scripting_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewVariables.Rows[e.RowIndex]!=null)
            {
                string avn = dataGridViewVariables.Rows[e.RowIndex].Cells[0].Value.ToString();
                TValueRec aVar = expr.VarByName[avn];
                Dew.Math.Editors.VariableEditor editor = new Dew.Math.Editors.VariableEditor();
                editor.Text = "Editing " + avn;
                editor.Execute(aVar);
                UpdateVariablesView();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}