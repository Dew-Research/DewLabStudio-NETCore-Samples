using System;
using System.Collections;
using Dew.Math;
using Dew.Math.Units;

namespace MtxVecDemo {

	/// <summary>
	/// Summary description for BenchmarkFramework.
	/// </summary>
	
	public delegate TMtxVec VecMethod(TMtxVec x);
	public delegate double SmplFunc(double x);
	public delegate TCplx CplxFunc(TCplx x);
	public delegate void CalcProc();

	public struct FuncInfo {
		public String func_name;
		public SmplFunc smpl_func;
		public CplxFunc cplx_func;
		public VecMethod vec_method;
		public double smpl_val;
		public TCplx cplx_val;
	}

	public class BenchmarkFramework	: IDisposable {
		
		public BenchmarkFramework() {
			MtxVec.CreateIt(out src, out dst);
			funcs = new ArrayList();
			initFuncs();
		}
		
		public void Dispose() {
			MtxVec.FreeIt(ref src, ref dst);
		}

		private void addFunc(String funcName, double smplVal, TCplx cplxVal, SmplFunc smplFunc, 
			CplxFunc cplxFunc, VecMethod vecMethod) {
			FuncInfo f;
			f.func_name = funcName;
			f.smpl_val = smplVal;
			f.cplx_val = cplxVal;
			f.smpl_func = smplFunc;
			f.cplx_func = cplxFunc;
			f.vec_method = vecMethod;
			funcs.Add(f);
		}

		private void initFuncs() {
			funcs.Clear();
			double val1 = 0.5;
			TCplx cVal1;
			cVal1.Re = 0.5;
			cVal1.Im = 0.5;
			addFunc("Exp",val1,cVal1,new SmplFunc(Math.Exp), new CplxFunc(Math387.Exp),new VecMethod(dst.Exp) );
			addFunc("Ln",val1,cVal1,new SmplFunc(Math.Log), new CplxFunc(Math387.Ln),new VecMethod(dst.Ln) );
            addFunc("Log10",val1,cVal1,new SmplFunc(Math.Log10),new CplxFunc(Math387.Log10),new VecMethod(dst.Log10));
            
            addFunc("Tan",val1,cVal1,new SmplFunc(Math.Tan),new CplxFunc(Math387.Tan),new VecMethod(dst.Tan));
            addFunc("Sin", val1, cVal1, new SmplFunc(Math.Sin), new CplxFunc(Math387.Sin), new VecMethod(dst.Sin));
            addFunc("Cos", val1, cVal1, new SmplFunc(Math.Cos), new CplxFunc(Math387.Cos), new VecMethod(dst.Cos));
            addFunc("ArcTan", val1, cVal1, new SmplFunc(Math.Atan), new CplxFunc(Math387.ArcTan), new VecMethod(dst.ArcTan));
            addFunc("ArcSin",val1,cVal1,new SmplFunc(Math.Asin),new CplxFunc(Math387.ArcSin),new VecMethod(dst.ArcSin));
            addFunc("ArcCos",val1,cVal1,new SmplFunc(Math.Acos),new CplxFunc(Math387.ArcCos),new VecMethod(dst.ArcCos));

            addFunc("Tanh",val1,cVal1,new SmplFunc(Math.Tanh),new CplxFunc(Math387.Tanh),new VecMethod(dst.Tanh));
            addFunc("Sinh",val1,cVal1,new SmplFunc(Math.Sinh),new CplxFunc(Math387.Sinh),new VecMethod(dst.Sinh));
            addFunc("Cosh",val1,cVal1,new SmplFunc(Math.Cosh),new CplxFunc(Math387.Cosh),new VecMethod(dst.Cosh));
        }

		public int FindFuncByName(String name) {
			for (int i=0;i<funcs.Count;i++) {
				FuncInfo f = (FuncInfo)funcs[i];
				if (f.func_name.Equals(name)) {
					return funcs.IndexOf(f);
				}
			}
			throw new Exception("BenchmarkFramework.FindFuncByName: Name of function was not found:"+name);
		}
		public int FuncCount {
			get {
				return funcs.Count;
			}
		}
		public String GetFuncName(int index) {
			if (index > funcs.Count-1) 
				throw new Exception("BenchmarkFramework.GetFuncName: Index out of range: " + index.ToString());
			return ((FuncInfo)funcs[index]).func_name;
		}
 		public void InitSmplVecs(double val) {
			src.Size(VectorLength,false);
			src.SetVal(val);
			src.CopyToArray(ref srca);
			dst.Size(VectorLength,false);
			dst.SetZero();
			dst.SizeToArray(ref dsta);
		}

		public void InitCplxVecs(TCplx val) {
			src.Size(VectorLength,true);
			src.SetVal(val);
			src.CopyToArray(ref srcac);
			dst.Size(VectorLength,true);
			dst.SetZero();
			dst.SizeToArray(ref dstac);
		}

		public void Run(String funcName, BenchmarkResults results) {
			double smpl_vec_ticks, cplx_vec_ticks, smpl_func_ticks, cplx_func_ticks;
			selectedFunc = (FuncInfo) funcs[FindFuncByName(funcName)];
			InitSmplVecs(selectedFunc.smpl_val);
			smpl_vec_ticks = doUnderTimer(new CalcProc(calcVector));
			InitCplxVecs (selectedFunc.cplx_val);
			cplx_vec_ticks = doUnderTimer (new CalcProc(calcVector));
			InitSmplVecs (selectedFunc.smpl_val);
			smpl_func_ticks = doUnderTimer (new CalcProc(calcSample));
			InitCplxVecs (selectedFunc.cplx_val);
			cplx_func_ticks = doUnderTimer (new CalcProc(calcComplex));
			results.Add(funcName, VectorLength, IterationCount, smpl_vec_ticks, cplx_vec_ticks,
				smpl_func_ticks, cplx_func_ticks);
		}
		private double doUnderTimer(CalcProc proc) {
			Math387.StartTimer();
			proc();
			return Math387.StopTimer()*1000;
		}
		private void calcVector() {
			VecMethod func = selectedFunc.vec_method;
			for (int i=0;i<iterationCount;i++) {
				func(src);
			}
		}

		private void calcSample() {
			SmplFunc func = selectedFunc.smpl_func;
			for (int i=0;i<iterationCount;i++) {
				for (int j=0;j<dst.Length;j++) {
					dsta[j] = func(srca[j]);
				}
			}
		}

		private void calcComplex() {
			CplxFunc func = selectedFunc.cplx_func;
			for (int i=0;i<iterationCount;i++) {
				for (int j=0;j<dst.Length;j++) {
					dstac[j] = func(srcac[j]);
				}
			}
		}

		public int RecalcIterationCount() {
			TVec a,b;
			MtxVec.CreateIt(out a, out b);
			try {
				a.Size(VectorLength,false);
				b.Size(VectorLength,false);
				int n=0;
                long ticks = 0;
                Math387.StartTimer(ref ticks);
				double delta = 0;
				while (delta < 1000) {
					b.Sin(a);
					n++;
                    delta = Math387.StopTimer(ticks)*1000;
				}
				return n / 40;
			} finally {
				MtxVec.FreeIt(ref a,ref b);
			}
		}

		public int VectorLength {
			get {
				return vectorLength;
			}
			set {
				vectorLength = value;
			}

		}

		public int IterationCount {
			get {
				return iterationCount;
			}
			set {
				iterationCount = value;
			}
		}
		TVec src, dst;
		double[] srca, dsta;
		TCplx[] srcac, dstac;        
		int iterationCount;
		private int vectorLength;

		ArrayList funcs;//: array of TFuncInfo; 
		//fFuncCount: integer;
		FuncInfo selectedFunc;
	}

}
