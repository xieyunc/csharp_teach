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

        private void Form1_Load(object sender, EventArgs e)
        {
            Label Label2 = new Label();//Label2的作用域只在本函数中
            Label2.Parent = this;
            Label2.AutoSize = true;
            Label2.Location = new Point(100,80);
            Label2.Text = "小宇飞刀";
        }
    }
}
