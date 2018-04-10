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
    public partial class NewsAdd : Form
    {
        WebControler wc;

        public NewsAdd()
        {
            InitializeComponent();
        }


        private void addNewsBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text == "")
            {
                MessageBox.Show("Id不能为空");
                return;
            }
            else if(titleTextBox.Text == "")
            {
                MessageBox.Show("标题不能为空");
                return;
            }
            wc = new WebControler();
            Web wb = new Web();
            wb.Id = Convert.ToInt32(idTextBox.Text);
            wb.Title = titleTextBox.Text;
            wb.Content = contentTextBox.Text;
            wb.DateYM = Convert.ToInt32(dateYMTextBox.Text);
            wb.PicUrl = picUrlTextBox.Text;
            wb.Url = urlTextBox.Text;
            wb.PageEditor.Ename = enameTextBox.Text;
            if (wc.addNews(wb))
            {
                MessageBox.Show("添加成功!");
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败!");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
