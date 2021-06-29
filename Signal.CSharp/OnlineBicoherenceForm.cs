using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Signal.Tee;

namespace DSPDemo {
	public partial class OnlineBicoherenceForm : Form {
		public OnlineBicoherenceForm() {
			InitializeComponent();
			createTools();
		}

		private void button1_Click(object sender, EventArgs e) {
			SpectrumAnalyzerDialog1.Execute();
		}

		private void button2_Click(object sender, EventArgs e) {
			BiSpectrumAnalyzerDialog1.Execute();
		}

		private void button3_Click(object sender, EventArgs e) {
			chartEditor.Show();
		}

		void createTools() {
			AxisScaleTool axs = new AxisScaleTool(spectrumChart2.Chart);
			axs.UpperMargin = 20;
			axs.LowerMargin = 5;
			axs.AxisScaleMode = AxisScaleMode.amPeakHold;
			axs.DataIsSpectrum = true;
			axs.Axis = spectrumChart2.Axes.Left;

			SpectrumMarkTool smt = new SpectrumMarkTool(spectrumChart2.Chart);
			smt.CursorActive = true;
			smt.MarkSeries = points2;
			smt.DoubleClickClear = true;
			smt.Series = fastLine2;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;

			AxisScaleTool axs1 = new AxisScaleTool(spectrumChart1.Chart);
			axs1.UpperMargin = 20;
			axs1.LowerMargin = 5;
			axs1.AxisScaleMode = AxisScaleMode.amPeakHold;
			axs1.DataIsSpectrum = true;
			axs1.Axis = spectrumChart1.Axes.Left;


			SpectrumMarkTool smt1 = new SpectrumMarkTool(spectrumChart1.Chart);
			smt1.CursorActive = true;
			smt1.MarkSeries = points1;
			smt1.DoubleClickClear = true;
			smt1.Series = fastLine1;
			smt1.PeakFilterMode = false;
			smt1.MarkMode = SpectrumMarkMode.mmSingle;
			smt1.MarkType = SpectrumMarkType.mtAmplt;
			smt1.AmpltFormat = "0.00#";
			smt1.PhaseFormat = "0.00#";
			smt1.FreqFormat = "0.00#";
			smt1.LabelHeaders = true;
			smt1.PeakZoomBand = false;
		}

		private void OnlineBicoherenceForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(1024);  // defines how much data to copy and
			// consequently also frequency resolution
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;
			Signal1.SamplingFrequency = SignalIn1.SamplingFrequency;
			BiSpectrumAnalyzer1.Stats.Averaging = TAveraging.avExponentInf;
			BiSpectrumAnalyzer1.Stats.ExpDecay = 20;
			BiSpectrumAnalyzer1.Amplt.SetZero();
			BiSpectrumAnalyzer1.BiAnalyzer.SingleLinesOnly = true;
			BiSpectrumAnalyzer1.BiAnalyzer.Lines.Size(100);
			BiSpectrumAnalyzer1.BiAnalyzer.Lines.Ramp(20, 10);  //because resolution is about 10 Hz/line
			channelBox.SelectedIndex = 0;

			richTextBox1.Text = "Bicoherence shows the frequencies related to the selected frequency. " +
						"The bicoherence can also be run in real time, but before the " +
						"spectrum is representative, sufficient number of running averages must be made." +
						"A very limiting condition is that the frequency spectrum of the analyzed " +
						"signal may not change significantly during the analysis." +
						"Bicoherence can therefore be applied only in cases where it is possible " +
						"to acquire sufficiently long signals whose frequency content does not change with time " +
						"very quickly. For example, usually about 20 averages will be sufficient and with 90% " +
						"overlapping. With a sampling frequency of 11kHz and frequency spectrum length of " +
						"1024 frequency bins, that would mean that at least 6144/11025 = 0.4 seconds are needed " +
						"during which the frequency content of the signal may not change significantly.";
			freqEdit_Click(sender, e);
		}

		private void freqEdit_Click(object sender, EventArgs e) {
			BiSpectrumAnalyzer1.SamplingFrequency = SignalIn1.SamplingFrequency; //needed only for the first call
			//because the sampling frequency has not yet been set by the Update method,
			//simply because the timer has not yet triggered.
			BiSpectrumAnalyzer1.BiAnalyzer.Frequency = freqEdit.Position;
			colorLine1.Value = freqEdit.Position;
			spectrumChart1.Header.Text = "Bicoherence of frequency: " + freqEdit.Position.ToString("0") + "Hz";

		}

		private void panel2_Resize(object sender, EventArgs e) {
			spectrumChart1.Height = panel2.Height / 2;
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {
			if (!SignalIn1.Active) SignalIn1.Start();
			switch ((TChannel)channelBox.SelectedIndex) {
				case TChannel.chLeft: SignalIn1.MonitorData(Signal1, null); break;
				case TChannel.chRight: SignalIn1.MonitorData(null, Signal1); break;
			}
			SpectrumAnalyzer1.Pull();
			BiSpectrumAnalyzer1.Pull();
		}


	}
}
