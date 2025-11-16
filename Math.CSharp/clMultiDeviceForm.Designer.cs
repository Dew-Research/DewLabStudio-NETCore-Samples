using Dew.Math.Units;
using Dew.Math;

namespace MtxVecDemo
{
    partial class clMultiDeviceForm
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
            //ClMtxVec.clPlatform().Free();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.platformListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimingsLabel = new System.Windows.Forms.Label();
            this.deviceListLabel = new System.Windows.Forms.Label();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.functionBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vectorLengthBox = new System.Windows.Forms.ComboBox();
            this.vectorLengthLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.floatPrecisionBox = new System.Windows.Forms.ComboBox();
            this.cpuFloatPrecisionLabel = new System.Windows.Forms.Label();
            this.complexBox = new System.Windows.Forms.CheckBox();
            this.maximumJobCountEdit = new System.Windows.Forms.ComboBox();
            this.currentJobCountLabel = new System.Windows.Forms.Label();
            this.TotalRunningTimeLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.schedulerTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(844, 104);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // platformListBox
            // 
            this.platformListBox.FormattingEnabled = true;
            this.platformListBox.Location = new System.Drawing.Point(12, 126);
            this.platformListBox.Name = "platformListBox";
            this.platformListBox.Size = new System.Drawing.Size(362, 69);
            this.platformListBox.TabIndex = 1;
            this.platformListBox.SelectedIndexChanged += new System.EventHandler(this.platformListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Platform list:";
            // 
            // TimingsLabel
            // 
            this.TimingsLabel.AutoSize = true;
            this.TimingsLabel.Location = new System.Drawing.Point(395, 126);
            this.TimingsLabel.Name = "TimingsLabel";
            this.TimingsLabel.Size = new System.Drawing.Size(101, 13);
            this.TimingsLabel.TabIndex = 3;
            this.TimingsLabel.Text = "Maximum job count:";
            // 
            // deviceListLabel
            // 
            this.deviceListLabel.AutoSize = true;
            this.deviceListLabel.Location = new System.Drawing.Point(12, 204);
            this.deviceListLabel.Name = "deviceListLabel";
            this.deviceListLabel.Size = new System.Drawing.Size(59, 13);
            this.deviceListLabel.TabIndex = 6;
            this.deviceListLabel.Text = "Device list:";
            // 
            // deviceListBox
            // 
            this.deviceListBox.FormattingEnabled = true;
            this.deviceListBox.Location = new System.Drawing.Point(12, 221);
            this.deviceListBox.Name = "deviceListBox";
            this.deviceListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.deviceListBox.Size = new System.Drawing.Size(362, 69);
            this.deviceListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Test function list:";
            // 
            // functionBox
            // 
            this.functionBox.FormattingEnabled = true;
            this.functionBox.Items.AddRange(new object[] {
            "c = c * b",
            "a = sin(a)  + sinc(c)",
            "c = sqrt(4 * a * INVTWOPI) * a * sqr(x) * Exp(-0.5 * a * sqr(x))",
            "a = Mean(c)"});
            this.functionBox.Location = new System.Drawing.Point(12, 322);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(362, 134);
            this.functionBox.TabIndex = 7;
            this.functionBox.SelectedIndexChanged += new System.EventHandler(this.functionBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 26);
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
            this.vectorLengthBox.Location = new System.Drawing.Point(153, 464);
            this.vectorLengthBox.Name = "vectorLengthBox";
            this.vectorLengthBox.Size = new System.Drawing.Size(179, 21);
            this.vectorLengthBox.TabIndex = 10;
            // 
            // vectorLengthLabel
            // 
            this.vectorLengthLabel.AutoSize = true;
            this.vectorLengthLabel.Location = new System.Drawing.Point(12, 465);
            this.vectorLengthLabel.Name = "vectorLengthLabel";
            this.vectorLengthLabel.Size = new System.Drawing.Size(73, 13);
            this.vectorLengthLabel.TabIndex = 11;
            this.vectorLengthLabel.Text = "Vector length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Open CL float precision:";
            // 
            // floatPrecisionBox
            // 
            this.floatPrecisionBox.FormattingEnabled = true;
            this.floatPrecisionBox.Items.AddRange(new object[] {
            "32bit single precision",
            "64bit double precision"});
            this.floatPrecisionBox.Location = new System.Drawing.Point(153, 491);
            this.floatPrecisionBox.Name = "floatPrecisionBox";
            this.floatPrecisionBox.Size = new System.Drawing.Size(179, 21);
            this.floatPrecisionBox.TabIndex = 13;
            this.floatPrecisionBox.SelectedIndexChanged += new System.EventHandler(this.floatPrecisionBox_SelectedIndexChanged);
            // 
            // cpuFloatPrecisionLabel
            // 
            this.cpuFloatPrecisionLabel.AutoSize = true;
            this.cpuFloatPrecisionLabel.Location = new System.Drawing.Point(12, 521);
            this.cpuFloatPrecisionLabel.Name = "cpuFloatPrecisionLabel";
            this.cpuFloatPrecisionLabel.Size = new System.Drawing.Size(171, 13);
            this.cpuFloatPrecisionLabel.TabIndex = 14;
            this.cpuFloatPrecisionLabel.Text = "CPU (MtxVec) float precision: 64bit";
            // 
            // complexBox
            // 
            this.complexBox.AutoSize = true;
            this.complexBox.Location = new System.Drawing.Point(338, 466);
            this.complexBox.Name = "complexBox";
            this.complexBox.Size = new System.Drawing.Size(66, 17);
            this.complexBox.TabIndex = 15;
            this.complexBox.Text = "Complex";
            this.complexBox.UseVisualStyleBackColor = true;
            this.complexBox.CheckedChanged += new System.EventHandler(this.complexBox_CheckedChanged);
            // 
            // maximumJobCountEdit
            // 
            this.maximumJobCountEdit.FormattingEnabled = true;
            this.maximumJobCountEdit.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048",
            "4096",
            "8192",
            "16384"});
            this.maximumJobCountEdit.Location = new System.Drawing.Point(502, 123);
            this.maximumJobCountEdit.MaxDropDownItems = 12;
            this.maximumJobCountEdit.Name = "maximumJobCountEdit";
            this.maximumJobCountEdit.Size = new System.Drawing.Size(154, 21);
            this.maximumJobCountEdit.TabIndex = 16;
            // 
            // currentJobCountLabel
            // 
            this.currentJobCountLabel.AutoSize = true;
            this.currentJobCountLabel.Location = new System.Drawing.Point(395, 160);
            this.currentJobCountLabel.Name = "currentJobCountLabel";
            this.currentJobCountLabel.Size = new System.Drawing.Size(91, 13);
            this.currentJobCountLabel.TabIndex = 17;
            this.currentJobCountLabel.Text = "Current job count:";
            // 
            // TotalRunningTimeLabel
            // 
            this.TotalRunningTimeLabel.AutoSize = true;
            this.TotalRunningTimeLabel.Location = new System.Drawing.Point(395, 195);
            this.TotalRunningTimeLabel.Name = "TotalRunningTimeLabel";
            this.TotalRunningTimeLabel.Size = new System.Drawing.Size(94, 13);
            this.TotalRunningTimeLabel.TabIndex = 18;
            this.TotalRunningTimeLabel.Text = "Total running time:";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Location = new System.Drawing.Point(395, 221);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(64, 13);
            this.errorsLabel.TabIndex = 19;
            this.errorsLabel.Text = "Errors: none";
            // 
            // schedulerTimer
            // 
            this.schedulerTimer.Tick += new System.EventHandler(this.SchedulerTimer_Tick);
            // 
            // clMultiDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 616);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.TotalRunningTimeLabel);
            this.Controls.Add(this.currentJobCountLabel);
            this.Controls.Add(this.maximumJobCountEdit);
            this.Controls.Add(this.complexBox);
            this.Controls.Add(this.cpuFloatPrecisionLabel);
            this.Controls.Add(this.floatPrecisionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vectorLengthLabel);
            this.Controls.Add(this.vectorLengthBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deviceListLabel);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.TimingsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformListBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "clMultiDeviceForm";
            this.Text = "Multi-device benchmark";
            this.Load += new System.EventHandler(this.clBenchmarkForm_Load);
            this.Shown += new System.EventHandler(this.clMultiDeviceForm_Shown);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox vectorLengthBox;
        private System.Windows.Forms.Label vectorLengthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox floatPrecisionBox;
        private System.Windows.Forms.Label cpuFloatPrecisionLabel;
        private System.Windows.Forms.CheckBox complexBox;
        private System.Windows.Forms.ComboBox maximumJobCountEdit;
        private System.Windows.Forms.Label currentJobCountLabel;
        private System.Windows.Forms.Label TotalRunningTimeLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Timer schedulerTimer;
    }
}