using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TabPage CreateNewPage()
        {
            int iCount = tabControl1.TabPages.Count + 1;
            string sTitle = "新增页" + iCount.ToString();

            TabPage aPage = new TabPage();
            aPage.Text = sTitle;
            aPage.UseVisualStyleBackColor = true;
            aPage.ImageIndex = 2;
            return aPage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage aPage = CreateNewPage();
            tabControl1.TabPages.Add(aPage);
            tabControl1.SelectedTab = aPage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int iCurrPageIndex = tabControl1.SelectedIndex;
            if (iCurrPageIndex == -1)
                iCurrPageIndex = 0;

            TabPage aPage = CreateNewPage();
            aPage.BackColor = Color.Red;

            tabControl1.TabPages.Insert(iCurrPageIndex, aPage);
            if (iCurrPageIndex < tabControl1.TabCount)
                tabControl1.SelectedIndex = iCurrPageIndex; //删除了当前页后，后面是否还有多余的页替换当前索引页
            else
                tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            tabControl1.SelectedTab = aPage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int iCurrPageIndex = tabControl1.SelectedIndex;
            if (iCurrPageIndex != -1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);//通过索引号来删除页
                if (iCurrPageIndex < tabControl1.TabCount)
                    tabControl1.SelectedIndex = iCurrPageIndex; //删除了当前页后，后面是否还有多余的页替换当前索引页
                else
                    tabControl1.SelectedIndex = tabControl1.TabCount - 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab != null)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);//通过页面对象来删除页
            }
        }
    }
}
