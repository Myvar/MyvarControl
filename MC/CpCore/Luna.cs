using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CpCore
{
    public class Luna
    {
        public Control Host { get; set; }

        private WebClient Wc = new WebClient();

        public string MainCode = "";
        public string MainHtml = "";

        private ScriptEngine pyEngine = null;
        private ScriptRuntime pyRuntime = null;
        private ScriptScope pyScope = null;



        /// <summary>
        /// This is the main interface to the Core implmntaion
        /// </summary>
        /// <param name="h">The host cotrol  for the web app</param>
        public Luna(Control h)
        {
            Host = h;

            if (pyEngine == null)
            {
                pyEngine = Python.CreateEngine();
                pyScope = pyEngine.CreateScope();


            }
        }

        /// <summary>
        /// Load an we app
        /// </summary>
        /// <param name="url">The root url for the program</param>
        public void OpenApp(string html, string py)
        {
            //get code form server
            var s = py;
            var sh = html;
            MainCode = s;
            MainHtml = sh;
            NameSpaceList.Add("System.Windows.Forms");
        }

        private void CompileSourceAndExecute(String code)
        {
            ScriptSource source = pyEngine.CreateScriptSourceFromString
                        (code, SourceCodeKind.Statements);
            CompiledCode compiled = source.Compile();
            // Executes in the scope of Python
            compiled.Execute(pyScope);
        }

        public static List<string> NameSpaceList = new List<string>();

        public static List<Assembly> includdlls = new List<Assembly>();

        public static string[] tokens = "b03f5f7f11d50a3a~b77a5c561934e089".Split('~');

        #region HugeUglyPeacOfCode

        public static Type GetTypeOfControl(string myclass1, String mymethod)
        {
            Type mymethoda = null;
            string myclass = myclass1;
            string myclass11 = myclass1;
            string np1 = "";
            try
            {
                Boolean donpttry = true;
                foreach (string i in myclass1.Split('.'))
                {
                    foreach (string ii in myclass1.Split('.'))
                    {
                        if (NameSpaceList.Contains(i + "." + ii))
                        {
                            donpttry = false;
                            np1 = i + "." + ii;
                            break;
                        }
                    }
                }
                foreach (string np in NameSpaceList)
                {
                    myclass = myclass11;
                    if (!donpttry)
                    {
                        break;
                    }

                    //  myclass;
                    foreach (string i in tokens)
                    {
                        if (mymethoda == null)
                        {
                            mymethoda =
                                Type.GetType(
                                    np + "." + myclass1 + ", " + np
                                    + ", Version=4.0.0.0, Culture=neutral, PublicKeyToken=" + i);
                        }
                    }
                    if (mymethoda == null)
                    {
                        mymethoda = Type.GetType(np + "." + myclass1);
                    }
                    if (mymethoda == null)
                    {
                        foreach (Assembly i in includdlls)
                        {
                            if (mymethoda == null)
                            {
                                mymethoda = i.GetType(np + "." + myclass1);
                            }
                        }
                    }
                    if (mymethoda == null)
                    {
                        myclass = np + "." + myclass;
                        mymethoda = typeof(int).Assembly.GetType(myclass.Split('.')[0] + "." + myclass.Split('.')[1]);
                    }
                    if (mymethoda != null)
                    {
                        break;
                    }
                }
                if (!donpttry)
                {
                    mymethoda =
                        Type.GetType(
                            myclass1 + ", " + np1
                            + ", Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

                    if (mymethoda == null)
                    {
                        mymethoda = Type.GetType(myclass1);
                    }

                    if (mymethoda == null)
                    {
                        myclass = myclass;
                        mymethoda = typeof(int).Assembly.GetType(myclass.Split('.')[0] + "." + myclass.Split('.')[1]);
                    }
                }
                if (mymethoda == null)
                {
                    foreach (Assembly i in includdlls)
                    {
                        if (mymethoda == null)
                        {
                            mymethoda = i.GetType(myclass1);
                        }
                    }
                }
                if (mymethoda != null)
                {
                    return mymethoda;
                }
            }
            catch
            {
            }

            return null;
        }
        #endregion

        private void LoadHTML()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(MainHtml);
            foreach (XmlNode i in doc.DocumentElement.ChildNodes)
            {
                if (i.Attributes["Name"] != null)
                {

                    Control b = (Control)Activator.CreateInstance(GetTypeOfControl(i.Name, i.Name));
                    //  b.Name = i.Attributes["Name"].Value;
                    foreach (var d in i.Attributes)
                    {
                        var s = (XmlAttribute)d;
                        PropertyInfo prop = b.GetType().GetProperty(s.Name, BindingFlags.Public | BindingFlags.Instance);

                        try
                        {

                            if (s.Name == "Color")
                            {
                                throw new NotImplementedException();
                            }
                            prop.SetValue(b, Convert.ChangeType(s.Value, prop.PropertyType), null);
                        }
                        catch (Exception e)
                        {
                            if (s.Name == "Location")
                            {
                                string[] s1 = s.Value.Replace(" ", "").Split(',');
                                b.Location = new System.Drawing.Point(int.Parse(s1[0]), int.Parse(s1[1]));
                            }
                            if (s.Name == "Color")
                            {

                                b.BackColor = Color.FromName(s.Value);
                            }
                        }

                    }


                    pyScope.SetVariable(i.Attributes["Name"].Value, b);
                    Host.Controls.Add(b);
                }



            }

        }



        /// <summary>
        /// start Site
        /// </summary>
        public void InvokeMain()
        {
            LoadHTML();
            //add lib
            //varables


            //adding
            //  pyScope.SetVariable("User", u);

            //add main variables
            pyScope.SetVariable("MainForm", Host);

            string baceCode = "import clr\nclr.AddReference('System.Windows.Forms')\nclr.AddReference('System.Drawing')\nclr.AddReference('System')\n";

            CompileSourceAndExecute(baceCode + MainCode);

        }

    }
}
