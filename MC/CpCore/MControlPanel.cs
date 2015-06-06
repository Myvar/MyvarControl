using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpCore
{
    public class MControlPanel
    {
        public Panel Host { get; set; }

        public MControlPanel()
        {
           
        }

        public void AddNewPanel(MControl p)
        {
            Host.Controls.Add(p);
        }

        public MControlPanel(Panel col)
        {
            Host = col;
        }


    }
}
