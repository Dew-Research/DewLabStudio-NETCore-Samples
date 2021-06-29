using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Signal;
using Dew.Math;
using Dew.Signal.Tee;

namespace DSPDemo {
	public partial class MonitorDemoForm : Form {
		public MonitorDemoForm() {
			InitializeComponent();

			SpectrumMarkTool smt = new SpectrumMarkTool(SpectrumChart1.Chart);
			smt.CursorActive = true;
			smt.DoubleClickClear = true;
			smt.PeakFilterMode = false;
			smt.MarkMode = SpectrumMarkMode.mmSingle;
			smt.MarkType = SpectrumMarkType.mtAmplt;
			smt.MarkSeries = Series2;
			smt.Series = Series1;
			smt.AmpltFormat = "0.00#";
			smt.PhaseFormat = "0.00#";
			smt.FreqFormat = "0.00#";
			smt.LabelHeaders = true;
			smt.PeakZoomBand = false;
			SpectrumChart1.Tools.Add(smt);
		}

		private void MonitorDemoForm_Load(object sender, EventArgs e) {
			Signal1.Data.Size(4096);  //defines how much data to copy and consequently also frequency resolution
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;
			SignalWrite1.Precision = TPrecision.prSmallInt; //or prInteger or prByte (others will not work).
			channelComboBox.SelectedIndex = 0;

			richTextBox1.Text = "The recording is set up for 44kHz stereo. The best way to test this demo is to " +
          "speak in to the microphone. You can select the channel you wish to monitor. " +
          "If Record to file checkbox is checked, the signal will be recorded to C:\\test.wav. " +
          "Note the responsivnes of the charts (a very short delay from the time you speak " +
          "to when the display shows the change) while recording to file.";
		}

		private void panel2_Resize(object sender, EventArgs e) {
			SpectrumChart1.Height = panel2.Height / 2;
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {
			if (!SignalIn1.Active) return;

//            Steema.TeeChart.Utils.RegisterSeries(
			SignalIn1.TriggerChannel = (TChannel)channelComboBox.SelectedIndex;
			switch (SignalIn1.TriggerChannel) {
				case TChannel.chLeft: SignalIn1.Trigger(Signal1, null); break;
				case TChannel.chRight: SignalIn1.Trigger(null, Signal1); break;
			}
			SpectrumAnalyzer1.Pull();  //calls update on Signal1 and Self
		}

		private void openButton_Click(object sender, EventArgs e) {
			SignalIn1.Start();
		}

		private void recordToFileCheckBox_CheckedChanged(object sender, EventArgs e) {
			switch (SignalIn1.Quantization) {
				case 8: SignalWrite1.Precision = TPrecision.prByte; break;
				case 16: SignalWrite1.Precision = TPrecision.prSmallInt; break;
				case 24: SignalWrite1.Precision = TPrecision.prInt24; break;
			}
			SignalWrite1.Active = recordToFileCheckBox.Checked;
		}

		private void recordingButton_Click(object sender, EventArgs e) {
			SignalInDialog1.ExecuteModal();
		}

		private void spectrumButton_Click(object sender, EventArgs e) {
			SpectrumAnalyzerDialog1.Execute();
		}

		private void spectrumChartButton_Click(object sender, EventArgs e) {
			spectrumEditor.ShowModal();
		}

		private void timeChartButton_Click(object sender, EventArgs e) {
			signalEditor.ShowModal();
		}	

        private void SpectrumAnalyzer1_OnParameterUpdateEvent(object Sender)
        {
			SpectrumAnalyzer1.Update();
		}
    }
}
