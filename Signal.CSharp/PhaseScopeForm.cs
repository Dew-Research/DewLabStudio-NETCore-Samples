using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dew.Math;
using Dew.Math.Tee;
using Dew.Signal;
using Dew.Signal.Units;
using Dew.Signal.Tee;
using Steema.TeeChart.Editors;

namespace DSPDemo {
	public partial class PhaseScopeForm : Form {

        Vector a, Re, Im;
        TFirState HilbertState;
        TDelayFilterState DelayState;
       
		public PhaseScopeForm() {
			InitializeComponent();
		}

		private void PhaseScopeForm_Load(object sender, EventArgs e) {            
			Vector H = new Vector();
			H.Length = 256;
			OptimalFir.RemezImpulse(H, new double[] { 0.05, 0.490 }, TFilterType.ftHilbertIV, 1, 2); //type four hilbert
			SignalUtils.FirInit(H, ref HilbertState, 1, 0, 1, 0);
			OptimalFir.RemezImpulse(H, new double[] { 0.05, 0.1 }, TFilterType.ftHighpass, 1, 2);  // need a DC filter on original
			SignalUtils.DelayInit((H.Length - 1) / 2, ref DelayState, H.FloatPrecision);

			Signal1.Data.Size(1024);  //defines how much data to copy and consequently also frequency resolution
			Signal1.Data.SetZero();
			Signal1.UsesInputs = false;
			Signal2.Data.Size(1024);  //defines how much data to copy and consequently also frequency resolution
			Signal2.Data.SetZero();
			Signal2.UsesInputs = false;

            Re = new Vector();
            Im = new Vector();
            a = new Vector();

			channelBox.SelectedIndex = 0;

			richTextBox1.Text = "The recording is setup for 11025 kHz stereo. You can select " +
					"the channel you wish to monitor." +
					"This example shows, the relative phases of each channel separately." +
					"This is not especially usefull for audio analysis, because a true phase scope compares " +
					"left and right channel. This example demonstrates the use of a hilbert " +
					"transformer.";
			SignalTimer1.Enabled = true;
		}

        private void SignalTimer1_OnTimer(object Sender, EventArgs e)
        {           
						
			if (!SignalIn1.Active) SignalIn1.Start();
			SignalIn1.MonitorData(Signal1, Signal2);
			SignalUtils.RemoveDC(Signal1.Data); //should be FIR filter, but this will work also
			SignalUtils.RemoveDC(Signal2.Data); //should be FIR filter, but this will work also

            a.SetFullRange();
			a.Hilbert(Signal1.Data,THilbertMethod.hmMethod1);
			a.SetSubRange((int)(a.Length * 0.1), (int)(a.Length * 0.8)); //leave out the edges, because they are bad... (rectangular window ripple effect)
			a.CartToPolar(Re, Im);
			Im = Im * (180 / Math.PI); //from radians to degrees
			Re = Re / Re.Max();  //normalize
			TeeChart.DrawValues(Im, Re, leftPhaseChart.Series[0], false); //angle is x
			a.SetFullRange();
			a.Hilbert(Signal2.Data, THilbertMethod.hmMethod1);
			a.SetSubRange((int)(a.Length * 0.1), (int)(a.Length * 0.8)); //leave out the edges, because they are bad... (rectangular window ripple effect)
			a.CartToPolar(Re, Im);
			Im = Im * (180 / Math.PI); //from radians to degrees
			Re = Re / Re.Max();  //normalize
			TeeChart.DrawValues(Im, Re, rightPhaseChart.Series[0], false); //angle is x
			
			switch (channelBox.SelectedIndex) {
				case 0:
					signalChart1.Signals[0].Input = Signal1;
					signalChart1.Header.Text = "Time signal - Left channel";
					break;
				case 1:
					signalChart1.Signals[0].Input = Signal2;
					signalChart1.Header.Text = "Time signal - Right channel";
					break;
			}
			signalChart1.Signals[0].Input.UpdateNotify();
		}

		private void panel2_Resize(object sender, EventArgs e) {
			signalChart1.Height = panel2.Height / 2;
			leftPhaseChart.Width = panel3.Width / 2;
		}

		private void button1_Click(object sender, EventArgs e) {

            chartEditor.ShowModal();
		}
	}
}
