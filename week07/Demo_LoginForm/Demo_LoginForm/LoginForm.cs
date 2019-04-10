using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_LoginForm
{
    public partial class LoginForm : Form
    {
        private string _UserName = "admin";
        private string _UserPwd = "123456";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_UserPwd.Text = "";
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string userPwd = txt_UserPwd.Text;

            if ((userName==_UserName) && (userPwd ==_UserPwd))
            {
                MessageBox.Show(this, "用户名和密码验证通过，登录成功！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "用户名和密码验证失败，请检查后重试！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();//控件获取焦点
            }
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = (txt_UserName.Text != "") && (txt_UserPwd.Text != "");
        }

        private void txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_UserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            //此事件与KeyPress事件只需其一即可，不可两者均写
            if (e.KeyCode == Keys.Enter) //回车键
                btn_Login_Click(sender, e);
            else if (e.KeyCode == Keys.Cancel) //ESC键
                btn_Cancel_Click(sender, e);
        }
    }
}
