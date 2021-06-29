using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Units;
using Dew.Stats.Units;
using Dew.Math;
using Dew.Math.Editors;

namespace StatsMasterDemo
{
	public class ItemAnalysis : StatsMasterDemo.BasicForm2
	{
		public ItemAnalysis()
		{
			InitializeComponent();
            Data = new Matrix(0, 0);
            v1 = new Vector(0);
            m1 = new Matrix(0, 0);
		}

		public Matrix Data;
		private Vector v1;
		private Matrix m1;
		private string formatstring = "0.0000";

		private RichTextBox richTextBox2;
		private Panel panel3;
		private GroupBox groupBox1;
		private Label label2;
		private Label label1;
		private Button button1;
		private GroupBox groupBox2;
		private CheckBox checkBox5;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Button button2;

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
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Size = new System.Drawing.Size(729, 413);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(729, 138);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 413);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(22, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Report";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox5);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(12, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 163);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // checkBox5
            // 
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox5.Location = new System.Drawing.Point(16, 128);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(112, 16);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "Covariance";
            // 
            // checkBox4
            // 
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox4.Location = new System.Drawing.Point(16, 105);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(112, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Correlation";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox3.Location = new System.Drawing.Point(17, 82);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(111, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Item details";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(17, 59);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Distribution";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(17, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Reliability";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(17, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Edit";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox2.Location = new System.Drawing.Point(166, 0);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(563, 413);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // ItemAnalysis
            // 
            this.ClientSize = new System.Drawing.Size(729, 551);
            this.Name = "ItemAnalysis";
            this.Load += new System.EventHandler(this.ItemAnalysis_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private void ItemAnalysis_Load(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			richTextBox1.SelectedText += "Item analysis studies the internal reliability of a particular object. "
				+ "This object usually consists of several items which are answered by a group of respondents. "
				+ "Issues that arise include whether the object measures what was intended, whether it produces "
				+ "the same results when it is administered repeatedly, whether it contains cultural biases, and "
				+ "so on.\n\nThis example performs item analysis on collected data. In the example 16 subject "
				+ "answered 4 items questionare.";
			Data.SetIt(16, 4, false, new double[] {	1, 3,	2, 1,
													  2, 2, 2, 3,
													  1, 3,	2, 2,
													  3, 3,	3, 3,   
													  1, 1, 2, 2,
													  3, 3, 3, 1, 
													  2, 2, 1, 2,
													  1, 1, 2, 1,
													  1, 3,	1, 2,
													  1, 1,	2, 2,
													  5, 3,	2, 2,
													  1, 1,	2, 1,
													  1, 3,	2, 2,
													  1, 3,	3, 1,
													  1, 3,	2, 1,
													  1, 3,	1, 1 });
			UpdateGUI();
            TextReport();
		}

		private void UpdateGUI()
		{
			label1.Text = "Rows: "+Data.Rows.ToString();
			label2.Text = "Items: " + Data.Cols.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MtxVecEdit.ViewValues(Data,"Viewing data...",true,false,true);
			UpdateGUI();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			TextReport();
		}

		private void ReliabilityReport()
		{
			string st;
			richTextBox2.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
			richTextBox2.SelectedText = "Reliability\n\n";
			richTextBox2.SelectionColor = Color.Blue;
			richTextBox2.SelectedText = "\t\t\tMean if\tStd if\tAlpha if\nColumn\tMean\tStd\tdeleted\tdeleted\tdeleted\n";
			for (int i=0;i<Data.Cols; i++)
			{
				v1.GetCol(Data,i);
				st = i.ToString()+"\t"+Math387.FormatSample(formatstring,v1.Mean())+"\t"+Math387.FormatSample(formatstring,v1.StdDev())+"\t";
				// Do stats on the remaining data
				Statistics.RemoveColumn(Data,m1,i);
				// Total sum (without ommited item)
				st +=  Math387.FormatSample(formatstring,v1.Sum())+"\t"+Math387.FormatSample(formatstring,m1.StdDev())+"\t";
				st +=  Math387.FormatSample(formatstring,Statistics.CronbachAlpha(m1))+"\n";
				richTextBox2.SelectedText = st;
			}
			// Regular Cronbach Alpha
			richTextBox2.SelectedText = "\nCronbach alpha: " + Math387.FormatSample(formatstring,Statistics.CronbachAlpha(Data))+"\n";
			// Z-scored Cronbach Alpha
            m1.ZScore(Data);
			richTextBox2.SelectedText = "Standardized Cronbach alpha: " + Math387.FormatSample(formatstring,Statistics.CronbachAlpha(m1))+"\n\n";
		}

		private void DistReport()
		{
			Vector vars = new Vector(0);
            Vector wrk1 = new Vector(0);
            Vector wrk2 = new Vector(0);
            richTextBox2.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
			richTextBox2.SelectedText = "Distribution count\n\n";
			Statistics.Unique(Data,vars,null);
			string st = "Variable\t";
			for (int t=0; t<vars.Length; t++)
				st += Math387.FormatSample("0.0",vars.Values[t])+"\t";
			richTextBox2.SelectionColor = Color.Blue;
			richTextBox2.SelectedText = st+"\n";
			
            for (int t=0; t<Data.Cols; t++)
			{
				wrk1.GetCol(Data,t);
				st = "Column " + t.ToString()+"\t";
				for (int j=0; j<vars.Length; j++)
				{
					wrk2.FindAndGather(wrk1,"=",vars.Values[j],null);
					st += wrk2.Length.ToString()+"\t";
				}
				richTextBox2.SelectedText = st+"\n";
			}
			st = "Total\t";
			for (int t = 0; t<vars.Length; t++)
			{
				wrk2.FindAndGather(Data,"=",vars.Values[t],null);
				st += wrk2.Length.ToString()+"\t";
			}
			richTextBox2.SelectedText = st+"\n\n";
		}

		private void ItemDetailReport(TVec itemdata, TVec vars, TVec wrk1)
		{
			int total = 0;
			string st = "";
			for (int i=0; i<vars.Length; i++)
			{
				wrk1.FindAndGather(itemdata,"=",vars.Values[i],null);
				total += wrk1.Length;
				st = Math387.FormatSample("0.0",vars.Values[i])+"\t"+wrk1.Length.ToString()+"\t";
				st += Math387.FormatSample("0.0",100.0*wrk1.Length/(double)itemdata.Length)+"\t";
				st += Math387.FormatSample("0.0",100.0*total/(double)itemdata.Length)+"\n";
				richTextBox2.SelectedText = st;
			}
		}

		private void DetailReport()
		{
			Vector vars = new Vector(0);
            Vector wrk1 = new Vector(0);
            Vector wrk2 = new Vector(0);
			richTextBox2.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
			richTextBox2.SelectedText = "Item details\n\n";
			Statistics.Unique(Data,vars,null); // get unique values for variables
			for (int i=0; i<Data.Cols; i++)
			{
				wrk1.GetCol(Data,i);
				richTextBox2.SelectedText = "Details for column :"+i.ToString()+"\n";
				richTextBox2.SelectionColor = Color.Blue;
				richTextBox2.SelectedText = "Value\tCount\tPct.\tCumulative pct.\n";
				ItemDetailReport(wrk1,vars,wrk2);
				richTextBox2.SelectedText = "\n";
			}
			richTextBox2.SelectedText = "\n";
		}

        private void CorrReport()
        {
            richTextBox2.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox2.SelectedText = "Correlations\n\n";
            Statistics.CorrCoef(Data,m1);
            string txt = m1.ValuesToText("\t", formatstring, formatstring);
            richTextBox2.SelectedText = txt+"\nCells represent correlations between pairs of items.\n\n";
        }

        private void CovReport()
        {
            richTextBox2.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 10, FontStyle.Underline);
            richTextBox2.SelectedText = "Covariances\n\n";
            Statistics.Covariance(Data, m1,false);
            string txt = m1.ValuesToText("\t", formatstring, formatstring);
            richTextBox2.SelectedText = txt + "\nCells represent covariances between pairs of items.\n\n";
        }

        private void TextReport()
        {
            richTextBox2.Clear();
            if (checkBox1.Checked) ReliabilityReport();
			if (checkBox2.Checked) DistReport();
			if (checkBox3.Checked) DetailReport();
            if (checkBox4.Checked) CorrReport();
            if (checkBox5.Checked) CovReport();		
		}
    }
}

