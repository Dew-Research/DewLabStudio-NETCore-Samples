namespace DSPDemo {
	partial class RateConvertForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RateConvertForm));
            Dew.Signal.Tee.SignalTeeItem signalTeeItem1 = new Dew.Signal.Tee.SignalTeeItem();
            Dew.Signal.Tee.SignalTeeItem signalTeeItem2 = new Dew.Signal.Tee.SignalTeeItem();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem1 = new Dew.Signal.Tee.SpectrumTeeItem();
            Dew.Signal.Tee.SpectrumTeeItem spectrumTeeItem2 = new Dew.Signal.Tee.SpectrumTeeItem();
            this.signalStoreBuffer = new Dew.Signal.TSignalStoreBuffer(this.components);
            this.signalRateConverter = new Dew.Signal.TSignalRateConverter(this.components);
            this.signalGenerator = new Dew.Signal.TSignalGenerator(this.components);
            this.convertedSignal = new Steema.TeeChart.Styles.FastLine();
            this.signalStoreBuffer1 = new Dew.Signal.TSignalStoreBuffer(this.components);
            this.originalSignal = new Steema.TeeChart.Styles.FastLine();
            this.spectrumAnalyzer = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.convertedSpectrum = new Steema.TeeChart.Styles.FastLine();
            this.spectrumAnalyzer1 = new Dew.Signal.TSpectrumAnalyzer(this.components);
            this.originalSpectrum = new Steema.TeeChart.Styles.FastLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.benchmarkButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rateFactorEdit = new Dew.Math.Controls.FloatEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signalChart = new Dew.Signal.Tee.SignalChart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.spectrumChart = new Dew.Signal.Tee.SpectrumChart();
            this.signalGeneratorDialog = new Dew.Signal.Editors.SignalGeneratorDialog(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).BeginInit();
            this.SuspendLayout();
            // 
            // signalStoreBuffer
            // 
            this.signalStoreBuffer.ActualBufferSize = 0;
            this.signalStoreBuffer.BandwidthL = 0D;
            this.signalStoreBuffer.BlockAssign = false;
            this.signalStoreBuffer.Complex = false;
            this.signalStoreBuffer.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalStoreBuffer.FloatPrecisionLock = false;
            this.signalStoreBuffer.Input = this.signalRateConverter;
            this.signalStoreBuffer.IsDouble = true;
            this.signalStoreBuffer.Length = 0;
            this.signalStoreBuffer.Name = null;
            // 
            // signalRateConverter
            // 
            this.signalRateConverter.BandwidthL = 0D;
            this.signalRateConverter.BlockAssign = false;
            this.signalRateConverter.Complex = false;
            this.signalRateConverter.Factor = 1.25D;
            this.signalRateConverter.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalRateConverter.FloatPrecisionLock = false;
            this.signalRateConverter.HalfBand = false;
            this.signalRateConverter.Input = this.signalGenerator;
            this.signalRateConverter.IsDouble = true;
            this.signalRateConverter.Name = null;
            this.signalRateConverter.Ripple = 1E-05D;
            // 
            // signalGenerator
            // 
            this.signalGenerator.BandwidthL = 0D;
            this.signalGenerator.BlockAssign = false;
            this.signalGenerator.Complex = false;
            this.signalGenerator.ComputeMessage = "";
            this.signalGenerator.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalGenerator.FloatPrecisionLock = false;
            this.signalGenerator.Input = null;
            this.signalGenerator.IsDouble = true;
            this.signalGenerator.Length = 1024;
            this.signalGenerator.Name = null;
            this.signalGenerator.SamplingFrequency = 100D;
            this.signalGenerator.Sounds.TemplateIndex = 0;
            this.signalGenerator.Sounds.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.signalGenerator.OnParameterUpdateEvent += new Dew.Math.TNotifyEvent(this.signalGenerator_OnParameterUpdate);
            // 
            // convertedSignal
            // 
            this.convertedSignal.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.convertedSignal.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSignal.Legend.Brush.Color = System.Drawing.Color.White;
            this.convertedSignal.Legend.Brush.Solid = true;
            this.convertedSignal.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSignal.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.convertedSignal.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.convertedSignal.Legend.Font.Brush.Solid = true;
            this.convertedSignal.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSignal.Legend.Font.Shadow.Brush.Solid = true;
            this.convertedSignal.Legend.Font.Shadow.Brush.Visible = true;
            this.convertedSignal.Legend.Font.Size = 8;
            this.convertedSignal.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSignal.Legend.ImageBevel.Brush.Solid = true;
            this.convertedSignal.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSignal.Legend.Shadow.Brush.Solid = true;
            this.convertedSignal.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSignal.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSignal.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.convertedSignal.Marks.Brush.Solid = true;
            this.convertedSignal.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSignal.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.convertedSignal.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.convertedSignal.Marks.Font.Brush.Solid = true;
            this.convertedSignal.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSignal.Marks.Font.Shadow.Brush.Solid = true;
            this.convertedSignal.Marks.Font.Shadow.Brush.Visible = true;
            this.convertedSignal.Marks.Font.Size = 8;
            this.convertedSignal.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSignal.Marks.ImageBevel.Brush.Solid = true;
            this.convertedSignal.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.convertedSignal.Marks.Shadow.Brush.Solid = true;
            this.convertedSignal.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSignal.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.convertedSignal.Marks.Symbol.Brush.Solid = true;
            this.convertedSignal.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSignal.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.convertedSignal.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSignal.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSignal.Marks.Symbol.Shadow.Brush.Solid = true;
            this.convertedSignal.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSignal.Marks.TailParams.Margin = 0F;
            this.convertedSignal.Marks.TailParams.PointerHeight = 8D;
            this.convertedSignal.Marks.TailParams.PointerWidth = 8D;
            this.convertedSignal.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.convertedSignal.Title = "Converted signal";
            this.convertedSignal.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.convertedSignal.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.convertedSignal.XValues.DataMember = "X";
            this.convertedSignal.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.convertedSignal.YValues.DataMember = "Y";
            // 
            // signalStoreBuffer1
            // 
            this.signalStoreBuffer1.ActualBufferSize = 0;
            this.signalStoreBuffer1.BandwidthL = 0D;
            this.signalStoreBuffer1.BlockAssign = false;
            this.signalStoreBuffer1.Complex = false;
            this.signalStoreBuffer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.signalStoreBuffer1.FloatPrecisionLock = false;
            this.signalStoreBuffer1.Input = this.signalGenerator;
            this.signalStoreBuffer1.IsDouble = true;
            this.signalStoreBuffer1.Length = 0;
            this.signalStoreBuffer1.Name = null;
            // 
            // originalSignal
            // 
            this.originalSignal.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.originalSignal.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSignal.Legend.Brush.Color = System.Drawing.Color.White;
            this.originalSignal.Legend.Brush.Solid = true;
            this.originalSignal.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSignal.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.originalSignal.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.originalSignal.Legend.Font.Brush.Solid = true;
            this.originalSignal.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSignal.Legend.Font.Shadow.Brush.Solid = true;
            this.originalSignal.Legend.Font.Shadow.Brush.Visible = true;
            this.originalSignal.Legend.Font.Size = 8;
            this.originalSignal.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSignal.Legend.ImageBevel.Brush.Solid = true;
            this.originalSignal.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSignal.Legend.Shadow.Brush.Solid = true;
            this.originalSignal.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSignal.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSignal.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.originalSignal.Marks.Brush.Solid = true;
            this.originalSignal.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSignal.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.originalSignal.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.originalSignal.Marks.Font.Brush.Solid = true;
            this.originalSignal.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSignal.Marks.Font.Shadow.Brush.Solid = true;
            this.originalSignal.Marks.Font.Shadow.Brush.Visible = true;
            this.originalSignal.Marks.Font.Size = 8;
            this.originalSignal.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSignal.Marks.ImageBevel.Brush.Solid = true;
            this.originalSignal.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.originalSignal.Marks.Shadow.Brush.Solid = true;
            this.originalSignal.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSignal.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.originalSignal.Marks.Symbol.Brush.Solid = true;
            this.originalSignal.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSignal.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.originalSignal.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSignal.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSignal.Marks.Symbol.Shadow.Brush.Solid = true;
            this.originalSignal.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSignal.Marks.TailParams.Margin = 0F;
            this.originalSignal.Marks.TailParams.PointerHeight = 8D;
            this.originalSignal.Marks.TailParams.PointerWidth = 8D;
            this.originalSignal.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.originalSignal.Title = "Original signal";
            this.originalSignal.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.originalSignal.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.originalSignal.XValues.DataMember = "X";
            this.originalSignal.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.originalSignal.YValues.DataMember = "Y";
            // 
            // spectrumAnalyzer
            // 
            this.spectrumAnalyzer.Bands.TemplateIndex = -1;
            this.spectrumAnalyzer.Bands.Templates = new Dew.Signal.TStringStreamList(System.Convert.FromBase64String("AAAAAA=="));
            this.spectrumAnalyzer.BlockAssign = false;
            this.spectrumAnalyzer.Complex = false;
            this.spectrumAnalyzer.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.spectrumAnalyzer.FloatPrecisionLock = false;
            this.spectrumAnalyzer.Input = this.signalStoreBuffer;
            this.spectrumAnalyzer.IsDouble = true;
            this.spectrumAnalyzer.Logarithmic = true;
            this.spectrumAnalyzer.LogBase = 0D;
            this.spectrumAnalyzer.LogScale = 0D;
            this.spectrumAnalyzer.LogSpan = Dew.Signal.TLogSpan.ls200;
            this.spectrumAnalyzer.Name = null;
            this.spectrumAnalyzer.Output = null;
            this.spectrumAnalyzer.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.spectrumAnalyzer.Report.AmplitudeFormat = null;
            this.spectrumAnalyzer.Report.FrequencyFormat = null;
            this.spectrumAnalyzer.Report.PhaseFormat = null;
            this.spectrumAnalyzer.Report.UseTab = false;
            this.spectrumAnalyzer.SamplingFrequency = 64D;
            this.spectrumAnalyzer.SidelobeAtt = 100D;
            this.spectrumAnalyzer.SpectrumScale = 0D;
            this.spectrumAnalyzer.Stats.Averaged = 0;
            this.spectrumAnalyzer.Stats.Averages = 30;
            this.spectrumAnalyzer.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            this.spectrumAnalyzer.ZeroPadding = 8;
            // 
            // convertedSpectrum
            // 
            this.convertedSpectrum.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
            this.convertedSpectrum.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Brush.Color = System.Drawing.Color.White;
            this.convertedSpectrum.Legend.Brush.Solid = true;
            this.convertedSpectrum.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.convertedSpectrum.Legend.Font.Brush.Solid = true;
            this.convertedSpectrum.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSpectrum.Legend.Font.Shadow.Brush.Solid = true;
            this.convertedSpectrum.Legend.Font.Shadow.Brush.Visible = true;
            this.convertedSpectrum.Legend.Font.Size = 8;
            this.convertedSpectrum.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSpectrum.Legend.ImageBevel.Brush.Solid = true;
            this.convertedSpectrum.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSpectrum.Legend.Shadow.Brush.Solid = true;
            this.convertedSpectrum.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSpectrum.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.convertedSpectrum.Marks.Brush.Solid = true;
            this.convertedSpectrum.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.convertedSpectrum.Marks.Font.Brush.Solid = true;
            this.convertedSpectrum.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSpectrum.Marks.Font.Shadow.Brush.Solid = true;
            this.convertedSpectrum.Marks.Font.Shadow.Brush.Visible = true;
            this.convertedSpectrum.Marks.Font.Size = 8;
            this.convertedSpectrum.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSpectrum.Marks.ImageBevel.Brush.Solid = true;
            this.convertedSpectrum.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.convertedSpectrum.Marks.Shadow.Brush.Solid = true;
            this.convertedSpectrum.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.convertedSpectrum.Marks.Symbol.Brush.Solid = true;
            this.convertedSpectrum.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.convertedSpectrum.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.convertedSpectrum.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.convertedSpectrum.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.convertedSpectrum.Marks.Symbol.Shadow.Brush.Solid = true;
            this.convertedSpectrum.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.convertedSpectrum.Marks.TailParams.Margin = 0F;
            this.convertedSpectrum.Marks.TailParams.PointerHeight = 8D;
            this.convertedSpectrum.Marks.TailParams.PointerWidth = 8D;
            this.convertedSpectrum.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.convertedSpectrum.Title = "Converted spectrum";
            this.convertedSpectrum.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.convertedSpectrum.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.convertedSpectrum.XValues.DataMember = "X";
            this.convertedSpectrum.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.convertedSpectrum.YValues.DataMember = "Y";
            // 
            // spectrumAnalyzer1
            // 
            this.spectrumAnalyzer1.Bands.TemplateIndex = -1;
            this.spectrumAnalyzer1.BlockAssign = false;
            this.spectrumAnalyzer1.Complex = false;
            this.spectrumAnalyzer1.FloatPrecision = Dew.Math.TMtxFloatPrecision.mvDouble;
            this.spectrumAnalyzer1.FloatPrecisionLock = false;
            this.spectrumAnalyzer1.Input = this.signalStoreBuffer1;
            this.spectrumAnalyzer1.IsDouble = true;
            this.spectrumAnalyzer1.Logarithmic = true;
            this.spectrumAnalyzer1.LogBase = 0D;
            this.spectrumAnalyzer1.LogScale = 0D;
            this.spectrumAnalyzer1.LogSpan = Dew.Signal.TLogSpan.ls200;
            this.spectrumAnalyzer1.Name = null;
            this.spectrumAnalyzer1.Output = null;
            this.spectrumAnalyzer1.Peaks.Interpolation.RecursiveHarmonics = Dew.Signal.TRecursiveHarmonics.rhNone;
            this.spectrumAnalyzer1.Report.AmplitudeFormat = null;
            this.spectrumAnalyzer1.Report.FrequencyFormat = null;
            this.spectrumAnalyzer1.Report.PhaseFormat = null;
            this.spectrumAnalyzer1.Report.UseTab = false;
            this.spectrumAnalyzer1.SamplingFrequency = 64D;
            this.spectrumAnalyzer1.SidelobeAtt = 100D;
            this.spectrumAnalyzer1.SpectrumScale = 0D;
            this.spectrumAnalyzer1.Stats.Averaged = 0;
            this.spectrumAnalyzer1.Stats.Averages = 30;
            this.spectrumAnalyzer1.Window = Dew.Signal.TSignalWindowType.wtKaiser;
            this.spectrumAnalyzer1.ZeroPadding = 8;
            // 
            // originalSpectrum
            // 
            this.originalSpectrum.Color = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
            this.originalSpectrum.ColorEach = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSpectrum.Legend.Brush.Color = System.Drawing.Color.White;
            this.originalSpectrum.Legend.Brush.Solid = true;
            this.originalSpectrum.Legend.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSpectrum.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.originalSpectrum.Legend.Font.Brush.Color = System.Drawing.Color.Black;
            this.originalSpectrum.Legend.Font.Brush.Solid = true;
            this.originalSpectrum.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSpectrum.Legend.Font.Shadow.Brush.Solid = true;
            this.originalSpectrum.Legend.Font.Shadow.Brush.Visible = true;
            this.originalSpectrum.Legend.Font.Size = 8;
            this.originalSpectrum.Legend.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSpectrum.Legend.ImageBevel.Brush.Solid = true;
            this.originalSpectrum.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Legend.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSpectrum.Legend.Shadow.Brush.Solid = true;
            this.originalSpectrum.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSpectrum.LinePen.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSpectrum.Marks.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.originalSpectrum.Marks.Brush.Solid = true;
            this.originalSpectrum.Marks.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSpectrum.Marks.Font.Bold = false;
            // 
            // 
            // 
            this.originalSpectrum.Marks.Font.Brush.Color = System.Drawing.Color.Black;
            this.originalSpectrum.Marks.Font.Brush.Solid = true;
            this.originalSpectrum.Marks.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSpectrum.Marks.Font.Shadow.Brush.Solid = true;
            this.originalSpectrum.Marks.Font.Shadow.Brush.Visible = true;
            this.originalSpectrum.Marks.Font.Size = 8;
            this.originalSpectrum.Marks.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSpectrum.Marks.ImageBevel.Brush.Solid = true;
            this.originalSpectrum.Marks.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Shadow.Brush.Color = System.Drawing.Color.Gray;
            this.originalSpectrum.Marks.Shadow.Brush.Solid = true;
            this.originalSpectrum.Marks.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Symbol.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.originalSpectrum.Marks.Symbol.Brush.Color = System.Drawing.Color.White;
            this.originalSpectrum.Marks.Symbol.Brush.Solid = true;
            this.originalSpectrum.Marks.Symbol.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Symbol.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.originalSpectrum.Marks.Symbol.ImageBevel.Brush.Solid = true;
            this.originalSpectrum.Marks.Symbol.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.originalSpectrum.Marks.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.originalSpectrum.Marks.Symbol.Shadow.Brush.Solid = true;
            this.originalSpectrum.Marks.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.originalSpectrum.Marks.TailParams.Margin = 0F;
            this.originalSpectrum.Marks.TailParams.PointerHeight = 8D;
            this.originalSpectrum.Marks.TailParams.PointerWidth = 8D;
            this.originalSpectrum.OriginalCursor = Steema.TeeChart.Drawing.Cursor.Current;
            this.originalSpectrum.Title = "Original spectrum";
            this.originalSpectrum.TreatNulls = Steema.TeeChart.Styles.TreatNullsStyle.Ignore;
            this.originalSpectrum.UseExtendedNumRange = false;
            // 
            // 
            // 
            this.originalSpectrum.XValues.DataMember = "X";
            this.originalSpectrum.XValues.Order = Steema.TeeChart.Styles.ValueListOrder.Ascending;
            // 
            // 
            // 
            this.originalSpectrum.YValues.DataMember = "Y";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.benchmarkButton);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rateFactorEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 50);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(825, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // benchmarkButton
            // 
            this.benchmarkButton.Location = new System.Drawing.Point(301, 15);
            this.benchmarkButton.Name = "benchmarkButton";
            this.benchmarkButton.Size = new System.Drawing.Size(111, 23);
            this.benchmarkButton.TabIndex = 4;
            this.benchmarkButton.Text = "Benchmark";
            this.benchmarkButton.UseVisualStyleBackColor = true;
            this.benchmarkButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.Location = new System.Drawing.Point(744, 15);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Signal generator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rateFactorEdit
            // 
            this.rateFactorEdit.Increment = "0.01";
            this.rateFactorEdit.Location = new System.Drawing.Point(82, 18);
            this.rateFactorEdit.MaxValue = "1000";
            this.rateFactorEdit.Name = "rateFactorEdit";
            this.rateFactorEdit.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.rateFactorEdit.Scientific = false;
            this.rateFactorEdit.Size = new System.Drawing.Size(76, 20);
            this.rateFactorEdit.TabIndex = 3;
            this.rateFactorEdit.Value = "1.00";
            this.rateFactorEdit.Click += new System.EventHandler(this.rateFactorEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate factor:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(912, 96);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.signalChart);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.spectrumChart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 410);
            this.panel2.TabIndex = 5;
            // 
            // signalChart
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Grid.DrawEvery = 1;
            this.signalChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Bottom.Labels.Font.Size = 9;
            this.signalChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.Bottom.Title.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Title.Brush.Visible = true;
            this.signalChart.Axes.Bottom.Title.Caption = "Time [s]";
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Bottom.Title.Font.Size = 11;
            this.signalChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.signalChart.Axes.Bottom.Title.Lines = new string[] {
        "Time [s]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.Depth.Labels.Brush.Solid = true;
            this.signalChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Depth.Labels.Font.Size = 9;
            this.signalChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.Depth.Title.Brush.Solid = true;
            this.signalChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Depth.Title.Font.Size = 11;
            this.signalChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.signalChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.DepthTop.Title.Font.Size = 11;
            this.signalChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.Left.Labels.Brush.Solid = true;
            this.signalChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Left.Labels.Font.Size = 9;
            this.signalChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.Left.Title.Brush.Solid = true;
            this.signalChart.Axes.Left.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Left.Title.Font.Size = 11;
            this.signalChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.Right.Labels.Brush.Solid = true;
            this.signalChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Right.Labels.Font.Size = 9;
            this.signalChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.Right.Title.Brush.Solid = true;
            this.signalChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Right.Title.Font.Size = 11;
            this.signalChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Axes.Top.Labels.Brush.Solid = true;
            this.signalChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.signalChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Top.Labels.Font.Size = 9;
            this.signalChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Axes.Top.Title.Brush.Solid = true;
            this.signalChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.signalChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Axes.Top.Title.Font.Size = 11;
            this.signalChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.signalChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.signalChart.Color = System.Drawing.Color.White;
            this.signalChart.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Footer.Brush.Solid = true;
            this.signalChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart.Footer.Font.Brush.Solid = true;
            this.signalChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Footer.Font.Shadow.Brush.Solid = true;
            this.signalChart.Footer.Font.Shadow.Brush.Visible = true;
            this.signalChart.Footer.Font.Size = 8;
            this.signalChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Footer.ImageBevel.Brush.Solid = true;
            this.signalChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Footer.Shadow.Brush.Solid = true;
            this.signalChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart.Header.Brush.Solid = true;
            this.signalChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.Header.Font.Brush.Solid = true;
            this.signalChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Header.Font.Shadow.Brush.Solid = true;
            this.signalChart.Header.Font.Shadow.Brush.Visible = true;
            this.signalChart.Header.Font.Size = 12;
            this.signalChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Header.ImageBevel.Brush.Solid = true;
            this.signalChart.Header.ImageBevel.Brush.Visible = true;
            this.signalChart.Header.Lines = new string[] {
        "Time signal"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart.Header.Shadow.Brush.Solid = true;
            this.signalChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Legend.Brush.Solid = true;
            this.signalChart.Legend.Brush.Visible = true;
            this.signalChart.Legend.ActiveStyle = Steema.TeeChart.LegendActiveStyles.CheckBox;
            // 
            // 
            // 
            this.signalChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signalChart.Legend.Font.Brush.Solid = true;
            this.signalChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Legend.Font.Shadow.Brush.Solid = true;
            this.signalChart.Legend.Font.Shadow.Brush.Visible = true;
            this.signalChart.Legend.Font.Size = 9;
            this.signalChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Legend.ImageBevel.Brush.Solid = true;
            this.signalChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.signalChart.Legend.Shadow.Brush.Solid = true;
            this.signalChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.signalChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Legend.Title.Brush.Solid = true;
            this.signalChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.signalChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.signalChart.Legend.Title.Font.Brush.Solid = true;
            this.signalChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.signalChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.signalChart.Legend.Title.Font.Size = 8;
            this.signalChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.signalChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Legend.Title.Shadow.Brush.Solid = true;
            this.signalChart.Legend.Title.Shadow.Brush.Visible = true;
            this.signalChart.Location = new System.Drawing.Point(0, 235);
            this.signalChart.Name = "signalChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Panel.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Panel.Brush.Solid = true;
            this.signalChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Panel.ImageBevel.Brush.Solid = true;
            this.signalChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Panel.Shadow.Brush.Solid = true;
            this.signalChart.Panel.Shadow.Brush.Visible = true;
            this.signalChart.Series.Add(this.convertedSignal);
            this.signalChart.Series.Add(this.originalSignal);
            signalTeeItem1.Caption = null;
            signalTeeItem1.Input = this.signalStoreBuffer;
            signalTeeItem1.Inputs = null;
            signalTeeItem1.InputsItemIndex = 0;
            signalTeeItem1.Series = this.convertedSignal;
            signalTeeItem1.SeriesName = "Converted signal";
            signalTeeItem2.Caption = null;
            signalTeeItem2.Input = this.signalStoreBuffer1;
            signalTeeItem2.Inputs = null;
            signalTeeItem2.InputsItemIndex = 0;
            signalTeeItem2.Series = this.originalSignal;
            signalTeeItem2.SeriesName = "Original signal";
            this.signalChart.Signals.Add(signalTeeItem1);
            this.signalChart.Signals.Add(signalTeeItem2);
            this.signalChart.Size = new System.Drawing.Size(912, 175);
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.SubFooter.Brush.Solid = true;
            this.signalChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.signalChart.SubFooter.Font.Brush.Solid = true;
            this.signalChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.signalChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.signalChart.SubFooter.Font.Size = 8;
            this.signalChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.signalChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.SubFooter.Shadow.Brush.Solid = true;
            this.signalChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signalChart.SubHeader.Brush.Solid = true;
            this.signalChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.signalChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.signalChart.SubHeader.Font.Brush.Solid = true;
            this.signalChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.signalChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.signalChart.SubHeader.Font.Size = 12;
            this.signalChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.signalChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signalChart.SubHeader.Shadow.Brush.Solid = true;
            this.signalChart.SubHeader.Shadow.Brush.Visible = true;
            this.signalChart.TabIndex = 2;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.signalChart.Walls.Back.Brush.Solid = true;
            this.signalChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.signalChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Walls.Back.Shadow.Brush.Solid = true;
            this.signalChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.signalChart.Walls.Bottom.Brush.Solid = true;
            this.signalChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.signalChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.signalChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart.Walls.Left.Brush.Solid = true;
            this.signalChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.signalChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Walls.Left.Shadow.Brush.Solid = true;
            this.signalChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.signalChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.signalChart.Walls.Right.Brush.Solid = true;
            this.signalChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.signalChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.signalChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.signalChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.signalChart.Walls.Right.Shadow.Brush.Solid = true;
            this.signalChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.signalChart.Zoom.Animated = true;
            // 
            // 
            // 
            this.signalChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.signalChart.Zoom.Brush.Solid = true;
            this.signalChart.Zoom.Brush.Visible = false;
            this.signalChart.Zoom.FullRepaint = true;
            // 
            // 
            // 
            this.signalChart.Zoom.Pen.Visible = true;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 232);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(912, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // spectrumChart
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Grid.DrawEvery = 1;
            this.spectrumChart.Axes.Bottom.Grid.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.Bottom.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.Bottom.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Bottom.Labels.Font.Size = 9;
            this.spectrumChart.Axes.Bottom.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Bottom.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.Bottom.Title.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Title.Brush.Visible = true;
            this.spectrumChart.Axes.Bottom.Title.Caption = "Frequency [Hz]";
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.Bottom.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Bottom.Title.Font.Size = 11;
            this.spectrumChart.Axes.Bottom.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Title.ImageBevel.Brush.Visible = true;
            this.spectrumChart.Axes.Bottom.Title.Lines = new string[] {
        "Frequency [Hz]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Bottom.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Bottom.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Bottom.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.Depth.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.Depth.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Depth.Labels.Font.Size = 9;
            this.spectrumChart.Axes.Depth.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Depth.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.Depth.Title.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.Depth.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Depth.Title.Font.Size = 11;
            this.spectrumChart.Axes.Depth.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Depth.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Depth.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Depth.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Depth.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.DepthTop.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.DepthTop.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.DepthTop.Labels.Font.Size = 9;
            this.spectrumChart.Axes.DepthTop.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.DepthTop.Title.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.DepthTop.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.DepthTop.Title.Font.Size = 11;
            this.spectrumChart.Axes.DepthTop.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.DepthTop.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.DepthTop.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.DepthTop.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.AxisPen.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Grid.DrawEvery = 1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.Left.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.Left.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Left.Labels.Font.Size = 9;
            this.spectrumChart.Axes.Left.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Left.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Left.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Angle = 90;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.Left.Title.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Title.Brush.Visible = true;
            this.spectrumChart.Axes.Left.Title.Caption = "Amplitude [dB]";
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.Left.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Left.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Left.Title.Font.Size = 11;
            this.spectrumChart.Axes.Left.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Left.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Title.ImageBevel.Brush.Visible = true;
            this.spectrumChart.Axes.Left.Title.Lines = new string[] {
        "Amplitude [dB]"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Left.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Left.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Left.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.Right.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.Right.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Right.Labels.Font.Size = 9;
            this.spectrumChart.Axes.Right.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Right.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Right.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Angle = 270;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.Right.Title.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.Right.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Right.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Right.Title.Font.Size = 11;
            this.spectrumChart.Axes.Right.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Right.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Right.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Right.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Right.Title.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Axes.Top.Labels.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Labels.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Axes.Top.Labels.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Labels.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Labels.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Top.Labels.Font.Size = 9;
            this.spectrumChart.Axes.Top.Labels.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Top.Labels.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Labels.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Labels.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Top.Labels.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Labels.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Angle = 0;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Axes.Top.Title.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Axes.Top.Title.Font.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Top.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Axes.Top.Title.Font.Size = 11;
            this.spectrumChart.Axes.Top.Title.Font.SizeFloat = 11F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Axes.Top.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Axes.Top.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Axes.Top.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Axes.Top.Title.Shadow.Brush.Visible = true;
            this.spectrumChart.Color = System.Drawing.Color.White;
             
            this.spectrumChart.Dock = System.Windows.Forms.DockStyle.Top;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Footer.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Footer.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Footer.Brush.Solid = true;
            this.spectrumChart.Footer.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Footer.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Footer.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart.Footer.Font.Brush.Solid = true;
            this.spectrumChart.Footer.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Footer.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Footer.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Footer.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Footer.Font.Size = 8;
            this.spectrumChart.Footer.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Footer.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Footer.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Footer.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Footer.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Footer.Shadow.Brush.Solid = true;
            this.spectrumChart.Footer.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Header.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Header.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart.Header.Brush.Solid = true;
            this.spectrumChart.Header.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Header.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Header.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.Header.Font.Brush.Solid = true;
            this.spectrumChart.Header.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Header.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Header.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Header.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Header.Font.Size = 12;
            this.spectrumChart.Header.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Header.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Header.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Header.ImageBevel.Brush.Visible = true;
            this.spectrumChart.Header.Lines = new string[] {
        "Frequency spectrum"};
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Header.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart.Header.Shadow.Brush.Solid = true;
            this.spectrumChart.Header.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Legend.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Legend.Brush.Solid = true;
            this.spectrumChart.Legend.Brush.Visible = true;
            this.spectrumChart.Legend.ActiveStyle = Steema.TeeChart.LegendActiveStyles.CheckBox;
            // 
            // 
            // 
            this.spectrumChart.Legend.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.Legend.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.spectrumChart.Legend.Font.Brush.Solid = true;
            this.spectrumChart.Legend.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Legend.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Legend.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Legend.Font.Size = 9;
            this.spectrumChart.Legend.Font.SizeFloat = 9F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Legend.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Legend.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.spectrumChart.Legend.Shadow.Brush.Solid = true;
            this.spectrumChart.Legend.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Symbol.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Legend.Symbol.Shadow.Brush.Solid = true;
            this.spectrumChart.Legend.Symbol.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Legend.Title.Brush.Solid = true;
            this.spectrumChart.Legend.Title.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Font.Bold = true;
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Font.Brush.Color = System.Drawing.Color.Black;
            this.spectrumChart.Legend.Title.Font.Brush.Solid = true;
            this.spectrumChart.Legend.Title.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Legend.Title.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.Legend.Title.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.Legend.Title.Font.Size = 8;
            this.spectrumChart.Legend.Title.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Legend.Title.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Legend.Title.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Legend.Title.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Legend.Title.Shadow.Brush.Solid = true;
            this.spectrumChart.Legend.Title.Shadow.Brush.Visible = true;
            this.spectrumChart.Location = new System.Drawing.Point(0, 0);
            this.spectrumChart.Name = "spectrumChart";
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Panel.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Panel.Brush.Solid = true;
            this.spectrumChart.Panel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Panel.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Panel.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Panel.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Panel.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Panel.Shadow.Brush.Solid = true;
            this.spectrumChart.Panel.Shadow.Brush.Visible = true;
            this.spectrumChart.Series.Add(this.convertedSpectrum);
            this.spectrumChart.Series.Add(this.originalSpectrum);
            this.spectrumChart.Size = new System.Drawing.Size(912, 232);
            this.spectrumChart.SpectrumPart = Dew.Signal.Tee.SpectrumPart.sppAmplt;
            spectrumTeeItem1.Caption = null;
            spectrumTeeItem1.Input = this.spectrumAnalyzer;
            spectrumTeeItem1.Inputs = null;
            spectrumTeeItem1.InputsItemIndex = 0;
            spectrumTeeItem1.Series = this.convertedSpectrum;
            spectrumTeeItem1.SeriesName = "Converted spectrum";
            spectrumTeeItem2.Caption = null;
            spectrumTeeItem2.Input = this.spectrumAnalyzer1;
            spectrumTeeItem2.Inputs = null;
            spectrumTeeItem2.InputsItemIndex = 0;
            spectrumTeeItem2.Series = this.originalSpectrum;
            spectrumTeeItem2.SeriesName = "Original spectrum";
            this.spectrumChart.Spectrums.Add(spectrumTeeItem1);
            this.spectrumChart.Spectrums.Add(spectrumTeeItem2);
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.SubFooter.Brush.Solid = true;
            this.spectrumChart.SubFooter.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Font.Brush.Color = System.Drawing.Color.Red;
            this.spectrumChart.SubFooter.Font.Brush.Solid = true;
            this.spectrumChart.SubFooter.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.SubFooter.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.SubFooter.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.SubFooter.Font.Size = 8;
            this.spectrumChart.SubFooter.Font.SizeFloat = 8F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubFooter.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.SubFooter.ImageBevel.Brush.Solid = true;
            this.spectrumChart.SubFooter.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubFooter.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.SubFooter.Shadow.Brush.Solid = true;
            this.spectrumChart.SubFooter.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.spectrumChart.SubHeader.Brush.Solid = true;
            this.spectrumChart.SubHeader.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Font.Bold = false;
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Font.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.spectrumChart.SubHeader.Font.Brush.Solid = true;
            this.spectrumChart.SubHeader.Font.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Font.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.SubHeader.Font.Shadow.Brush.Solid = true;
            this.spectrumChart.SubHeader.Font.Shadow.Brush.Visible = true;
            this.spectrumChart.SubHeader.Font.Size = 12;
            this.spectrumChart.SubHeader.Font.SizeFloat = 12F;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubHeader.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.SubHeader.ImageBevel.Brush.Solid = true;
            this.spectrumChart.SubHeader.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.SubHeader.Shadow.Brush.Color = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spectrumChart.SubHeader.Shadow.Brush.Solid = true;
            this.spectrumChart.SubHeader.Shadow.Brush.Visible = true;
            this.spectrumChart.TabIndex = 0;
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Back.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Walls.Back.Brush.Color = System.Drawing.Color.Silver;
            this.spectrumChart.Walls.Back.Brush.Solid = true;
            this.spectrumChart.Walls.Back.Brush.Visible = false;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Back.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Walls.Back.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Walls.Back.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Back.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Walls.Back.Shadow.Brush.Solid = true;
            this.spectrumChart.Walls.Back.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Bottom.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Walls.Bottom.Brush.Color = System.Drawing.Color.White;
            this.spectrumChart.Walls.Bottom.Brush.Solid = true;
            this.spectrumChart.Walls.Bottom.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Bottom.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Walls.Bottom.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Walls.Bottom.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Bottom.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Walls.Bottom.Shadow.Brush.Solid = true;
            this.spectrumChart.Walls.Bottom.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Left.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Walls.Left.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart.Walls.Left.Brush.Solid = true;
            this.spectrumChart.Walls.Left.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Left.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Walls.Left.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Walls.Left.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Left.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Walls.Left.Shadow.Brush.Solid = true;
            this.spectrumChart.Walls.Left.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Right.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;
            // 
            // 
            // 
            this.spectrumChart.Walls.Right.Brush.Color = System.Drawing.Color.LightYellow;
            this.spectrumChart.Walls.Right.Brush.Solid = true;
            this.spectrumChart.Walls.Right.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Right.ImageBevel.Brush.Color = System.Drawing.Color.LightGray;
            this.spectrumChart.Walls.Right.ImageBevel.Brush.Solid = true;
            this.spectrumChart.Walls.Right.ImageBevel.Brush.Visible = true;
            // 
            // 
            // 
            // 
            // 
            // 
            this.spectrumChart.Walls.Right.Shadow.Brush.Color = System.Drawing.Color.DarkGray;
            this.spectrumChart.Walls.Right.Shadow.Brush.Solid = true;
            this.spectrumChart.Walls.Right.Shadow.Brush.Visible = true;
            // 
            // 
            // 
            this.spectrumChart.Zoom.Animated = true;
            // 
            // 
            // 
            this.spectrumChart.Zoom.Brush.Color = System.Drawing.Color.LightBlue;
            this.spectrumChart.Zoom.Brush.Solid = true;
            this.spectrumChart.Zoom.Brush.Visible = false;
            this.spectrumChart.Zoom.FullRepaint = true;
            this.spectrumChart.Zoom.History = true;
            // 
            // 
            // 
            this.spectrumChart.Zoom.Pen.Visible = true;
            // 
            // signalGeneratorDialog
            // 
            this.signalGeneratorDialog.BlockAssign = false;
            this.signalGeneratorDialog.Docking = false;
            this.signalGeneratorDialog.FormCaption = null;
            this.signalGeneratorDialog.Name = null;
            this.signalGeneratorDialog.RegistryPath = "\\Software\\Dew Research\\MtxVec";
            this.signalGeneratorDialog.ShowLive = false;
            this.signalGeneratorDialog.Source = this.signalGenerator;
            this.signalGeneratorDialog.SourceListIndex = 0;
            // 
            // RateConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "RateConvertForm";
            this.Text = "RateConvertForm";
            this.Load += new System.EventHandler(this.RateConvertForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.signalChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumChart)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private Dew.Math.Controls.FloatEdit rateFactorEdit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
		private Dew.Signal.Tee.SpectrumChart spectrumChart;
		private Dew.Signal.TSignalGenerator signalGenerator;
		private Dew.Signal.TSignalRateConverter signalRateConverter;
		private Dew.Signal.TSignalStoreBuffer signalStoreBuffer;
		private Dew.Signal.TSignalStoreBuffer signalStoreBuffer1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer1;
		private Dew.Signal.TSpectrumAnalyzer spectrumAnalyzer;
		private Dew.Signal.Tee.SignalChart signalChart;
		private Steema.TeeChart.Styles.FastLine convertedSpectrum;
		private Steema.TeeChart.Styles.FastLine originalSpectrum;
		private Steema.TeeChart.Styles.FastLine convertedSignal;
		private Steema.TeeChart.Styles.FastLine originalSignal;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button benchmarkButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Button button1;
		private Dew.Signal.Editors.SignalGeneratorDialog signalGeneratorDialog;
	}
}