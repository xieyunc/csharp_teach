using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demol_HelloWorld_PositionInCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ww = this.Width;
            int w1 = label1.Width;
            int X = (ww - w1) / 2;
            label1.Location = new Point(X, label1.Location.Y);
        }
    }
}
