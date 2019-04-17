using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_HelloWorld_ByCode_In_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ww = this.Width;//窗口的宽度
            int w1 = Label1.Width;//标签Label1的宽度
            int x = (ww - w1) / 2;//计算Label1.X的值
            Label1.Location = new Point(x,Label1.Location.Y);
        }
    }
}
