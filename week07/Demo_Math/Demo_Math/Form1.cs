using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Math
{
    public partial class Form1 : Form
    {
        private int _a;
        private int _b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            _a = r.Next(1, 10);
            _b = r.Next(1, 10);
            label2.Text = Convert.ToString(_a) + "+" + Convert.ToString(_b) + "=";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x == _a+_b)
            {
                lbl_Msg.Text = "你答对了，真棒！";
            }
            else
            {
                lbl_Msg.Text = "你答错了，加油！";
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Next_Click(sender, e);
        }
    }
}
