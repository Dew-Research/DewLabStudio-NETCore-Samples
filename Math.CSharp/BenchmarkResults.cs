using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace MtxVecDemo
{
	/// <summary>
	/// Summary description for BenchmarkResults.
	/// </summary>
	[Serializable]
	public class BenchmarkItem	{
		public BenchmarkItem() {
		}
		private String funcName;
		private int vecLen;
		private int iterationCount;
		private double smplVecTicks;
		private double cplxVecTicks;
		private double smplFuncTicks;
		private double cplxFuncTicks;

		public String FuncName {
			get {
				return funcName;
			}
			set {
				funcName = value;
			}
		}
		public int VecLen {
			get {
				return vecLen;
			}
			set {
				vecLen = value;
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
		public double SmplVecTicks {
			get {
				return smplVecTicks;
			}
			set {
				smplVecTicks = value;
			}
		}
		public double CplxVecTicks {
			get {
				return cplxVecTicks;
			}
			set {
				cplxVecTicks = value;
			}
		}
		public double SmplFuncTicks {
			get {
				return smplFuncTicks;
			}
			set {
				smplFuncTicks = value;
			}
		}
		public double CplxFuncTicks {
			get {
				return cplxFuncTicks;
			}
			set {
				cplxFuncTicks = value;
			}
		}
	}
	
	[Serializable]
	public class BenchmarkResults : CollectionBase {
		public BenchmarkItem this[ int index ]  {
			get  {
				return( (BenchmarkItem) List[index] );
			}
			set  {
				List[index] = value;
			}
		}

		public BenchmarkItem Add(BenchmarkItem item) {
			List.Add(item);
			return item;
		}
		public void Remove(BenchmarkItem item) {
			List.Remove(item);
		}
		public BenchmarkItem Add( String funcName, int vecLen, int iterationCount, double smplVecTicks, double cplxVecTicks,
			double smplFuncTicks, double cplxFuncTicks ) {
			BenchmarkItem item = new BenchmarkItem();
			item.FuncName = funcName;
		    item.VecLen = vecLen;
			item.IterationCount = iterationCount;
			item.SmplVecTicks = smplVecTicks;
			item.CplxVecTicks = cplxVecTicks;
			item.SmplFuncTicks = smplFuncTicks;
			item.CplxFuncTicks = cplxFuncTicks;
			return Add(item);
		}
		private string title;
		public string Title {
			get {
				return title;
			}
			set {
				title = value;
			}
		}

		public void SaveToFile(string fileName) {
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
			try {
				formatter.Serialize(stream,this);
			} finally {
				stream.Close();
			}
		}
		public static BenchmarkResults LoadFromFile (string fileName) {
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
			BenchmarkResults br = null;
			try {
				br = (BenchmarkResults) formatter.Deserialize(stream);
			} finally {
				stream.Close();
			}
			return br;
		}
	}
}
