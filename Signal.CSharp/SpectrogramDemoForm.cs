using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math.Tee;
using System.IO;
using Dew.Math.Controls;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Math.Units;

namespace DSPDemo {
	public partial class SpectrogramDemoForm : Form {
		public SpectrogramDemoForm() {
			InitializeComponent();
			series = new MtxGridSeries(tChart1.Chart);
			series.XStep = 1;
			series.YStep = 1;
			series.PixelResample = true;
			series.PixelResampleMethod = Dew.Math.TPixelDownSample.pdsAverage;
			series.LegendItemsCount = 11;
			series.ColorPalette.PaletteSteps = 1000;
			series.ColorPalette.PaletteStyle = GridPaletteStyle.palRangeDiscrete;
			series.ColorPalette.ColorBalance = -0.5;
			series.ColorPalette.SharpConstrast = false;
			series.ColorPalette.UseMidColor = true; //FIXME!
			series.ColorPalette.Rainbow.BottomToMid = true;
			series.ColorPalette.Rainbow.MidToTop = true;
			series.ColorPalette.ColorBalanceMid = -0.85;
			series.ColorPalette.PaletteScale = PaletteScale.ppsPeakHold;


			signalRead1.FileName = Dew.Demo.Utils.SourcePath() + @"\Data\bz.sfs";
			signalRead1.OpenFile();
			signalRead1.Length = 1024 * signalRead1.ChannelCount;
			signalRead1.OverlappingPercent = 98;
			signalRead1.RecordPosition = 0;

			computeSpectrogramThread.Start();
		}

		MtxGridSeries series;

		private void SpectrogramDemoForm_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Escape) {
				computeSpectrogramThread.Cancel = true;
			}
		}

		void updateSpectrogram(TSpectrogram Src, MtxGridSeries Series) {
			if (Src == null) {
				Series.Clear();
				return;
			}
			if (Src.Count > 0) {
				Src.CopyAmpltTransposed(Series.Matrix);
				Series.XOffset = 0;
				Series.YOffset = 0;
				if (Src.Count > 0) {
					Series.YStep = Src[0].HzRes;
					Series.XStep = Src.SpectralDt;
				}
				Series.Legend.Visible = false;
				Series.Update();
			} else {
				Series.Clear();
			}
		}

		private void computeSpectrogramThread_Compute(object sender, EventArgs e) {
			if (!signalRead1.IsEndOfFile())
				spectrogram1.Pull();
			else
				computeSpectrogramThread.Cancel = true;
		}

		private void computeSpectrogramThread_ProgressUpdate(object sender, MtxProgressEvent e) {
			TSignalRead dst = signalRead1;
			TSpectrumAnalyzer a = spectrumAnalyzer1;
			switch (e) {
				case MtxProgressEvent.peInit:
					progressPanel.SliderMin = 0;
					progressPanel.SliderMax = 100;
					progressPanel.SliderPosition = 0;
					progressPanel.SliderSpan = 0;
					//progressPanel.Text = 'Spectrogram 0%';
					progressPanel.Visible = true;
					Cursor.Current = Cursors.WaitCursor;
					computeSpectrogramThread.UpdateInterval = 50;
					spectrogram1.Reset();
					spectrogram1.MaxSpectrumCount = (int)dst.MaxFrames;

					a.Stats.Averaging = TAveraging.avNone;
					a.Rotation = 0;
					a.Logarithmic = false; //because then it can be applied later.
					a.LogType = TLogType.ltAbsolute;
					a.ResetAveraging();
					a.SuspendNotifyUpdate = true;
					break;

				case MtxProgressEvent.peCycle:
					progressPanel.SliderSpan = dst.FrameNumber / dst.MaxFrames * 100;
					//progressPanel.Caption = 'Spectrogram ' + FormatFloat('0%',ProgressPanel.SliderSpan);
					break;

				case MtxProgressEvent.peCleanUp:
					dst.CloseFile();
					progressPanel.Visible = false;
					Cursor.Current = Cursors.Default;
					spectrogram1.SpectralSamplingFrequency = dst.FramesPerSecond;
					series.ColorPalette.ResetPeakScale();
					updateSpectrogram(spectrogram1, series);
					break;

			}
		}

		private void button1_Click(object sender, EventArgs e) {
			openFileDialog1.Filter = FileSignal.SignalDialogFilter;
			openFileDialog1.FilterIndex = 8;
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				if (File.Exists(openFileDialog1.FileName)) {
					signalRead1.FileName = openFileDialog1.FileName;
					signalRead1.OpenFile();
					signalRead1.Length = 1024 * signalRead1.ChannelCount;
					signalRead1.OverlappingPercent = 0;
					signalRead1.RecordPosition = 0;

					//limit the size of spectrogram so that we don't run out of mem
					signalRead1.SelectionStop = Math387.Min(signalRead1.RecordLength, 10000 * 100);

					computeSpectrogramThread.Start();
				}
			}

		}
	}
}
