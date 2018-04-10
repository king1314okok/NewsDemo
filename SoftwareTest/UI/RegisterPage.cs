using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class RegisterPage : Form
    {
        UserManager usermanager;
        public RegisterPage()
        {
            InitializeComponent();
            usermanager = new UserManager();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if(passwdTextBox1.Text != passwdTextBox2.Text)
            {
                MessageBox.Show("密码不一致");
                return;
            }

            User user = new User();
            user.Username = usernameTextBox.Text;
            user.Password = passwdTextBox1.Text;
            user.Tel = telTextBox.Text;
            user.Email = emailTextBox.Text;

            if (user.Username == "")
            {
                MessageBox.Show("用户名不能为空");
                return;
            }
            else if(user.Password == "")
            {
                MessageBox.Show("密码不能为空");
                return;
            }


            if (usermanager.ifRegister(user))
            {
                MessageBox.Show("该用户名已注册!");
            }
            if(usermanager.register(user))
            {
                MessageBox.Show("恭喜"+user.Username+" 注册成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败!");
            }

        }
    }
}
