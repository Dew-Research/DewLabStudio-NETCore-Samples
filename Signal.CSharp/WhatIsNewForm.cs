using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DSPDemo
{
	public class WhatIsNewForm : DSPDemo.BasicForm3
	{
		private System.ComponentModel.IContainer components = null;

        //private void Add(string text)
        //{
        //    richTextBox1.SelectionStart = richTextBox1.TextLength;
        //    richTextBox1.SelectionLength = 0;
        //    richTextBox1.SelectedText = text + Environment.NewLine;
        //}

        public WhatIsNewForm()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("");
            //richTextBox1.SelectionStart = richTextBox1.TextLength;
            //richTextBox1.SelectionLength = 0;
            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features and changes for v6.3.5 (November 2025)");
            Add("");

            // BULLETS
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Compiled fully in C#, including when targeting .NET Framework (net48).");
            Add("Full XML documentation tooltip support is now included directly from source code comments.");
            Add("Compiled using the latest C# compiler toolchain, offering significant performance improvements.");
            Add("100% compatible public API across .NET Framework and modern .NET (.NET Core / .NET 5+).");
            Add("Redesigned WinForms component serialization to avoid binary serialization while maintaining compatibility.");
            Add("Target frameworks expanded: netstandard2.0, net48, net8.0, net8.0-windows, net9.0, net9.0-windows.");
            Add("UI components are available on WinForms; all non-visual processing components run cross-platform.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features and changes for v6.3 (December 2024)");
            Add("");

            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("SignalUtils.CZT performance improved ~7x.");
            Add("Added SignalUtils.CZT overload supporting State variable for additional ~2.5x speed-up (total ~17.5x).");
            Add("Added SignalUtils.MusicalNotePitch and vectorized MusicalNotePitchInit for pitch detection.");
            Add("Enabled block-vectorized SignalUtils.GoertzN with multi-frequency acceleration (5-10x+; with threading scales linearly).");
            Add("New implementation of SignalUtils.GoertzN achieving 3x to 10x performance gains depending on frequency count.");
            Add("Improved Bonzanigo phase correction accuracy for large frequency spectrums.");
            richTextBox1.SelectionBullet = false;
            Add("");

            Add("TSpectrumAnalyzer improvements:");
            Add("");
            richTextBox1.SelectionBullet = true;
            Add("Enabled support for the new faster CZT engine.");
            Add("Peak interpolation works also when CZT is the selected spectral method.");
            Add("Vectorized peak searching and processing (multiple vector-based overloads added).");
            Add("Peak interpolation now invariant to zero-padding; up to 16x faster for 16x zero-padded signals.");
            Add("Vectorized peak interpolation algorithm provides at least 6x speed-up per core (single-core SIMD parallel job model).");
            Add("Under favorable conditions total speed-up can reach ~96x (6x interpolation × 16x zero-padding).");
            Add("FindLargestPeaks is typically 100x+ faster when using numerical interpolation.");
            Add("Added FindFirstHarmonic for pitch detection support.");
            Add("Added FindFundamentals to detect multiple harmonic series in the spectrum.");
            richTextBox1.SelectionBullet = false;
            Add("");

            Add("TSignalCore Audio improvements:");
            Add("");
            richTextBox1.SelectionBullet = true;
            Add("Expanded ChannelMapping with per-stream channel lists enabling arbitrary channel mixes for record/playback.");
            richTextBox1.SelectionBullet = false;
            Add("");

            // ------------------------------------------------------------

            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("Changes for v6.2 (2024)");
            Add("");

            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Support for Visual Studio 2022 v17.9+.");
            Add("Support for .NET 7 and .NET 8.");
            Add("Updated support for TeeChart v2024 series.");
            Add("Updated for Dew.Math v6.2.");
            richTextBox1.SelectionBullet = false;
            Add("");

            // ------------------------------------------------------------

            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("Changes for v6.1 (2022)");
            Add("");

            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Android 11 tagged pointer compatibility (for .NET platforms targeting Android).");
            richTextBox1.SelectionBullet = false;
            Add("");

            // ------------------------------------------------------------

            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("Changes for v6.0 (2020-2021)");
            Add("");

            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Initial DSP Master release for .NET Core / .NET 5 rewritten fully in C#.");
            Add("Support for Windows, Linux, macOS targets depending on platform audio backend.");
            Add("Enhanced TSignalCoreAudioIn / TSignalCoreAudioOut for low-latency streaming across platforms.");
            Add("Matched core functionality with MtxVec v6 feature set.");
            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in v6");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("Rewritten in C# with support for .NET Core 5.");
            Add("All the functions/components can work either with double and/or single precision.");
            Add("Added FloatPrecision property to TSignal/TSignalList and TSpectrum/TSpectrumList and descendants.");
            Add("FloatPrecision is selectable also at run-time.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in v5");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("IIR Filtering based on second order sections now allows filtering with much more extreem filter designs and stability up to order of 50.");
            Add("Added new overload for ButterFilter, ChebyshevIFilter, ChebyshevIIFilter and  EllipticFilter to more expose bi-quad (second order section) capabilities.");
            Add("Fixed TSIgnalFilter IIR filtering.");
            Add("New functions SignalUtils.IirInitBQ and LinearSystems.ZeroPoleToSOS.");
            Add("Long 64bit record length for files in TSignalWrite.");
            Add("TSignalFilter has been updated to make use second order sections for IIR filtering.");
            Add("Standard and Extended Kalman filtering algorithms.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");

            richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in version 4");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;
            Add("New inverse FFT based FIR filter designer.");
            Add("Standard and extended Kalman filter implementation.");
            Add("Steinberg ASIO interface for real time audio effects.");
            Add("New pink, gray and violate noise generators.");
            Add("Support for Intel AVX instruction set.");           
            Add("Support for VS.NET 2010 and .NET framework v4");
            Add("Support for TeeChart 2010.NET");
            Add("Fixed bug for triangular signal generator.");
            Add("TSignalRead bug fix for Windows 7.");
            Add("Bug fix for AxisTool auto scaling.");
            Add("Fixed the component editor for TSpectrumAnalyzer.");
            Add("Enabled ability to store settings for filters, signal generator and bands defined at design time.");
            Add("Substantial improvements to the design-time experience.");
            Add("Added sound recording and playback examples to the demo.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");
            
            richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
            richTextBox1.SelectionColor = Color.FromArgb(51, 51, 153);
            Add("New features in version 3");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.BulletIndent = 10;

            Add("Updated to support Visual Studio 2008 and latest .NET libraries");
            Add("Support for TeeChart.NET v3");
            Add("Substantially increased number of native C# components");
            Add("Reduced distribution size.");
            Add("Support for updated Intel IPP v5.2 and consequently Core 2 Duo optimized.");
            Add("HtmlHelp 2 format support added. Now F1 finally works again from code and components in VS.IDE.");
            Add("All code examples now also have C# examples.");
            Add("All code examples in the help have been recreated with support for Vector/Matrix expressions.");
            Add("Demo updated with Vector/Matrix syntax.");
            Add("New set (hundreds) of true color 24x24 and 16x16 icons for components to support newer IDE tool palette.");           
            Add("Superfast arbitrary factor rate converter component.");
            Add("TSignalBuffer component had some bugs fixed.");
            Add("TSignal.Pull methods are completely rewritten. It is now possible to build much more complex processing pipes with much less code.");
            Add("Fixed a bug in Complex Cepstrum.");
            Add("SignalChart and SpectrumChart now accept multiple inputs. Same component can be connected to the same chart more than once or to multiple charts at the same time with centralized redraw control.");
            Add("TSignalRead.RecordPositon now calls TSignal.Update.");
            Add("Fixed a bug with TSignalIn for mono signal recordings.");
            Add("Fixed onStart and OnStop events for the TSignalIn and TSignalOut.");
            Add("Fixed the Report generation for TSpectrumAnalyzer and others.");
            Add("Fixed Logarithmic property for TSpectrumAnalyzer. It is now possible to toggle between logarithmic and linear scale for averaged spectrums without the need to perform the averaging again.");
            Add("Fixed a bug for TSignalGeneratorDialog where it did not store the changes made.");
            Add("TAnalysisList now has a Continuous property.");
            Add("Reset method has been added to all filtering components, and allows delay lines to be reset to zero.");
            richTextBox1.SelectionBullet = false;
            richTextBox1.BulletIndent = 10;
            Add("");

//			richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, 10, FontStyle.Bold);
			richTextBox1.SelectionFont = new Font(richTextBox1.Font.FontFamily, 12, richTextBox1.Font.Style);
			richTextBox1.SelectionColor = Color.FromArgb(51,51,153);
			Add("New features in version 2");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.BulletIndent = 10;
			Add("Arbitrary FFT length for 1D and 2D transforms.");
			Add("Support for SSE3 instruction set.");
			Add("Intel SPL interface replaced with support for IPP library.");
			Add("Substantial increase in number of optimized primitive functions " +
				"and methods via MtxVec v2.");
			Add("Many new \"multi-channel\" list components.");
			Add("Improved TSignalFile with several new properties.");
			Add("Support for .NET");
			Add("New TSignalStoreBuffer component.");
			Add("New TSignalEnvelopeDetector component.");
			Add("New connection mechanism for SpectrumChart and SignalChart.");
			Add("TSignalRead component editor.");
			Add("Minor bug fixes.");
			Add("Improved piping mechanism for data streaming.");
			Add("Substantially improved range checking and programmer safety.");
			richTextBox1.SelectionBullet = false;
			richTextBox1.BulletIndent = 10;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = SystemColors.WindowText;
            richTextBox1.Size = new Size(931, 690);
            // 
            // WhatIsNewForm
            // 
            AutoScaleBaseSize = new Size(6, 16);
            ClientSize = new Size(931, 690);
            Name = "WhatIsNewForm";
            Load += WhatIsNewForm_Load;
            ResumeLayout(false);

        }
        #endregion

        private void WhatIsNewForm_Load(object sender, EventArgs e)
        {

        }
	}
}

