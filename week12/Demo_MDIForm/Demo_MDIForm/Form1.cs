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
        public Form1()
        {
            InitializeComponent();
        }

        private void mi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mi_NewWindow_Click(object sender, EventArgs e)
        {
            Form aForm = new Form();
            aForm.Text = string.Format("Mdi Window {0}",this.MdiChildren.Count()+1);
            aForm.Width = 450;
            aForm.MdiParent = this;
            aForm.Show();
        }

        private void mi_CloseWindow_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void mi_Fill_Horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mi_Fill_Vertcal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mi_CascadeWindow_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

    }
}
