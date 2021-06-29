namespace MtxVecDemo
{
    partial class clBenchmarkForm
    {
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.platformListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimingsLabel = new System.Windows.Forms.Label();
            this.deviceListLabel = new System.Windows.Forms.Label();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.functionBox = new System.Windows.Forms.ListBox();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vectorLengthBox = new System.Windows.Forms.ComboBox();
            this.vectorLengthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.floatPrecisionBox = new System.Windows.Forms.ComboBox();
            this.cpuFloatPrecisionLabel = new System.Windows.Forms.Label();
            this.complexBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(852, 119);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // platformListBox
            // 
            this.platformListBox.FormattingEnabled = true;
            this.platformListBox.ItemHeight = 15;
            this.platformListBox.Location = new System.Drawing.Point(14, 145);
            this.platformListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.platformListBox.Name = "platformListBox";
            this.platformListBox.Size = new System.Drawing.Size(422, 79);
            this.platformListBox.TabIndex = 1;
            this.platformListBox.SelectedIndexChanged += new System.EventHandler(this.platformListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Platform list:";
            // 
            // TimingsLabel
            // 
            this.TimingsLabel.AutoSize = true;
            this.TimingsLabel.Location = new System.Drawing.Point(456, 126);
            this.TimingsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimingsLabel.Name = "TimingsLabel";
            this.TimingsLabel.Size = new System.Drawing.Size(52, 15);
            this.TimingsLabel.TabIndex = 3;
            this.TimingsLabel.Text = "Timings:";
            // 
            // deviceListLabel
            // 
            this.deviceListLabel.AutoSize = true;
            this.deviceListLabel.Location = new System.Drawing.Point(14, 235);
            this.deviceListLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceListLabel.Name = "deviceListLabel";
            this.deviceListLabel.Size = new System.Drawing.Size(63, 15);
            this.deviceListLabel.TabIndex = 6;
            this.deviceListLabel.Text = "Device list:";
            // 
            // deviceListBox
            // 
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.ItemHeight = 15;
            this.deviceListBox.Location = new System.Drawing.Point(14, 255);
            this.deviceListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.Size = new System.Drawing.Size(422, 79);
            this.deviceListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test function list:";
            // 
            // functionBox
            // 
            this.functionBox.FormattingEnabled = true;
            this.functionBox.ItemHeight = 15;
            this.functionBox.Items.AddRange(new object[] {
            "c = c * b",
            "a = sin(a)  + sinc(c)",
            "c = sqrt(4 * a * INVTWOPI) * a * sqr(x) * Exp(-0.5 * a * sqr(x))",
            "a = Mean(c)"});
            this.functionBox.Location = new System.Drawing.Point(14, 372);
            this.functionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(422, 154);
            this.functionBox.TabIndex = 7;
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(460, 145);
            this.memo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(384, 380);
            this.memo.TabIndex = 8;
            this.memo.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(742, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vectorLengthBox
            // 
            this.vectorLengthBox.FormattingEnabled = true;
            this.vectorLengthBox.Items.AddRange(new object[] {
            "4096",
            "16384",
            "32768",
            "131072",
            "262144",
            "524288",
            "1048576"});
            this.vectorLengthBox.Location = new System.Drawing.Point(178, 535);
            this.vectorLengthBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vectorLengthBox.Name = "vectorLengthBox";
            this.vectorLengthBox.Size = new System.Drawing.Size(208, 23);
            this.vectorLengthBox.TabIndex = 10;
            // 
            // vectorLengthLabel
            // 
            this.vectorLengthLabel.AutoSize = true;
            this.vectorLengthLabel.Location = new System.Drawing.Point(14, 537);
            this.vectorLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vectorLengthLabel.Name = "vectorLengthLabel";
            this.vectorLengthLabel.Size = new System.Drawing.Size(80, 15);
            this.vectorLengthLabel.TabIndex = 11;
            this.vectorLengthLabel.Text = "Vector length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 570);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Open CL float precision:";
            // 
            // floatPrecisionBox
            // 
            this.floatPrecisionBox.FormattingEnabled = true;
            this.floatPrecisionBox.Items.AddRange(new object[] {
            "32bit single precision",
            "64bit double precision"});
            this.floatPrecisionBox.Location = new System.Drawing.Point(178, 567);
            this.floatPrecisionBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.floatPrecisionBox.Name = "floatPrecisionBox";
            this.floatPrecisionBox.Size = new System.Drawing.Size(208, 23);
            this.floatPrecisionBox.TabIndex = 13;
            // 
            // cpuFloatPrecisionLabel
            // 
            this.cpuFloatPrecisionLabel.AutoSize = true;
            this.cpuFloatPrecisionLabel.Location = new System.Drawing.Point(14, 601);
            this.cpuFloatPrecisionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cpuFloatPrecisionLabel.Name = "cpuFloatPrecisionLabel";
            this.cpuFloatPrecisionLabel.Size = new System.Drawing.Size(190, 15);
            this.cpuFloatPrecisionLabel.TabIndex = 14;
            this.cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: 64bit";
            // 
            // complexBox
            // 
            this.complexBox.AutoSize = true;
            this.complexBox.Location = new System.Drawing.Point(394, 538);
            this.complexBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.complexBox.Name = "complexBox";
            this.complexBox.Size = new System.Drawing.Size(74, 19);
            this.complexBox.TabIndex = 15;
            this.complexBox.Text = "Complex";
            this.complexBox.UseVisualStyleBackColor = true;
            // 
            // clBenchmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 648);
            this.Controls.Add(this.complexBox);
            this.Controls.Add(this.cpuFloatPrecisionLabel);
            this.Controls.Add(this.floatPrecisionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vectorLengthLabel);
            this.Controls.Add(this.vectorLengthBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceListLabel);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.TimingsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformListBox);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "clBenchmarkForm";
            this.Text = "Benchmarks";
            this.Load += new System.EventHandler(this.clBenchmarkForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox platformListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimingsLabel;
        private System.Windows.Forms.Label deviceListLabel;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox functionBox;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vectorLengthBox;
        private System.Windows.Forms.Label vectorLengthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox floatPrecisionBox;
        private System.Windows.Forms.Label cpuFloatPrecisionLabel;
        private System.Windows.Forms.CheckBox complexBox;
    }
}