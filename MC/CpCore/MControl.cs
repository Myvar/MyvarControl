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

namespace CpCore
{
    public partial class MControl : UserControl
    {
        public Moduel mod { get; set; }

        public MControl()
        {
            InitializeComponent();
        }

        private void MControl_Load(object sender, EventArgs e)
        {
            DragExtension.Draggable(this, true);
            TCResize ResizebleThis = new TCResize(this);
        }

        private void MControl_MouseDown(object sender, MouseEventArgs e)
        {
            this.BringToFront();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropDlg dlg = new PropDlg();
            dlg.Options = new List<string>() { "COM4"};
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                mod.Engine.ComPort = dlg.SeletedPanlel;
            }
           
        }
    }
}
