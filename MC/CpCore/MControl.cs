using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpCore
{
    public partial class MControl : UserControl
    {
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
    }
}
