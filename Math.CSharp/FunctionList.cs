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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 89);
            this.panel1.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(10, 59);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(345, 20);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total : ";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(269, 30);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 28);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(10, 30);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(249, 23);
            this.textBoxFilter.TabIndex = 0;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // dataGrid1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;

            this.dataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2});
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.Location = new System.Drawing.Point(0, 89);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.RowHeadersVisible = false;
            this.dataGrid1.Size = new System.Drawing.Size(869, 475);
            this.dataGrid1.TabIndex = 1;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridTextBoxColumn1.HeaderText = "Name";
            this.dataGridTextBoxColumn1.Name = "dataGridTextBoxColumn1";
            this.dataGridTextBoxColumn1.ReadOnly = true;
            this.dataGridTextBoxColumn1.Width = 250;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridTextBoxColumn2.HeaderText = "Description";
            this.dataGridTextBoxColumn2.Name = "dataGridTextBoxColumn2";
            this.dataGridTextBoxColumn2.ReadOnly = true;
            this.dataGridTextBoxColumn2.Width = 500;
            // 
            // FunctionListForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(869, 564);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.panel1);
            this.Name = "FunctionListForm";
            this.Text = "FunctionList";
            this.Load += new System.EventHandler(this.FunctionListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

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
