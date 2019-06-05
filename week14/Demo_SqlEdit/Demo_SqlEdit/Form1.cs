using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_SqlEdit
{
    public partial class Form1 : Form
    {
        private void InitEditControl()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "男";
            textBox4.Text = "2019";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InitEditControl();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitEditControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xh, xm, xb, nj, xy, zy, bj, dh, sError;//注释一下
            sError = "";
            MsSql mySql = new MsSql();
            xh = textBox1.Text.Trim();
            xm = textBox2.Text.Trim();
            xb = textBox3.Text.Trim();
            nj = textBox4.Text.Trim();
            xy = textBox5.Text.Trim();
            zy = textBox6.Text.Trim();
            bj = textBox7.Text.Trim();
            dh = textBox8.Text.Trim();

            int iResult = mySql.InsertData(xh,xm,xb,nj,xy,zy,bj,dh,out sError);
            if (iResult>0)
                MessageBox.Show(string.Format("数据库插入成功！{0}条记录已更新！",iResult));
            else
                MessageBox.Show(string.Format("数据库插入失败！{0}", sError));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string xh = textBox9.Text.Trim();
            string xm, xb, nj, xy, zy, bj, dh, sError;

            MsSql mySql = new MsSql();
            if (mySql.LocateXsInfo(xh, out xm, out xb, out nj, out xy, out zy, out bj, out dh,out sError))
            {
                textBox1.Text = xh;
                textBox2.Text = xm;
                textBox3.Text = xb;
                textBox4.Text = nj;
                textBox5.Text = xy;
                textBox6.Text = zy;
                textBox7.Text = bj;
                textBox8.Text = dh;
                textBox1.ReadOnly = true;
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show(string.Format("学号为{0}的学生不存在！"+sError,xh));
                InitEditControl();
                textBox1.ReadOnly = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            string xh, xm, xb, nj, xy, zy, bj, dh, sError;//注释一下
            sError = "";
            MsSql mySql = new MsSql();
            xh = textBox1.Text.Trim();
            xm = textBox2.Text.Trim();
            xb = textBox3.Text.Trim();
            nj = textBox4.Text.Trim();
            xy = textBox5.Text.Trim();
            zy = textBox6.Text.Trim();
            bj = textBox7.Text.Trim();
            dh = textBox8.Text.Trim();

            int iResult = mySql.UpdateData(xh, xm, xb, nj, xy, zy, bj, dh, out sError);
            if (iResult > 0)
                MessageBox.Show(string.Format("数据库更新成功！{0}条记录已更新！", iResult));
            else
                MessageBox.Show(string.Format("数据库更新失败！{0}", sError));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string xh,sError;//注释一下
            sError = "";
            MsSql mySql = new MsSql();
            xh = textBox1.Text.Trim();

            int iResult = mySql.DeleteData(xh, out sError);
            if (iResult > 0)
            {
                MessageBox.Show(string.Format("数据库删除成功！{0}条记录已更新！", iResult));
                InitEditControl();
            }
            else
                MessageBox.Show(string.Format("数据库删除失败！{0}", sError));
        }
    }
}
