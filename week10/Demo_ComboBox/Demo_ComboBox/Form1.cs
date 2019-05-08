using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //增加项
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //按内容删除项
            comboBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //插入项
            int i = comboBox1.SelectedIndex;//获取ListBox中当前选中的行
            if (i==-1) //如果没有行被选中
                i = 0;

            comboBox1.Items.Insert(i, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //按索引删除项
            if (comboBox1.SelectedIndex!=-1) //如果选中了项目
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //获取ListBox的状态
            textBox2.Clear();

            textBox2.AppendText(string.Format("选中项索引号：{0}\r\n", comboBox1.SelectedIndex));//如果为多选模式，SelectedIndex返回第一个选中项的索引号
            if (comboBox1.SelectedIndex != -1)
                textBox2.AppendText(string.Format("选中项内容：{0}\r\n", comboBox1.SelectedItem.ToString()));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //清空全部项
            comboBox1.Items.Clear();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
