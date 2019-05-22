using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = treeView1.SelectedNode.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                TreeNode tn;
                if (treeView1.SelectedNode != null)
                {
                    tn = treeView1.SelectedNode;
                    tn.Nodes.Add(textBox2.Text);
                }
                else
                {
                    tn = treeView1.Nodes.Add(textBox2.Text);
                }
            }
            else
            {
                MessageBox.Show("项目名称不能为空！");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            else
                MessageBox.Show("没有选中的项目！");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
