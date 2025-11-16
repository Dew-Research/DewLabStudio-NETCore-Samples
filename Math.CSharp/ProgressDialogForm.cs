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
		private System.Windows.Forms.RadioButton InternalLoopButton;
		private System.Windows.Forms.RadioButton ExternalLoopButton;
		private System.Windows.Forms.RadioButton InProcedureButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton ForLoopButton;
		private System.Windows.Forms.RadioButton WhileLoopButton;
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
        private Dew.Math.Controls.TMtxProgressDialog progressDialog1;
		private System.ComponentModel.IContainer components = null;

		public ProgressDialogForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			progressDialog1.DefineLoop(0,1500);
            progressDialog1.InfiniteLoop = true;
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
            this.InternalLoopButton = new System.Windows.Forms.RadioButton();
            this.ExternalLoopButton = new System.Windows.Forms.RadioButton();
            this.InProcedureButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ForLoopButton = new System.Windows.Forms.RadioButton();
            this.WhileLoopButton = new System.Windows.Forms.RadioButton();
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
            this.progressDialog1 = new Dew.Math.Controls.TMtxProgressDialog();
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
            this.panel2.Size = new System.Drawing.Size(986, 439);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 551);
            this.panel3.Size = new System.Drawing.Size(986, 48);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Size = new System.Drawing.Size(986, 112);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InternalLoopButton);
            this.groupBox1.Controls.Add(this.ExternalLoopButton);
            this.groupBox1.Controls.Add(this.InProcedureButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Iterator control";
            // 
            // InternalLoopButton
            // 
            this.InternalLoopButton.Checked = true;
            this.InternalLoopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InternalLoopButton.Location = new System.Drawing.Point(8, 16);
            this.InternalLoopButton.Name = "InternalLoopButton";
            this.InternalLoopButton.Size = new System.Drawing.Size(104, 16);
            this.InternalLoopButton.TabIndex = 0;
            this.InternalLoopButton.TabStop = true;
            this.InternalLoopButton.Text = "Internal loop";
            this.InternalLoopButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ExternalLoopButton
            // 
            this.ExternalLoopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExternalLoopButton.Location = new System.Drawing.Point(8, 38);
            this.ExternalLoopButton.Name = "ExternalLoopButton";
            this.ExternalLoopButton.Size = new System.Drawing.Size(104, 16);
            this.ExternalLoopButton.TabIndex = 0;
            this.ExternalLoopButton.Text = "External loop";
            this.ExternalLoopButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // InProcedureButton
            // 
            this.InProcedureButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InProcedureButton.Location = new System.Drawing.Point(8, 61);
            this.InProcedureButton.Name = "InProcedureButton";
            this.InProcedureButton.Size = new System.Drawing.Size(104, 16);
            this.InProcedureButton.TabIndex = 0;
            this.InProcedureButton.Text = "InProcedure";
            this.InProcedureButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ForLoopButton);
            this.groupBox2.Controls.Add(this.WhileLoopButton);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(148, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 66);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loop type";
            // 
            // ForLoopButton
            // 
            this.ForLoopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ForLoopButton.Location = new System.Drawing.Point(10, 19);
            this.ForLoopButton.Name = "ForLoopButton";
            this.ForLoopButton.Size = new System.Drawing.Size(104, 16);
            this.ForLoopButton.TabIndex = 0;
            this.ForLoopButton.Text = "For loop";
            this.ForLoopButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // WhileLoopButton
            // 
            this.WhileLoopButton.Checked = true;
            this.WhileLoopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.WhileLoopButton.Location = new System.Drawing.Point(10, 41);
            this.WhileLoopButton.Name = "WhileLoopButton";
            this.WhileLoopButton.Size = new System.Drawing.Size(104, 16);
            this.WhileLoopButton.TabIndex = 0;
            this.WhileLoopButton.TabStop = true;
            this.WhileLoopButton.Text = "While loop";
            this.WhileLoopButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(299, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Progress indicator";
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(302, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(633, 27);
            this.progressBar1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(20, 105);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show progress form";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
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
            this.comboBox1.Location = new System.Drawing.Point(195, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Progress indicator update  interval";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(196, 200);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
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
            this.label4.Location = new System.Drawing.Point(333, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "ms";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.numericUpDown2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(20, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 72);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loop range";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(198, 28);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(56, 20);
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
            this.numericUpDown2.Location = new System.Drawing.Point(56, 30);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(156, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "To";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(353, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 8;
            this.button1.Text = "Start";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressDialog1
            // 
            this.progressDialog1.ShowDialog = false;
            this.progressDialog1.ThreadName = "Test thread";
            this.progressDialog1.UpdateInterval = 40;
            this.progressDialog1.Compute += new Dew.Math.TComputeEvent(this.progressDialog1_Compute);
            this.progressDialog1.ProgressUpdate += new Dew.Math.TProgressUpdateEvent(this.progressDialog1_ProgressUpdate);
            // 
            // ProgressDialogForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(986, 599);
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
            progressDialog1.InfiniteLoop = !ForLoopButton.Checked;
		}

        private void button1_Click(object sender, System.EventArgs e) 
        {
			if (button1.Text.Equals("Start")) 
            {
				button1.Text = "Stop";
				progressDialog1.Start();
			} 
            else 
            {
                progressDialog1.Stop();
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
            progressDialog1.InternalLoop = InternalLoopButton.Checked;
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
            while (!(progressDialog1.Max == progressDialog1.Counter) | progressDialog1.InfiniteLoop)
            {
                if (progressDialog1.Cancel) break;
				c.Mul(a,b);
				progressDialog1.Counter++;
			}
		}

        private void progressDialog1_Compute(object sender)
        {
            if (InternalLoopButton.Checked) { c.Mul(a, b); }
            else if (ExternalLoopButton.Checked)
            {
                if (progressDialog1.InfiniteLoop)
                {
                    int i = progressDialog1.Min;
                    while (true)
                    {
                        progressDialog1.Counter = i;
                        if (progressDialog1.Cancel) break;
                        c.Mul(a, b);
                        i++;
                    }
                }
                else
                {
                    for (int i = progressDialog1.Min; i <= progressDialog1.Max; i++)
                    {
                        progressDialog1.Counter = i;
                        if (progressDialog1.Cancel) break;
                        c.Mul(a, b);
                    }
                }
            }
            else if (InProcedureButton.Checked)
            {
                whileLoopInProcedure();
            }
        }

        private void progressDialog1_ProgressUpdate(object sender, Dew.Math.TMtxProgressEvent e)
        {
            switch (e)
            {
                case Dew.Math.TMtxProgressEvent.peInit :
                    {
                        progressDialog1.DefineProgressBar(progressBar1);
                        MtxVec.CreateIt(out a, out b, out c);
                        a.Size(300, 300);
                        a.RandGauss();
                        b.Copy(a);
                    };
                    break;
                case Dew.Math.TMtxProgressEvent.peCycle:
                    {
                        progressBar1.Value = (progressDialog1.Counter - progressDialog1.Min) % (progressDialog1.Max - progressDialog1.Min);
                        label1.Text = "Progress indicator : " +
                        (progressDialog1.Counter * 100 / progressDialog1.Max).ToString() + " %";
                    }; 
                    break;
                case Dew.Math.TMtxProgressEvent.peCleanUp:
                    {
                        if (!progressDialog1.Cancel)
                        {
                            progressBar1.Value = progressDialog1.Max;
                            label1.Text = "Progress indicator : 100 %";
                        }
                        MtxVec.FreeIt(ref a, ref b, ref c);
                        button1.Text = "Start";                      
                    };
                    break;
                
            }
        }
	}
}


