using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MtxVecDemo {
	/// <summary>
	/// Summary description for WhatsNew.
	/// </summary>
	public class WhatsNewForm : System.Windows.Forms.Form {
		private System.Windows.Forms.RichTextBox richTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WhatsNewForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(371, 321);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // WhatsNewForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(371, 321);
            this.Controls.Add(this.richTextBox1);
            this.Name = "WhatsNewForm";
            this.Text = "WhatsNew";
            this.Load += new System.EventHandler(this.WhatsNewForm_Load);
            this.ResumeLayout(false);

		}
		#endregion
		private void Add(String s) {
			richTextBox1.SelectedText = s + "\n";
		}

		private void WhatsNewForm_Load(object sender, System.EventArgs e) {
			richTextBox1.Clear();

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);

            richTextBox1.SelectionIndent = 10;
            Add("List of new features in v6.0.4 (April 2021):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Support for net5.0-windows and net5.0 (cross-platforms) target frameworks.");
            Add("Ability to deploy applications without external dll dependencies.");
            Add("100% written in C# with source code available.");
            Add("Comprehensive in-source xml documentation comments.");
            Add("Hardware acceleration dlls updated for Intel MKL/IPP/C++ (release 2020 Update 1).");
            Add("TVec and TMtx have a new FloatPrecision property which defines run-time floating " +
                "point precision (single 32bit or double 64bit). Ideally, you can write code once " +
                "and have it then executed in either double or single precision. Additionally it is " +
                "possible to use the most suitable precision for math anywhere in the same application.");
            Add("New \"Capacity\" property for TVec and TMtx. Similar to TStringList.Capacity reduces the " +
                "need for memory re-allocations up to user specified size. Usefull for multi-threaded " +
                "algorithms where TVec and TMtx are not from object-cache.");
            Add("Most classes and routines updated to support user-selectable floating-point precision at run-time.");
            Add("Added TMtxVecInt.CountIntRange function.");
            Add("Added TVecInt.GroupCountIteration function.");
            Add("Added TVecInt.GroupCount function.");
            Add("Added TVec.GroupSum function.");
            Add("Added TVec.GroupSumIteration function.");            
            Add("Added TMtxVec.CapacityInElements");
            Add("Added TMtxVec.CapacityInBytes");
            Add("Added TVec.Hilbert algorithm variant.");
            Add("Enhanced TMtxVec.Replace uses IPP version of ReplaceNAN.");
            Add("Enhanced TVec.SetSubRange routines and added TVec.SetSubRangeLevel, which now support nesting.");
            Add("MtxVecTee unit and MtxVecDemo application updated to use latest version of Steema TeeChart net5.0-winform assembly via NuGet package dependancy.");

            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Probabilities unit:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added StudentRangeCDF for Studentized Range cumulative distribution.");
            Add("Added StudentRangeCDFInv for inverse Studentized Range cumulative distribution.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);

            richTextBox1.SelectionIndent = 10;
            Add("List of new features in v5.4.1 (September 2019):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Installer and Debugger Visualizer support for VS 2019.NET.");
            Add("Bug fix for TVecInt.SetSubRange, when freeing without calling SetFullRange.");
            Add("Updated dlls for Intel MKL and Intel IPP to support latest instruction sets and optimizations.");
            Add("TMtxVec.Capacity property allows for further reduction in memory reallocation frequency.");
            Add("Optimization methods can now respond to a 'stop' signal when running in its own thread. This can be helpfull, if the optimization process would deadlock or run too long.");
            Add("Added single precision support to Pardiso sparse solver.");
            Add("Added single precision support to Trust Region optimization method.");
            Add("MtxVec.Sparse6.dll has been joined in to MtxVec.Lapack6d.dll due to relatively much smaller size.");
            Add("Dll API has changed. To prevent version conflicts, the library names have new version number: 6.VC runtime library is no longer needed.");
            Add("Vectorized version for FindIndexes, FindMask and FindAndGather for TVec / TMtx and TVecInt / TMtxInt.Especially when using FindMask, speed improvement of 10x or more is possible when vectorizing if-then clauses.");

            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);

            Add("List of new features in v5.3 (January 2018):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Bug fix for TVecInt.BitUnpack when bit count was less than 32.");
            Add("Modifed SumOfSquares and Standard Deviation for greater numerical accuracy and about 50% higher speed.");
            Add("TVec/TVecInt and TMtx/TMtx received upgrade of ValueToStrings for fixed width font output with headers. Usefull for command line printout of small matrices.");            
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Expression parser:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Enabled 'Integer overflow' and 'Integer Division By Zero' error messages..");
            Add("Integer math is now based on Int64.");
            Add("Bug fixes for sqr and sqrt when param was integer.");
            Add("Added ability for 'colon range' autocomplete: a(2:) = b; //short for a(2:(2+Length(b)) = b;");
            Add("Added \"Edit and Continue\" type of debugging support for the script.");
            Add("Added \"Tooltips\" for variable evaluation during debugging of the script.");
            Add("Added support for [1, 2 ; 3, 4] for vector/matrix concatenation/initialization.");
            Add("Added support for \"if-else\", \"while\" and \"for-loop\" clauses.") ;
            Add("Added support for \"break\" and \"continue\" clauses.");
            Add("Added support for strings and custom objects.");
            Add("Added string grid adaptor, which enables reading and writing from an arbitrary string grid like object.");
            Add("Added support for empty lines and comments.");
            Add("Command line printout can be surpressed by specifying \";\" at the end of the line.");
            Add("Further performance optimization for single line and multi-line expression evaluation by about 2x.");
            Add("Expressions are now case-sensitive, but function aliases are allowed (Tan() for tan() for example).");
            Add("More automated tests have been implemented.");

            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);

            Add("List of new features in v5.2 (May 2017):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Improved performance of Lapack routines via latest Intel MKL update.");
            Add("Improved performance of math routines via Intel IPP v9 update. Important: MtxVec.Spld5.dll replaced with MtxVec.Dsp5d.dll.");
            Add("Fix for TMtxComponentList.Count when reducing value.");
            Add("Added TVecInt.BinarySearch, TVecInt.Find");
            Add("Added ThreshAbsGt and ThreshAbsLt to TVecInt, TVec and TMtx.");
            Add("Added TVecInt.ThresholdGT_LT.");
            Add("Added integer matrix (TMtxInt and MatrixInt) covering 108+ overloaded functions");
            Add("Added TVec.BinarySearch and TMtx.BinarySearch for exact and nearest index on sorted data.");
            Add("Added 80 new optimized functions for integer math used by TVecInt and TMtxInt.");
            Add("Added ThreadIndex parameter to the MtxForLoop threaded function type");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Expression parser:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added integer, integer vector, integer matrix, boolean, boolean vector and boolean matrix types.");
            Add("Support for funtions with multiple results: (a,b,c....) = fun(d)");
            Add("Added all functions from Probabilities.pas to the expression parser.");
            Add("Added large set of functions from MtxVec.pas to the expression parser, like FFT, FFT2D, SVD, etc.. ");
            Add("Total of 300+ functions and operators now available to the expression parser.");
            Add("Fixed a number of defects and improved error reporting. Performance optimization.");

            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v5.1 (March 2016):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Updated Intel MKL 11.3 and IPP to 9.0 Update 2.");
            Add("Performance improvements for AVX2 enabled CPUs.");
            Add("Added new TMtx.Filter2D() which enables 2D convolution/2d correlation/image filtering");
            Add("Addapted TVec.Median(), TVec.CrossCorr(), TVec.Convolve(), TVec.AutoCorr() parameter lists for new features");
            Add("Fixed NormL1 and NormL2 functions on 64bit, complex number and single precision.");
            Add("Fixes for TMtx.Eig() on 64bit and single precision.");
            Add("Replaced references to TVec.IValues with TVecInt type.");

            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v5.0 (December 2014):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Updated Intel MKL and IPP dlls to the latest versions.");
            Add("Added missing overload VectorInt.BlockInit(SrcVec);");
            Add("Fixed a bug with Matrix.SortDescend for complex values.");
            Add("Fixed a bug with TSparseMtx.Add when adding matrices which contain explicit zeros.");
            Add("Fixed a bug with TSparseMtx.Copy when copying matrices which contain explicit zeros.");            

            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v4.5 (May 2014):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Update to MKL and IPP. Performance improvements for eigenvalue calculations.");
            Add("Added generalized eigenvalue method TMtx.EigGen.");
            Add("Added calculation of Schure vectors. TMtx.EigSchure");
            Add("Added calculation of generalized Schure vectors. TMtx.EigSchureGen");
            Add("Updated calculation of eigenvalues for symmetric matrices. TMtx.EigSym");
            Add("Added calculation of generalized eigenvalues for symmetric matrices. TMtx.EigSymGen");
            Add("Updated TMtx.LQRSolve. Least square solutions with support for for rank deficient matrices.");
            Add("Added generalized SVD decomposition. TMtx.SVDGen.");
            Add("Added Gauss Markov Linear Model solver with TMtx.GLMSolve");
            Add("Important: Old TMtx.EigGen has become TMtx.EigSymGen and TMtx.EigGen has new meaning.");
            Add("Added eigenvalue calculation for symmetric matrices TSparseMtx.EigSym");
            Add("Added generalized eigenvalue calculation for symmetric matrices TSparseMtx.EigSymGen");


            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v4.4 (February 2014):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added BitPack, BitUnpack methods and Bits property to TVecInt.");
            Add("Added help for Median filter functions.");
            Add("Update to IPP dlls and a dll bug fix.");
            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v4.3 (September 2013):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New set of dlls with support for Intel 4th Generation Core CPUs and Intel Xeon Phi.");
            Add("Added support for concurrent use of double and single precision version of the library. All functions, methods and components are available in both variants. Debugging in to source code and debugger visualizers remain fully supported.");
            Add("Added TMtx.LUSolve overload, which makes use of a precomputed factorization.");
            Add("Support for Visual Studio.NET 2013.");
            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v4.2 (November 2012):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Cougar Open CL opens the world of GPU processing to Delphi developers. A new namespace clMtxVec adds two new types TOpenCLVector and TOpenCLMatrix which can run their functions on the GPU.");
            Add("Cougar Open CL substantially simplifies custom Open CL algorithm development, integration and deployment.");            
            Add("Updated code related to Intel IPP and MKL libraries to the latest version. Note that the minimum CPU requirement has been raised by Intel to SSE2 capable CPU (P4, released in year 2000).");
            Add("Support for Visual Studio.NET 2012.");
            Add("A number of various fixes and udpates");              
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v4.0 (May 2010):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Bottom up reachitectured memory allocation and PInvoke interop achieving further performance gains.");
            Add("New super-conductive object cache implementation features linear scaling with number of threads and enables concurrency of math expressions which can now be threaded. MtxVec now allows perfect scaling of its code across any number of cores.");
            Add("Multi-precision integer vector math with TVecInt and VectorInt with full support for object cache and math expressions.");
            Add("Support for TeeChart 2010.");
            Add("Support for Visual Studio.NET 2010.");
            Add("Updated dlls for latest version of MKL and IPP with support for Intel AVX.");
            Add("Debugger tooltips and watches for TVec/TMtx and Vector/Matrix are showing object values.");
            Add("Debugger visualizer works also for TVec/TMtx");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Polynoms:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Fixed a bug for unsorted linear interpolation.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Optimization:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Enabled support for Trust Region algorithm.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v3.5 (january 2009):");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("64 bit version of Dew Math.");
            Add("Ability to create and use vectors and matrices up to 16GB in size for double precision.");
            Add("20-50% faster execution of floating point math. Especially  the math functions like Exp, Ln, "
                + "Log etc.. will benefit. Small improvements can be noticed across the board.");
            richTextBox1.SelectionBullet = false;
            Add("");
            
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v3.5:");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Debugger visualizer allows charting/viewing of arrays, vectors (TVec/Vector) and matrices (TMtx/Matrix) while debugging. It is possible to examine huge structures (hundreds of Mbytes) in real time both for viewing and charting. Delphi default debugger only shows arrays up to 132 000 elements. ");
            Add("New code optimizations and multithreaded functions.");
            Add("Support for SSE4.1 for Intel Core 2 Wolfdale from Intel MKL v10 and IPP v6.");
            Add("Substantially updated help file system.");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Dew.Math.Tee:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New TeeChart series MtxFastLineSeries allows zoom in/out with pixeldownsample enabled internally. Applicable also to the DrawIt method and debugger Visualizer.");
            Add("TMtxFastLineSeries is 3x faster than FastLineSeries when not using pixeldownsample.");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Expression parser/scripter:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Function overloading allowed based on parameter count.");
            Add("Custom functions can be object methods.");
            Add("Vectors and matrices can be accessed by elements a(i) or m(r,c).");
            Add("Colon operator allows selection of ranges of rows and colums m(:), m(1,:), v(2:3).");
            Add("Assign operator supports colon operator: m(2:3) = 4.");
            Add("Colon operator supports step <> 1 and allows: m(10:-1:3) = 4");
            Add("Vectors and matrices can return elements from conditions: a = m(m > 4)");
            Add("Functions accept strings as parameters and can return string as result.");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Dew.Math.Units.Optimization:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Added several linear programming algorithms, including Dual Simplex, Two Phase Simplex ordinary Simplex LP and Gomory's Cutting Plane (CPA) algorithms");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Dew.Math.MtxVecTools:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New TMtxLP component for easy usage of all LP algorithms.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(51, 104, 196);
            Add("List of new features in v3.1:");
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Core product:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New code optimizations and support for Intel Core 2 Duo product familiy.");
            Add("New multithreaded VML function support. Simple functions like Sin, Cos.. are threaded when vector length exceeds about 10 000 elements. No MtxVec code change required to have your code run on multiple cores.");
            Add("Together with Vector/Matrix classes it is possible to write math expressions in its natural format and have the code at the same time executed on multiple cores!");
            Add("Borland VCL dependancy has been completely removed. Now Dew.Math.dll only needs 100kb Borland.Delphi.dll.");
            Add("LAPACK v3.1 delivers increased precision and performance.");
            Add("Reduced distribution size with \"Compact MtxVec\". In case of the Stats Master by 50%. There are now more and more specialized dll's.");
            Add("Intel MKL 9.1 and Intel IPP 5.2 updated with the Intel v10 C++ and Fortran compilers. ");
            Add("Sparse solver: UMFPACK support updated to v5.1");
            Add("Pardiso sparse solver support updated to latest version of MKL.");
            Add("Powerfull math expression parser.");
            Add("New HTML Help 2 format of the help file.");
            Add("New set of true color 24x24 and 16x16 icons for components to support newer IDE tool palette.");
            richTextBox1.SelectionBullet = false;
            Add("");
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Dew.Math.Controls Assembly:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New Dew.Math.Controls assembly includes all new visual conttrols, rewritten and compiled with NET v2.");
            Add("FloatEdit control: Easy editing of complex or real numbers.");
            Add("ProgressDialog control: Multi-threaded progress dialog.");
            Add("MtxDataSet control: Allows reading/writing of vector or matrix to database numeric or byte[] field.");
            Add("MtxGridView control: Allows easy editing/viewing of vector or matrix real or complex values. Inherits all DataGridView properties and adds some new features.");
            Add("PositionPanel control: Panel with customized slider (for backward compatibility).");
            Add("Several new editors for editing vector, matrix, function context expression, expression variables, ...");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Dew.Math.Tee Assembly:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("New Dew.Math.Tee assembly interfaces Dew.Math charting routines with Steema's TeeChart v2 LITE or v2/v3 full version.");
            Add("New MtxGridSeries for viewing matrix values. Optimized for latest TeeChart version.");
            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Changes in units:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Optimization: Simplex algorithm now supports lower and/or upper bounds for parameters.");
            Add("Optimization: Added several linear programming algorithms, including Dual Simplex, Two Phase Simplex ordinary Simplex LP and "
                + "Gomory's Cutting Plane (CPA) algorithms.");
            Add("Probabilities: Added 8 new distributions: Gumbel (minimum), Gumbel (maximum), Erlang, Power, "
                + "Inverse Gaussian, Fatigue Life, Johnson SB, Johnson UB. Probabilities unit now includes 34 different distributions");
            Add("Probabilities: Moved distribution statistical parameter calculation from Statistics to Probabilities. Basic statistics "
                + "now includes estimates for distribution mean, variance, skewness and kurtosis.");
            Add("MtxIntDiff: New unit introduces several routines for numerical integration (1D, 2D, n-D).");
            Add("MtxIntDiff: All numerical gradient estimation routines moved from Optimization unit.");
            richTextBox1.SelectionBullet = false;
            Add("");


            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Underline);
            Add("Help files:");
            Add("");
            richTextBox1.SelectionBullet = true;
            richTextBox1.SelectionIndent = 10;
            Add("Help file has received a major upgrade to Html Help 2 format.");
            Add("Updated demo now includes most features from VCL version.");
            Add("Code examples have been updated to reflect the new default syntax with Vector and Matrix objects.");
            Add("Demo updated with Vector/Matrix syntax.");
            richTextBox1.SelectionBullet = false;
            Add("");

            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 11, FontStyle.Bold);
			richTextBox1.SelectionColor = Color.FromArgb(51,104,196);
			Add("List of new features in v2.0:");
			Add("");
			richTextBox1.SelectionBullet = true;
			richTextBox1.SelectionIndent = 10;
			Add("Support for .NET platform. Single source code compiles " +
				"on .NET and W32.");
			Add("Sparse matrices: Umfpack v4.3 and Pardiso solver.");
			Add("All C/C++ (umfpack) code compiled with Intel C/C++ compiler " +
				"with support for SSE2/SSE3.");
			Add("All Fortran code compiled with Intel Fortran compiler " +
				"with support for SSE2/SSE3.");
			Add("Sparse solvers for complex sparse matrices.");
			Add("New random generators via MKL 7.0");
			Add("New FFT engine with support for arbitrary length FFTs " +
				"(including arbitrary 2D FFT sizes) and symmetric multiprocessing.");
			Add("Extensive tests written to interface DUnit test framework. "+
				"Tests execute under .NET and W32 and ensure that code gives " +
				"the same result.");
			Add("New memory allocation bypassing Delphi memory manager and allowing "+
				"to better exploit available system memory");
			Add("Intel SPL calls replaced with Intel IPP 4.0.");
			Add("New dll interfaces allow support of C++Builder and Kylix.");
			Add("Common abstract class between for TVec, TMtx "+
				"and TSparseMtx shares common functions. "+
				"New syntax options allowing much more flexibility "+
				"when exchanging data between TVec, TMtx "+
				"and TSparseMtx. Only the \"view\" of memory is changed. " +
																				 "It is possible to write single source code which can take vector "+
																				 ",matrix and sparse matrix objects as parameters." );
			Add("Vastly improved error checking, mostly due to " +
				"in-depth tests. ");
			Add("Prescot CPU support exploiting the features of the "+
				"new (SSE3) instruction set. ");
			Add("Extensive performance optimizations across "+
				"the entire library.");
			Add("Operator overloading under .NET for complex "+
				"numbers. ");
			Add("It should be possible to write single source code " +
				"that would execute on W32 and .NET with the same "+
				"or very similar performance even for short vectors " +
				"and small matrices. ");
			richTextBox1.SelectionBullet = false;
			richTextBox1.SelectionIndent = 0;

		}
	}
}
