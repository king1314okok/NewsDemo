using BLL;
using Models;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        string username = "";

        public Login()
        {
            InitializeComponent();
            this.pwdText.PasswordChar = '*';
        }

        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            User user = new User(userText.Text,pwdText.Text);
            UserManager usermanager = new UserManager();
            username = user.Username;
            if (usermanager.login(user))
            {
                NewsPage np = new NewsPage((Object)this);
                np.showName += new NewsPage.showUserName(setUserName);
                np.setTitleUserName();
                np.Show();
                this.Hide();
                //MessageBox.Show("登录成功");
            }
            else
                MessageBox.Show("登录失败");
            //new FunctionSelect().Show();
        }

        private string setUserName()
        {
            return username;
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            new RegisterPage().Show();
        }

        private void viewUserBtn_Click(object sender, EventArgs e)
        {
            string adminPwd = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("请输入管理员密码", "输入密码"));
            if(adminPwd == "123")
            {
                new ViewUsers().Show();
            }
        }
    }
}
