using System;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Microsoft.Win32;

namespace Dew.Demo
{
    class Utils
    {

        #region RichTextBox Formatting
        struct Selection
        { // used to store selection definitions
            public int Start, End;
            public static Selection Create(int start, int end)
            {
                Selection selection;
                selection.Start = start;
                selection.End = end;
                return selection;
            }
        }

        private static String[] keyWords = {	"abstract", "event", "new", "struct", 
																	"as", "explicit", "null", "switch",
																	"base", "extern", "object", "this", 
																	"bool", "false", "operator", "throw",
																	"break", "finally", "out", "true",
																	"byte", "fixed", "override", "try", 
																	"case", "float", "params", "typeof", 
																	"catch", "for", "private", "uint", 
																	"char", "foreach", "protected", "ulong", 
																	"checked", "goto", "public", "unchecked", 
																	"class", "if", "readonly", "unsafe", 
																	"const", "implicit", "ref", "ushort", 
																	"continue", "in", "return", "using", 
																	"decimal", "int", "sbyte", "virtual", 
																	"default", "interface", "sealed", "volatile", 
																	"delegate", "internal", "short", "void", 
																	"do", "is", "sizeof", "while", 
																	"double", "lock", "stackalloc", 
																	"else", "long", "static",   
																	"enum", "namespace", "string" };


        private static ArrayList keys, comments;

        private static bool isKeyword(String s)
        {
            foreach (string word in keyWords)
            {
                if (word.Equals(s)) return true;
            }
            return false;
        }

        private static bool nextWordIsKeyword(String s, ref int start)
        {
            while (start < s.Length)
            {

                if (Char.IsLetter(s, start) || s[start] == '_')
                {
                    break;
                }
                // Comments detecting
                if (s[start] == '/' && s[start + 1] == '/')
                {
                    int pos = start;
                    start += 2;
                    while (s[start] != '\n') start++;
                    comments.Add(Selection.Create(pos, start));
                }
                else if (s[start] == '/' && s[start + 1] == '*')
                {
                    int pos = start;
                    start += 2;
                    while (!(s[start - 1] == '*' && s[start] == '/')) start++;
                    comments.Add(Selection.Create(pos, start));
                }
                else start++;
            }


            int old = start;
            while (start < s.Length && (Char.IsLetter(s, start) || s[start] == '_')) start++;
            if (start > old)
            {
                String key = s.Substring(old, start - old);
                if (isKeyword(key))
                {
                    keys.Add(Selection.Create(old, start - 1));
                    return true;
                }
            }
            return false;
        }

        public static void Highlight(RichTextBox rb)
        {
            rb.SuspendLayout();
            keys = new ArrayList();
            comments = new ArrayList();
            try
            {
                rb.SelectAll();
                rb.SelectionColor = System.Drawing.Color.Black;
                int[] tabs = new int[32];
                int tabSize = (int)rb.CreateGraphics().MeasureString("m", rb.Font).Width;
                for (int i = 0; i < tabs.Length; i++)
                {
                    tabs[i] = (i + 1) * tabSize * 2;
                }
                rb.SelectionTabs = tabs;
                rb.Select(0, 0);
                int start = 0;
                String tmp = rb.Text;

                while (start < tmp.Length)
                {
                    nextWordIsKeyword(tmp, ref start);
                }

                foreach (Selection s in keys)
                {
                    rb.SelectionStart = s.Start;
                    rb.SelectionLength = s.End - s.Start + 1;
                    rb.SelectionColor = System.Drawing.Color.Blue;
                }
                foreach (Selection s in comments)
                {
                    rb.SelectionStart = s.Start;
                    rb.SelectionLength = s.End - s.Start + 1;
                    rb.SelectionColor = System.Drawing.Color.Green;
                }
            }
            finally
            {
                rb.ResumeLayout();
            }
        }
#endregion


        public static string AssemblyInfo(Assembly a)
        {
            string result = "";
            AssemblyName[] an = a.GetReferencedAssemblies();
            foreach (AssemblyName name in an)
            {
                result += name.Name + ", " + name.Version+"\n";
            }

            return result;
        }

        public class DemoTreeNode : TreeNode
        {
            private String formType;
            private String fileName;

            public DemoTreeNode(String displayName, String fileName, String formType)
                : base()
            {
                Text = displayName;
                this.formType = formType;
                this.fileName = fileName;
            }
            
            public String FileName
            {
                get
                {
                    return fileName;
                }
            }

            public Type FormType
            {
                get
                {
                    if (formType != null)
                        return Assembly.GetExecutingAssembly().GetType(formType, true, true);
                    else
                        return null;
                }
            }
        }

        private static string DemoRegKey = @"Software\Dew Research\Dew DSP\.NET Demo";


        public static void WriteSourcePath(string path)
        {
            RegistryKey demokey = Registry.CurrentUser.CreateSubKey(DemoRegKey);
            if (demokey != null)
            {
                demokey.SetValue("Source Folder", path);
            }
        }

        public static string SourcePath()
        {            
            const string ProjectName = "DewDSPDemo.csproj";
            string result = "";

            RegistryKey key = Registry.CurrentUser.CreateSubKey(DemoRegKey);
            if (key != null)
            {               
                 object o = key.GetValue("Source Folder");
                 result = o == null ? "" : o.ToString();               
            }

            if ((result == "") || (!Directory.Exists(result)))//try to get the executable path
            {
                result = Application.ExecutablePath;
                result = Path.GetDirectoryName(result) + @"\";
            }

            FileInfo fi = new FileInfo(result + ProjectName);
			if (!fi.Exists)
			{
				fi = new FileInfo(result + @"..\..\..\" + ProjectName);
				if (fi.Exists) result = result + @"..\..\..\";
				else
				{
					fi = new FileInfo(result + @"..\..\" + ProjectName);
					if (fi.Exists) result = result + @"..\..\";
					else
					{
						fi = new FileInfo(result + @"..\" + ProjectName);
						if (fi.Exists) result = result + @"..\";
					}
				}
			}

            return result;
        }

    }
}
