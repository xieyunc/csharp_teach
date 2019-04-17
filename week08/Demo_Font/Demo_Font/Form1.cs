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
            string fontName = textBox2.Text;
            float fontSize = Convert.ToSingle(textBox1.Text);
            label1.Font = new Font(textBox2.Text, fontSize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, label1.Font.Size, (FontStyle.Bold | FontStyle.Italic | FontStyle.Underline));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle fontStyle;
            fontStyle = (FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);

            if (!checkBox1.Checked)
                fontStyle -= FontStyle.Bold;
            if (!checkBox2.Checked)
                fontStyle -= FontStyle.Italic;
            if (!checkBox3.Checked)
                fontStyle -= FontStyle.Underline;

            label1.Font = new Font(label1.Font.Name, label1.Font.Size, fontStyle);
        }
    }
}
