using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demo_Menu
{
    public partial class Form1 : Form
    {
        private string _FileName = "";
        private bool _IsSaved = true;

        private void SetRowColInfo()
        {

            int index = textBox1.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
            int row = textBox1.GetLineFromCharIndex(index) + 1;//得到当前行的行号,从0开始，习惯是从1开始，所以+1.
            int col = textBox1.SelectionStart - index + 1;//.SelectionStart得到光标所在位置的索引 减去 当前行第一个字符的索引 = 光标所在的列数（从0开始) 

            statusBar_Row.Text = row.ToString() + " 行";
            statusBar_Col.Text = col.ToString() + " 列";
        }

        private void NewFile()
        {
            if (!_IsSaved)
            {
                DialogResult dResult = MessageBox.Show(this,"当前文本已修改，需要保存吗？","提示信息",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
                if (dResult==DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dResult==DialogResult.Cancel)
                {
                    return;
                }
            }

            textBox1.Clear();
            _FileName = "";
            _IsSaved = true;
            this.Text = "新建文本文档";

            SetRowColInfo();
        }

        private void OpenFile()
        {
            if (!_IsSaved)
            {
                DialogResult dResult = MessageBox.Show(this, "当前文本已修改，需要保存吗？", "提示信息", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dResult == DialogResult.Yes)
                {
                    SaveFile();
                }
                else if (dResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _FileName = openFileDialog1.FileName;

                System.IO.StreamReader sr = new System.IO.StreamReader(_FileName, Encoding.UTF8);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();

                this.Text = _FileName;
                _IsSaved = true;
                SetRowColInfo();
            }
        }
        private void SaveFile()
        {

            //_FileName = "c:\\mm.txt";
            if (_FileName=="")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _FileName = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            System.IO.StreamWriter sw = new System.IO.StreamWriter(_FileName);
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();

            this.Text = _FileName;
            _IsSaved = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void mi_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mi_NewFile_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SetRowColInfo();
        }

        private void mi_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _IsSaved = false;
        }

        private void mi_SaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = _FileName;
            _FileName = "";
            SaveFile();
        }

        private void mi_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void mi_FontSet_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            SetRowColInfo();
        }
    }
}
