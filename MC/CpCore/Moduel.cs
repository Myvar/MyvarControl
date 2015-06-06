using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CpCore
{
    public class Moduel
    {
        public Luna Engine ;
        public MControl Hcontrol = new MControl();

        public Moduel()
        {
            Engine = new Luna(Hcontrol);
        }

        public void Load(string Directory)
        {
            var html = File.ReadAllText(Path.Combine(Directory, "main.html"));
            var py = File.ReadAllText(Path.Combine(Directory, "main.py"));
            Engine.OpenApp(html, py);          
        }

        public void Start()
        {
            Engine.InvokeMain();
        }
    }
}
