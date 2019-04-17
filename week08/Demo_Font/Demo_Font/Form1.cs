using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fontName = textBox1.Text;//取得字体名称
            float fontSize = Convert.ToSingle(textBox2.Text);//文本字符串转换为float类型

            label1.Font = new Font(fontName, fontSize, label1.Font.Style);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
             * ================方法一 BEGIN =======================*
            FontStyle fs = (FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);//初始化时加上三种效果

            if (!checkBox1.Checked)
                fs -= FontStyle.Bold;//去除加粗效果
            if (!checkBox2.Checked)
                fs -= FontStyle.Italic;//去除倾斜效果
            if (!checkBox3.Checked)
                fs -= FontStyle.Underline;//去除下划线效果
            label1.Font = new Font(label1.Font, fs);
             * 
             *=================方法一 END =========================* 
            */


            /*
             * ================方法二 BEGIN =======================*
            */
            if (checkBox1.Checked)
                label1.Font = new Font(label1.Font,label1.Font.Style | FontStyle.Bold);//加粗效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Bold);//取消加粗

            if (checkBox2.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Italic);//倾斜效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Italic);//取消倾斜

            if (checkBox3.Checked)
                label1.Font = new Font(label1.Font, label1.Font.Style | FontStyle.Underline);//下划线效果
            else
                label1.Font = new Font(label1.Font, label1.Font.Style & ~FontStyle.Underline);//取消下划线
            /*
             *=================方法二 END =========================* 
            */
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.Font = label1.Font;

            if (fd.ShowDialog()==DialogResult.OK)
                label1.Font = fd.Font;
        }
    }
}
