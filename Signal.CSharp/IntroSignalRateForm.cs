using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DSPDemo {
	public partial class IntroSignalRateForm : DSPDemo.BasicForm3 {
		public IntroSignalRateForm() {
			InitializeComponent();

			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
			Add("Fractional rate conversion algorithms:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Unique filtering logic with exceptional speed.");
			Add("All linear phase, multi-rate filter design.");
			Add("All filter designs allow 160dB maximum stop band attenuation.");
			Add("User definable transition bandwidth.");
			Add("Real number sampling rate conversion factor.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.BulletIndent = 0;

		}
	}
}
