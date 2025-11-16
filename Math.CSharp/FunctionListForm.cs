using System;
using System.IO;
using System.Drawing;
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for FunctionList.
	/// </summary>
	public class FunctionListForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBoxFilter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.DataGridView dataGrid1;
		//private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTextBoxColumn2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FunctionListForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			createDataTable();
			loadFunctions();
			displayFunctions();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            labelTotal = new Label();
            buttonClear = new Button();
            label1 = new Label();
            textBoxFilter = new TextBox();
            dataGrid1 = new DataGridView();
            dataGridTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridTextBoxColumn2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((ISupportInitialize)dataGrid1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTotal);
            panel1.Controls.Add(buttonClear);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 89);
            panel1.TabIndex = 0;
            // 
            // labelTotal
            // 
            labelTotal.Location = new Point(10, 59);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(345, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Total : ";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(269, 30);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(90, 28);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Clear";
            buttonClear.Click += buttonClear_Click;
            // 
            // label1
            // 
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Filter";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(10, 30);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(249, 23);
            textBoxFilter.TabIndex = 0;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // dataGrid1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid1.Columns.AddRange(new DataGridViewColumn[] { dataGridTextBoxColumn1, dataGridTextBoxColumn2 });
            dataGrid1.Dock = DockStyle.Fill;
            dataGrid1.Location = new Point(0, 89);
            dataGrid1.Name = "dataGrid1";
            dataGrid1.ReadOnly = true;
            dataGrid1.RowHeadersVisible = false;
            dataGrid1.Size = new Size(869, 519);
            dataGrid1.TabIndex = 1;
            // 
            // dataGridTextBoxColumn1
            // 
            dataGridTextBoxColumn1.DataPropertyName = "Name";
            dataGridTextBoxColumn1.HeaderText = "Name";
            dataGridTextBoxColumn1.Name = "dataGridTextBoxColumn1";
            dataGridTextBoxColumn1.ReadOnly = true;
            dataGridTextBoxColumn1.Width = 250;
            // 
            // dataGridTextBoxColumn2
            // 
            dataGridTextBoxColumn2.DataPropertyName = "Description";
            dataGridTextBoxColumn2.HeaderText = "Description";
            dataGridTextBoxColumn2.Name = "dataGridTextBoxColumn2";
            dataGridTextBoxColumn2.ReadOnly = true;
            dataGridTextBoxColumn2.Width = 500;
            // 
            // FunctionListForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(869, 608);
            Controls.Add(dataGrid1);
            Controls.Add(panel1);
            Name = "FunctionListForm";
            Text = "FunctionList";
            Load += FunctionListForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((ISupportInitialize)dataGrid1).EndInit();
            ResumeLayout(false);

        }
        #endregion

        DataTable functions;
		private void createDataTable() {
			functions = new DataTable();
			functions.Columns.Add("Name",typeof(String));
			functions.Columns.Add("Description",typeof(String));
		}
		private void loadFunctions() {
			using (StreamReader sr = new StreamReader(Utils.SourcePath()+@".\Data\List_Functions.txt")) {
				String line;
				while ((line = sr.ReadLine()) != null) {
					String[] values = line.Split(new char[]{'\t'});
					functions.Rows.Add(values);
				}
			}
			labelTotal.Text = "Functions list : " + functions.Rows.Count + " items, not counting overloads";
		}
		private void displayFunctions() {
			
			dataGrid1.DataSource = functions;
		}

		private void FunctionListForm_Load(object sender, System.EventArgs e) {
		
		}

		private void textBoxFilter_TextChanged(object sender, System.EventArgs e) {
			if (textBoxFilter.Text.Equals("")) {
				functions.DefaultView.RowFilter = "";
				labelTotal.Text = "Functions list : " + functions.Rows.Count + " items, not counting overloads";
			}
			else {
				functions.DefaultView.RowFilter = "Name LIKE '*" +textBoxFilter.Text+ 
					"*' OR Description LIKE '*" + textBoxFilter.Text + "*'";
				labelTotal.Text = "Functions list : " + functions.DefaultView.Count + " items found";
			}
		}

		private void buttonClear_Click(object sender, System.EventArgs e) {
			textBoxFilter.Text = "";
		}
	}
}
