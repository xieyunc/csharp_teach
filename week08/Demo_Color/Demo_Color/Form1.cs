using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.LawnGreen;
            //label1.BackColor = System.Drawing.Color.FromArgb(124, 252, 0);//与上一条命令等价，效果是一样的。
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(255,0,0);
            //label1.ForeColor = System.Drawing.Color.Red;//与上一条命令等价，效果是一样的。
        }
    }
}
