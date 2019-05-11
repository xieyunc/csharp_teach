using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -label1.Width) //广告标签完全移出了左边
                label1.Left = this.Width;
            else
                label1.Left = label1.Left - 5;
        }

        private void mi_Start_Click(object sender, EventArgs e)
        {
            timer1.Interval = 200;//每隔0.2秒钟去执行一次timer1_Tick()事件函数中的内容。
            timer1.Enabled = true;//启用控件
            splitContainer1.Panel2Collapsed = false;//显示底部的panel2控件。
        }

        private void mi_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//停用控件
            splitContainer1.Panel2Collapsed = true;//隐藏底部的panel2控件。
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            mi_Start.Enabled = !timer1.Enabled;
            mi_Stop.Enabled = timer1.Enabled;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
