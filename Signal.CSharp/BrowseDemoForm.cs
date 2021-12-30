using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Steema.TeeChart.Styles;
using Dew.Math.Units;
using Dew.Math.Tee;
using Dew.Math.Controls;
using Dew.Signal.Units;
using Dew.Signal.Tee;
using System.Drawing.Drawing2D;

namespace DSPDemo {
	public partial class BrowseDemoForm : Form {
		public BrowseDemoForm() {
			InitializeComponent();
			series1 = new SignalHighLowSeries(signalChart1.Chart);
			series1.HighValues.Name = "Y";
			series1.HighValues.Order = ValueListOrder.None;
			series1.LowValues.Name = "Low";
			series1.HighValues.Order = ValueListOrder.None;
			series1.XValues.Name = "X";
			series1.XValues.Order = ValueListOrder.Ascending;
			series1.HighBrush.Color = Color.Red;
			series1.LowBrush.Color = Color.Red;
			series1.LowBrush.Style = 0;
			series1.SeriesMode = SignalSeriesMode.ssmHighLow;
			series1.ZMiddleDepth = false;
			series1.Pen.Color = Color.Black;
		}

		SignalHighLowSeries series1;

		private void openFileButton_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				signalBrowse1.Threaded = threadedBox.Checked;
				Cursor.Current = Cursors.WaitCursor;
				try {
                    signalBrowse1.CloseFile();
					signalBrowse1.OpenBrowseFile(openFileDialog1.FileName);
					if (!signalBrowse1.Threaded) {
						signalBrowse1.LoadFullRecord();
						BrowseChartUpdate(0);
					}
				} finally {
					Cursor.Current = Cursors.Default;
				}
			} 
		}

		private void BrowseDemoForm_Load(object sender, EventArgs e) {
			channelBox.SelectedIndex = 0;
			signalBrowse1.ProgressThread.UpdateInterval = 50;
			richTextBox1.Text = "Open a few 10MB long uncompressed wav file. The chart will display signal overview." +
          "For 200 MB long wav file, it takes a little less then 6 seconds to create the overview. " +
          "(.pk file). It is then possible to browse through the entire signal, pan and zoom with " +
          " small memory usage and highly responsive display. This demo will place a .pk file with same name as the opened wav file in the " +
          "same directory where the opened .wav file resides. If the wav file date/time stamp " +
          "has changed, since the time when the .pk file was first created, " +
          "the old .pk file will be deleted and new one created.";
		}

		void DrawOverviewSeries(TVec Src, Series Series, double DtOffset, double Dt) {
			if (signalBrowse1.IsOverview()) {
				series1.SeriesDataType = SignalSeriesDataType.ssdHighLow;
				series1.SeriesMode = SignalSeriesMode.ssmAuto;
                series1.AddHighLowValues(Src, DtOffset, Dt); //when overview
			} else {
				series1.SeriesDataType = SignalSeriesDataType.ssdLine;
				series1.SeriesMode = SignalSeriesMode.ssmAuto;
				MtxVecTee.DrawValues(Src, Series, DtOffset, Dt, true);
			}
		}

		void BrowseChartUpdate(double DtOffset) {
			Vector a1 = new Vector();
			a1.Size(0);
			signalChart1.Series[0].Clear();
			switch (signalBrowse1.ChannelCount) {
				case 1:
					SignalUtils.Demultiplex(signalBrowse1.Data, a1, signalBrowse1.ChannelCount, 0);
                    DrawOverviewSeries(a1, signalChart1.Series[0], DtOffset, signalBrowse1.Dt);
					break;
				case 2:
					switch (channelBox.SelectedIndex) {
						case 0: // Left
							SignalUtils.Demultiplex(signalBrowse1.Data, a1, signalBrowse1.ChannelCount, 0);
                            DrawOverviewSeries(a1, signalChart1.Series[0], DtOffset, signalBrowse1.Dt );
							break;
						case 1: // Right
							SignalUtils.Demultiplex(signalBrowse1.Data, a1, signalBrowse1.ChannelCount, 1);
                            DrawOverviewSeries(a1, signalChart1.Series[0], DtOffset, signalBrowse1.Dt );
							break;
					}
					break;
			}
		}

		private void button1_Click(object sender, EventArgs e) {
            ChartEditor.ShowModal();
		}

		private void channelBox_SelectedIndexChanged(object sender, EventArgs e) {
			BrowseChartUpdate(0);
		}

		private void signalChart1_Scroll(object sender, EventArgs e) {
            signalBrowse1.RecordTimePosition = Math.Max(signalChart1.Axes.Bottom.Minimum, 0);
            BrowseChartUpdate(signalBrowse1.RecordTimePosition);
		}

		private void signalChart1_Zoomed(object sender, EventArgs e) {
			signalBrowse1.SpanTime = signalChart1.Axes.Bottom.Maximum - signalChart1.Axes.Bottom.Minimum;
			signalBrowse1.RecordTimePosition = Math.Max(signalChart1.Axes.Bottom.Minimum, 0);
            BrowseChartUpdate(signalBrowse1.RecordTimePosition);
		}

		private void signalChart1_UndoneZoom(object sender, EventArgs e) {
			signalBrowse1.LoadFullRecord();
			BrowseChartUpdate(0);
		}

        private void signalChart1_Click(object sender, EventArgs e)
        {

        }

        private void signalBrowse1_OnProgressUpdateEvent(object sender, MtxProgressEvent e)
        {
			switch (e)
			{
				case MtxProgressEvent.peCycle:
					positionPanel1.SliderSpan = signalBrowse1.SignalFile.RecordPosition * 100 / signalBrowse1.SignalFile.RecordLength;
					break;
				case MtxProgressEvent.peCleanUp:
					positionPanel1.SliderSpan = 100;
					signalBrowse1.LoadFullRecord();
					BrowseChartUpdate(0);
					break;
			}
		}
    }
}
