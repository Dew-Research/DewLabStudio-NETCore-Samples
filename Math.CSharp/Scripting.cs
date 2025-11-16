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
            components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            listBoxHistory = new ListBox();
            panel4 = new Panel();
            label1 = new Label();
            dataGridViewVariables = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label2 = new Label();
            richTextBoxResult = new RichTextBox();
            textBox1 = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            ((ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            ((ISupportInitialize)dataGridViewVariables).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBoxHistory);
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Controls.Add(dataGridViewVariables);
            splitContainer1.Panel1.Controls.Add(panel3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(richTextBoxResult);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Size = new Size(1014, 627);
            splitContainer1.SplitterDistance = 333;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // listBoxHistory
            // 
            listBoxHistory.Dock = DockStyle.Fill;
            listBoxHistory.FormattingEnabled = true;
            listBoxHistory.Location = new Point(0, 232);
            listBoxHistory.Margin = new Padding(4, 3, 4, 3);
            listBoxHistory.Name = "listBoxHistory";
            listBoxHistory.Size = new Size(333, 395);
            listBoxHistory.TabIndex = 1;
            toolTip2.SetToolTip(listBoxHistory, "Double click to select command");
            listBoxHistory.DoubleClick += listBoxHistory_DoubleClick;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 202);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 30);
            panel4.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Command history";
            // 
            // dataGridViewVariables
            // 
            dataGridViewVariables.AllowUserToAddRows = false;
            dataGridViewVariables.AllowUserToDeleteRows = false;
            dataGridViewVariables.AllowUserToResizeColumns = false;
            dataGridViewVariables.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 230);
            dataGridViewVariables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVariables.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewVariables.Dock = DockStyle.Top;
            dataGridViewVariables.Location = new Point(0, 17);
            dataGridViewVariables.Margin = new Padding(4, 3, 4, 3);
            dataGridViewVariables.Name = "dataGridViewVariables";
            dataGridViewVariables.ReadOnly = true;
            dataGridViewVariables.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewVariables.RowHeadersVisible = false;
            dataGridViewVariables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVariables.ShowEditingIcon = false;
            dataGridViewVariables.Size = new Size(333, 185);
            dataGridViewVariables.TabIndex = 1;
            dataGridViewVariables.CellDoubleClick += dataGridViewVariables_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.Frozen = true;
            Column1.HeaderText = "Name";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.False;
            Column1.Width = 70;
            // 
            // Column2
            // 
            Column2.Frozen = true;
            Column2.HeaderText = "Type";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Resizable = DataGridViewTriState.False;
            Column2.Width = 50;
            // 
            // Column3
            // 
            Column3.HeaderText = "Value";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.False;
            Column3.Width = 60;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 17);
            panel3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 15);
            label2.TabIndex = 0;
            label2.Text = "Workspace variables";
            // 
            // richTextBoxResult
            // 
            richTextBoxResult.BackColor = Color.FloralWhite;
            richTextBoxResult.DetectUrls = false;
            richTextBoxResult.Dock = DockStyle.Fill;
            richTextBoxResult.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBoxResult.Location = new Point(0, 0);
            richTextBoxResult.Margin = new Padding(4, 3, 4, 3);
            richTextBoxResult.Name = "richTextBoxResult";
            richTextBoxResult.ReadOnly = true;
            richTextBoxResult.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxResult.ShortcutsEnabled = false;
            richTextBoxResult.Size = new Size(676, 604);
            richTextBoxResult.TabIndex = 0;
            richTextBoxResult.Text = "";
            richTextBoxResult.WordWrap = false;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Bottom;
            textBox1.Location = new Point(0, 604);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(676, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 100;
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 20;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.UseFading = false;
            // 
            // toolTip2
            // 
            toolTip2.AutomaticDelay = 100;
            toolTip2.AutoPopDelay = 5000;
            toolTip2.InitialDelay = 100;
            toolTip2.ReshowDelay = 20;
            toolTip2.ToolTipIcon = ToolTipIcon.Info;
            toolTip2.UseFading = false;
            // 
            // Scripting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 627);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Scripting";
            Text = "Scripting";
            Load += Scripting_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((ISupportInitialize)dataGridViewVariables).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

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