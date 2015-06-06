using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CpCore.UI;
using Newtonsoft.Json;

namespace CpCore
{
    [JsonObject(MemberSerialization.OptIn)]
    public partial class MControl : UserControl
    {
        [JsonProperty]
        public Moduel mod { get; set; }

        public MControl()
        {
            InitializeComponent();
        }

        private void MControl_Load(object sender, EventArgs e)
        {
           
            TCResize ResizebleThis = new TCResize(this);
        }

        private void MControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropDlg dlg = new PropDlg();
            dlg.Options = new List<string>() { };
            for (int i = 0; i < 13; i++)
            {
                dlg.Options.Add("COM" + i);
            }
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mod.Engine.ComPort = dlg.SeletedPanlel;
            }

        }

        private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PropertiesDialog dlg = new PropertiesDialog();
            dlg.Properties = mod.Properties;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mod.Start();
            }
        }
    }
}
