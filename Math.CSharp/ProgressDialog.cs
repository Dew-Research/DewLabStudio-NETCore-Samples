using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo
{
	public class ProgressDialogForm : MtxVecDemo.BasicForm2
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.NumericUpDown numericUpDown3;
        private Dew.Math.Controls.ProgressDialog progressDialog1;
		private System.ComponentModel.IContainer components = null;

		public ProgressDialogForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			progressDialog1.DefineLoop(0,1500);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
            if (progressDialog1 != null) progressDialog1.Stop();
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressDialog1 = new Dew.Math.Controls.ProgressDialog();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Size = new System.Drawing.Size(746, 363);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 533);
            this.panel3.Size = new System.Drawing.Size(746, 73);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(746, 170);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iterator control";
            // 
            // radioButton1
            // 
            this.radioButton1.Checked = true;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(10, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Internal loop";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(10, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(124, 20);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "External loop";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(10, 59);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(124, 20);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.Text = "InProcedure";
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(173, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 88);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loop type";
            // 
            // radioButton4
            // 
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton4.Location = new System.Drawing.Point(10, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(124, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "For loop";
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.Checked = true;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton5.Location = new System.Drawing.Point(10, 59);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(124, 20);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "While loop";
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(326, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Progress indicator";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(326, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(212, 19);
            this.progressBar1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(10, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(240, 30);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show progress form";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Thread priority";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Items.AddRange(new object[] {
            "Lowest",
            "Below normal",
            "Normal",
            "Above normal",
            "Highest"});
            this.comboBox1.Location = new System.Drawing.Point(10, 167);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress indicator update  interval";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(10, 226);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 23);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(154, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ms";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(10, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 64);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loop range";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(182, 25);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 23);
            this.numericUpDown3.TabIndex = 2;
            this.numericUpDown3.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(58, 25);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(67, 23);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(139, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "To";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(293, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressDialog1
            // 
            this.progressDialog1.BlockAssign = false;
            this.progressDialog1.InfiniteLoop = false;
            this.progressDialog1.Max = 0;
            this.progressDialog1.Min = 0;
            this.progressDialog1.Name = null;
            this.progressDialog1.ShowDialog = false;
            this.progressDialog1.ThreadBypass = false;
            this.progressDialog1.ThreadName = "Test thread";
            this.progressDialog1.Compute += new EventHandler(this.progressDialog1_Compute);
            this.progressDialog1.ProgressUpdate += new Dew.Math.Controls.UpdateEventHandler(this.progressDialog1_ProgressUpdate);
            // 
            // ProgressDialogForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(746, 606);
            this.Name = "ProgressDialogForm";
            this.Load += new System.EventHandler(this.ProgressDialogForm_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion
		
		private TMtx a,b,c;

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e) 
        {
			progressDialog1.ShowDialog = checkBox1.Checked;
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e) 
        {
            progressDialog1.InfiniteLoop = radioButton4.Checked;
		}

        private void button1_Click(object sender, System.EventArgs e) {
			if (button1.Text.Equals("Start")) {
				button1.Text = "Stop";
				progressDialog1.Start();
			} else {
				progressDialog1.Cancel = true;
				button1.Text = "Start";
			}
			// Sequence of calls:
			//   1. Calls  MtxThread OnProgressUpdate event with peInit (non threaded)
			//   2. Calls  OnCompute once or more times depending of InternalLoop (threaded)
			//   3. Calls  MtxThread OnProgressUpdate event with peCycle in
			//      regular intervals to advance progress indicators. (non threaded)
			//   4. Calls MtxThread OnProgressUpdate event with peCleanUp to
			//      continue with the further processing of the processed data,
			//      once the the thread has finished. (non threaded)
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e) 
        {
            progressDialog1.Priority = (System.Threading.ThreadPriority)comboBox1.SelectedIndex;
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e) {
			progressDialog1.UpdateInterval = (int)numericUpDown1.Value;
		}

		private void numericUpDown2_ValueChanged(object sender, System.EventArgs e) 
        {
		    progressDialog1.Min = (int)numericUpDown2.Value;
		}

		private void numericUpDown3_ValueChanged(object sender, System.EventArgs e) 
        {
			progressDialog1.Max = (int)numericUpDown3.Value;
		}

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e) {
            progressDialog1.InternalLoop = radioButton1.Checked;
		}

        private void ProgressDialogForm_Load(object sender, System.EventArgs e) {
			Add("MtxVec 1.5 introduces new ProgressDialog control. "
				+ "The ProgressDialog control greatly simplifies "
				+ "the threading of numerical algorithms and offers "
				+ "built-in support to cancel the execution of algorithms "
				+ "running in it's thread, provide information about the "
				+ "progress of the executing numerical algorithm and even "
				+ "display progress dialog showing progress indications "
				+ "updated with user defined update frequency. Control "
				+ "design does not use the Synchronize procedure to update "
				+ "progress indicators and makes the most out of the "
				+ "available CPU power.");
            comboBox1.SelectedIndex = 2;
        }

        private void whileLoopInProcedure() 
        {
            while (!(progressDialog1.Max == progressDialog1.Counter)) 
            {
                if (progressDialog1.Cancel) break;
				c.Mul(a,b);
				progressDialog1.Counter++;
			}
		}

        private void progressDialog1_Compute(object sender, EventArgs e)
        {
            if (radioButton1.Checked) { c.Mul(a, b); }
            else if (radioButton2.Checked)
            {
                for (int i = progressDialog1.Min; i <= progressDialog1.Max; i++)
                {
                    progressDialog1.Counter = i;
                    if (progressDialog1.Cancel) break;
                    c.Mul(a, b);
                }
            }
            else if (radioButton3.Checked)
            {
                whileLoopInProcedure();
            }
        }

        private void progressDialog1_ProgressUpdate(object sender, Dew.Math.Controls.MtxProgressEvent e)
        {
            switch (e)
            {
                case Dew.Math.Controls.MtxProgressEvent.peInit :
                    {
                        progressDialog1.DefineProgressBar(progressBar1);
                        progressBar1.Minimum = progressDialog1.Min;
                        progressBar1.Maximum = progressDialog1.Max;
                        progressBar1.Value = 0;
                        MtxVec.CreateIt(out a, out b, out c);
                        a.Size(100, 100);
                        a.RandGauss();
                        b.Copy(a);

                    };break;
                case Dew.Math.Controls.MtxProgressEvent.peCycle:
                    {
                        progressBar1.Value = progressDialog1.Counter;
                        label1.Text = "Progress indicator : " +
                        (progressDialog1.Counter * 100 / progressDialog1.Max).ToString() + " %";
                    }; break;
                case Dew.Math.Controls.MtxProgressEvent.peCleanUp:
                    {
                        if (!progressDialog1.Cancel)
                        {
                            progressBar1.Value = progressDialog1.Max;
                            label1.Text = "Progress indicator : 100 %";
                        }
                        MtxVec.FreeIt(ref a, ref b, ref c);
                    } ; break;
            }
        }
	}
}

