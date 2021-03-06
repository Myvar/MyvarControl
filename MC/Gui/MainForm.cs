﻿using CpCore;
using Gui.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        public List<string> Panels = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            foreach (var i in Directory.GetDirectories("Panels"))
            {
                Panels.Add(i);
            }

            cp = new MControlPanel(HostP);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.AddNewPanel(new MControl());
        }

        private void newControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDialog dlg = new AddDialog();
            dlg.Options = Panels;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Moduel m = new Moduel();
                m.Load(dlg.SeletedPanlel);
                m.Hcontrol.Location = MouseLoc;
                m.Hcontrol.mod = m;
                cp.AddNewPanel(m.Hcontrol);
                m.Start();
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void HostP_MouseMove(object sender, MouseEventArgs e)
        {
            MouseLoc = new Point(e.X, e.Y);
        }

        private void savePanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Control Panel Files | *.cp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                MControlPanel.Save(dlg.FileName, cp);

            }
        }

        private void loadPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Control Panel Files | *.cp";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                cp = MControlPanel.Load(dlg.FileName);
                cp.Host = HostP;
                cp.Reload(true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArduinoCore.Arduino ad = new ArduinoCore.Arduino("COM4");
            ad.SetPin(13, 1);
           
        }

        private void showBorderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if((sender as ToolStripMenuItem).Checked)
            {
                cp.ShowBorders(true);
            }
            else
            {
                cp.ShowBorders(false);
            }
            
        }

        private void canDragToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Checked)
            {
                cp.CanDrag(true);
            }
            else
            {
                cp.CanDrag(false);
            }
        }
    }
}