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
            textBox1.Text = treeView1.SelectedNode.Text+"(级别:"+(treeView1.SelectedNode.Level+1).ToString()+")";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();//展开节点
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();//收缩节点
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                TreeNode tn,tn1;
                if (treeView1.SelectedNode != null)
                {
                    tn = treeView1.SelectedNode;
                    tn1 = tn.Nodes.Add(textBox2.Text);
                }
                else
                {
                    tn = treeView1.Nodes.Add(textBox2.Text);
                    tn1 = tn;
                }
                tn.Expand();//展开tn节点
                treeView1.SelectedNode = tn1;//把新增节点设置为当前选中的节点
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                treeView1.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(treeView1_DrawNode);
                treeView1.DrawMode = TreeViewDrawMode.OwnerDrawText;
            }
            else
            {
                treeView1.DrawMode = TreeViewDrawMode.Normal;
            }
        }

        private void treeView1_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true;
            return;
        }
    }
}
