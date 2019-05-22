using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MDIForm
{
    public partial class Form1 : Form
    {
        private Form2 aForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void mi_File_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mi_File_OpenForm2_Click(object sender, EventArgs e)
        {
            if (aForm==null)
                aForm = new Form2();
            aForm.MdiParent = this;
            aForm.Show();
        }

        private void mi_File_CloseForm2_Click(object sender, EventArgs e)
        {
            aForm.Close();
            aForm = null;
        }

        private void mi_Win_NewForm_Click(object sender, EventArgs e)
        {
            Form aForm = new Form();
            aForm.MdiParent = this;
            aForm.Width = 450;
            aForm.Text = string.Format("新窗口 {0}",this.MdiChildren.Count());
            aForm.Show();
        }

        private void mi_Win_CloseForm_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();//关闭当前活动的窗口
        }

        private void mi_Win_DropDownOpened(object sender, EventArgs e)
        {
            mi_Win_CloseForm.Enabled = (this.ActiveMdiChild != null);
        }

        private void mi_Win_Title_H_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);//窗口水平分割排列
        }

        private void mi_Win_Title_V_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);//窗口垂直分割排列
        }

        private void mi_Win_Cas_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);//窗口层叠排列
        }

        private void mi_Help_About_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog();
        }
    }
}
