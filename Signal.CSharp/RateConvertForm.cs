using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace DSPDemo {
	public partial class RateConvertForm : Form {
		public RateConvertForm() {
			InitializeComponent();
		}

		private void RateConvertForm_Load(object sender, EventArgs e) {
			richTextBox1.Text = "Change rate conversion factor and observe the frequency response. For this " +
					"example, the noise attenuation is set to 100dB. Maximum range is 150dB.  " +
					"Signal generator allows you to test the rate converter with two preset signals. " +
					"Gaussian noise and 3 independent single tone frequencies. Each time you press update " +
					"signal generator advances and a new block data is streamed in to the buffers through " +
					"the rate converter. The Reset button resets the buffers and the rate conversion." +
					"There is no limit on maximum or minimum rate conversion factor or its precision. " +
					"All filters used are linear phase. The rate converter is of substantially higher quality" +
					"than those provided by Windows or by Soundcard makers. The test is not very responsive " +
					"because the charts have to do a lot of drawing, but the conversion itself is very fast.";
			rateFactorEdit.Position = signalRateConverter.Factor;
			rateFactorEdit_Click(sender, e);
		}

		private void Reset() {
			signalStoreBuffer.Reset();
			signalStoreBuffer1.Reset();
			signalGenerator.Reset();
			signalRateConverter.Reset();
		}

		private void updateButton_Click(object sender, EventArgs e) {
			spectrumAnalyzer.Pull();
			spectrumAnalyzer1.Pull();
		}

		private void signalGenerator_OnParameterUpdate(object Sender) {
			Reset();
			updateButton_Click(Sender, EventArgs.Empty);
			updateButton_Click(Sender, EventArgs.Empty);
		}

		private void button4_Click(object sender, EventArgs e) {
			Reset();
		}

		private void rateFactorEdit_Click(object sender, EventArgs e) {
			signalRateConverter.Factor = rateFactorEdit.Position;
			Reset();
			updateButton_Click(sender, EventArgs.Empty);
			updateButton_Click(sender, EventArgs.Empty);
		}

		private void button1_Click(object sender, EventArgs e) {
			signalGeneratorDialog.Execute();
		}

		private void button2_Click(object sender, EventArgs e) {
			Stopwatch sw = new Stopwatch();
			sw.Start();
			for (int i = 0; i < 1000; i++) signalRateConverter.Update();
			sw.Stop();
			benchmarkButton.Text = sw.ElapsedMilliseconds + " ms";
		}
	}
}
