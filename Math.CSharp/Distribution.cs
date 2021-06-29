using System;
using System.Collections;
using System.Text;
using System.Reflection;
using Dew.Math.Units;

namespace Dew.Examples
{
    class Distribution
    {
        public enum DistType
        {
            dtPDF,
            dtCDF,
            dtCDFInv
        }

        private MethodInfo pdf;
        private MethodInfo cdf;
        private MethodInfo cdfinv;
        private string ftitle;
        private DistType ftype;
        
        private Type t;

        public ParameterInfo[] GetParameterInfo()
        {
            switch (ftype)
            {
                case DistType.dtPDF: return (pdf != null) ? pdf.GetParameters() : null ;
                case DistType.dtCDF: return (cdf != null) ? cdf.GetParameters() : null ;
                case DistType.dtCDFInv: return (cdfinv != null) ? cdfinv.GetParameters() : null;
                default: return null;
            }
        }

        public string Title
        {
            get { return ftitle; }
            set { ftitle = value; }
        }

        public DistType DType
        {
            get { return ftype; }
            set { ftype = value; }
        }
        

        public Distribution()
        {
            Assembly a = null;
            try
            {
                a = System.Reflection.Assembly.LoadFrom("Dew.Math.dll");
            }
            catch (System.IO.FileNotFoundException)
            {
                if (a == null) a = System.Reflection.Assembly.LoadFrom("Dew.Probability.dll");
            }
            
            if (a != null)
            {
                t = a.GetType("Dew.Math.Units.Probabilities");
            }
        }

        /// <summary>
        /// Retrieve distribution cdf,pdf and inverse cdf
        /// </summary>
        /// <param name="distname">Distribution name</param>
        public void FindDistribution(string distname)
        {
            pdf = null;
            cdf = null;
            cdfinv = null;

            if ((t!=null) && (t.IsClass))
            {
                ftitle = distname;
                MethodInfo[] m = t.GetMethods();
                foreach (MethodInfo method in m)
                {
                    if ((method.Name == distname + "PDF") && (method.ReturnType == typeof(double)))
                        pdf = method;
                    else if ((method.Name == distname + "CDF") && (method.ReturnType == typeof(double)))
                        cdf = method;
                    else if ((method.Name == distname + "CDFInv") && (method.ReturnType == typeof(double)))
                        cdfinv = method;
                }
            }
        }

        public double CalcPDF(Object[] pars)
        {
            double result = Math387.NAN;
            if (pdf != null)
            {
                result = Convert.ToDouble(pdf.Invoke(this,pars));
            }
            return result;
        }

        public double CalcCDF(Object[] pars)
        {
            double result = Math387.NAN;
            if (cdf != null)
            {
                result = Convert.ToDouble(cdf.Invoke(this, pars));
            }
            return result;
        }

        public double CalcCDFInv(Object[] pars)
        {
            double result = Math387.NAN;
            if (cdfinv != null)
            {
                result = Convert.ToDouble(cdfinv.Invoke(this, pars));
            }
            return result;
        }

    }
}
