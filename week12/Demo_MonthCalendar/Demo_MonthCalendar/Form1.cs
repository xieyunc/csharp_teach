using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");
            textBox2.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");
            textBox3.Text = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = Convert.ToInt16(numericUpDown1.Value);
        }
    }
}
