using CpCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gui
{
    public partial class MainForm : Form
    {
        MControlPanel cp;
        public Point MouseLoc = new Point();


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            cp = new MControlPanel(HostP);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.AddNewPanel(new MControl());
        }

        private void newControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.AddNewPanel(new MControl() { Location = MouseLoc });
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void HostP_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = new Point(e.X, e.Y);
        }
    }
}
