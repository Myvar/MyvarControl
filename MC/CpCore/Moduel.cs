using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CpCore
{

    public class Moduel
    {
        public Luna Engine ;

        [JsonIgnore]
        public MControl Hcontrol = new MControl();

        public Dictionary<string, string> Properties = new Dictionary<string, string>();

        public Moduel()
        {
            Engine = new Luna(Hcontrol);
        }

        public void Load(string Directory)
        {
            var html = File.ReadAllText(Path.Combine(Directory, "main.html"));
            var py = File.ReadAllText(Path.Combine(Directory, "main.py"));
            var Props = File.ReadAllText(Path.Combine(Directory, "main.properties"));
            Engine.OpenApp(html, py);          
            foreach(string i in Props.Replace("\r\n","\n").Split(new []{'\n'}, StringSplitOptions.RemoveEmptyEntries))
            {
                Properties.Add(i.Split(':')[0].Trim(), i.Split(':')[1].Trim());
            }
            Engine.Properties = Properties;
        }

        public void Start()
        {
            Engine.InvokeMain();
        }
    }
}
