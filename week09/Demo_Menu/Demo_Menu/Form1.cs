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

        private void NewFile()
        {
            textBox1.Clear();
            _FileName = "";
            _IsSaved = true;
            this.Text = "新建文本文档";
            textBox1.Focus();
        }

        private void SaveFile()
        {
            if(_FileName == "")
            {
                if (saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    _FileName = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            this.Text = _FileName;

            System.IO.StreamWriter sw = new System.IO.StreamWriter(_FileName);
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
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

        private void mi_OpenFile_Click(object sender, EventArgs e)
        {
            string fileName;
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                System.IO.StreamReader sr;//读取数据流
                sr = new System.IO.StreamReader(fileName, Encoding.UTF8);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
                textBox1.Focus();
                _FileName = fileName;
                _IsSaved = true;
                this.Text = _FileName;
            }
        }

        private void mi_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void mi_SaveAs_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                _FileName = saveFileDialog1.FileName;
                SaveFile();
            }
        }

        private void mi_FontSetup_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void mi_AutoLine_Click(object sender, EventArgs e)
        {
            mi_AutoLine.Checked = !mi_AutoLine.Checked;
            textBox1.WordWrap = mi_AutoLine.Checked;
        }
    }
}
