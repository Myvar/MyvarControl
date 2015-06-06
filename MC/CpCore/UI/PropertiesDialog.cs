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
    public partial class PropertiesDialog : Form
    {
        public Dictionary<string, string> Properties { get; set; }

        public PropertiesDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Clear();
            foreach(DataGridViewRow i in dataGridView1.Rows)
            {
                try
                {
                    var a = i.Cells[0].Value.ToString();
                    var b = i.Cells[1].Value.ToString();
                    Properties.Add(a, b);
                }
                catch
                {

                }
            }
            Close();
        }

        private void PropertiesDialog_Load(object sender, EventArgs e)
        {
            foreach(var i in Properties)
            {
                dataGridView1.Rows.Add(i.Key, i.Value);
            }
        }
    }
}
