namespace MtxVecDemo
{
    partial class clCustomFunctionForm
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
            this.deviceListLabel = new System.Windows.Forms.Label();
            this.deviceListBox = new System.Windows.Forms.ListBox();
            this.AutoDeviceButton = new System.Windows.Forms.Button();
            this.vectorLengthBox = new System.Windows.Forms.ComboBox();
            this.vectorLengthLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(781, 104);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // platformListBox
            // 
            this.platformListBox.FormattingEnabled = true;
            this.platformListBox.Location = new System.Drawing.Point(12, 126);
            this.platformListBox.Name = "platformListBox";
            this.platformListBox.Size = new System.Drawing.Size(435, 69);
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
            this.deviceListBox.Size = new System.Drawing.Size(435, 69);
            this.deviceListBox.TabIndex = 5;
            // 
            // AutoDeviceButton
            // 
            this.AutoDeviceButton.Location = new System.Drawing.Point(466, 221);
            this.AutoDeviceButton.Name = "AutoDeviceButton";
            this.AutoDeviceButton.Size = new System.Drawing.Size(88, 26);
            this.AutoDeviceButton.TabIndex = 9;
            this.AutoDeviceButton.Text = "Auto select";
            this.AutoDeviceButton.UseVisualStyleBackColor = true;
            this.AutoDeviceButton.Click += new System.EventHandler(this.AutoDeviceButton_Click);
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
            this.vectorLengthBox.Location = new System.Drawing.Point(155, 315);
            this.vectorLengthBox.Name = "vectorLengthBox";
            this.vectorLengthBox.Size = new System.Drawing.Size(151, 21);
            this.vectorLengthBox.TabIndex = 10;
            // 
            // vectorLengthLabel
            // 
            this.vectorLengthLabel.AutoSize = true;
            this.vectorLengthLabel.Location = new System.Drawing.Point(12, 318);
            this.vectorLengthLabel.Name = "vectorLengthLabel";
            this.vectorLengthLabel.Size = new System.Drawing.Size(73, 13);
            this.vectorLengthLabel.TabIndex = 11;
            this.vectorLengthLabel.Text = "Vector length:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 26);
            this.button2.TabIndex = 12;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clCustomFunctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.vectorLengthLabel);
            this.Controls.Add(this.vectorLengthBox);
            this.Controls.Add(this.AutoDeviceButton);
            this.Controls.Add(this.deviceListLabel);
            this.Controls.Add(this.deviceListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.platformListBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "clCustomFunctionForm";
            this.Text = "Benchmarks";
            this.Load += new System.EventHandler(this.clCustomFunctionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox platformListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label deviceListLabel;
        private System.Windows.Forms.ListBox deviceListBox;
        private System.Windows.Forms.Button AutoDeviceButton;
        private System.Windows.Forms.ComboBox vectorLengthBox;
        private System.Windows.Forms.Label vectorLengthLabel;
        private System.Windows.Forms.Button button2;
    }
}