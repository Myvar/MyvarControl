using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpCore.UI
{
    public partial class PropDlg : Form
    {
        public PropDlg()
        {
            InitializeComponent();
        }

        public List<string> Options { get; set; }
        public string SeletedPanlel { get; set; } 

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                SeletedPanlel = listBox1.SelectedItem.ToString();
                this.Close();
            }
            else
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void AddDialog_Load(object sender, EventArgs e)
        {
            foreach(var i in Options)
            {
                listBox1.Items.Add(i);
            }
            listBox1.SelectedIndex = 0;
        }
    }
}
