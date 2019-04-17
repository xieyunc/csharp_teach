using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_HelloWrold_ByCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Label Label1;
            Label1 = new Label();
            Label1.Parent = this;
            Label1.Name = "Label1";
            Label1.Text = "Hello,World!";
            Label1.Location = new Point(20,50);//Label1控件的左上角的坐标（X,Y）

            InitializeComponent();
        }
    }
}
