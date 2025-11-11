using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Dew.Math.Units;
using Dew.Signal;
using Dew.Signal.Tee;

namespace DSPDemo {
	public partial class PlaybackDemoForm : Form {
		public PlaybackDemoForm() {
			InitializeComponent();

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmFreeStyle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = points2;
			smt.Series = fastLine2;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);
		}

		private void panel2_Resize(object sender, EventArgs e) {
			SpectrumChart1.Height = panel2.Height / 2;
		}

		private void PlaybackDemoForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(2048);  //defines how much data to copy
			Signal1.UsesInputs = false;
			//    SignalRead1.Length := 16384;  //this will automatically set the size of the SignalOut buffer!!

			richTextBox1.Text = "Open an uncompressed PCM wav file. The signal display and spectrum analyzer will be " +
					"updated with a frequency independent of the audio stream being played back. " +
					"Note the smooth and very responsive display next to the clean playback. " +
					"The screen update frequency is 20Hz, frequency spectrum is based on 2048 samples " +
					"and this requires only 20% of 1GHz CPU.";
			comboBox1.SelectedIndex = 0;
		}

		private void WaitForPlayback() {
			SignalOut1.StopAtOnce();
			for (int i = 0; i < 10; i++) {
				Thread.Sleep(20);
				Application.DoEvents();
			}
		}

		private void buttonOpen_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				WaitForPlayback(); //because you can not start right after being stopped
				SignalRead1.FileName = openFileDialog1.FileName;
				SignalRead1.OpenFile(); //not needed otherwise, but we need Precision and SamplingFrequency fields
				int Len = (int)(0.3 * SignalRead1.SamplingFrequency * SignalRead1.ChannelCount);
				if (Len % 2 == 1) Len++;
				SignalRead1.Length = Len;
				// because SignalOut buffer size will use this to set its own BufferSize
				// If BufferSize is too small, the sound will be distorted.
				SignalOut1.Quantization = (ushort)Math.Min(24, MtxVec.SizeOfPrecision(SignalRead1.Precision, false) * 8);
				SignalOut1.Start();
			}
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {
			if (!SignalOut1.Active) return;
			switch ((TChannel)comboBox1.SelectedIndex) {
				case TChannel.chLeft: SignalOut1.MonitorData(Signal1, null);
					break;
				case TChannel.chRight: SignalOut1.MonitorData(null, Signal1);
					break;
			}
			SpectrumAnalyzer1.Pull();//calls update on Signal1 and Self
		}

		private void spectrumButton_Click(object sender, EventArgs e) {
			SpectrumAnalyzerDialog1.ExecuteModal();
		}

		private void playbackButton_Click(object sender, EventArgs e) {
			SignalOutDialog1.ExecuteModal();
		}

		private void spectrumChartButton_Click(object sender, EventArgs e) {
			frequencyChartEditor.ShowModal();
		}

		private void timeChartButton_Click(object sender, EventArgs e) {
			signalChartEditor.ShowModal();
		}

		private void SpectrumAnalyzer1_OnParameterUpdate(object Sender) {
			SpectrumAnalyzer1.Update();
		}

        private void SignalOutDialog1_OnParameterUpdate(object Sender, EventArgs e)
        {
			SignalOut1.Update();
		}
	}
}
