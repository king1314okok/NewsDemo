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
    public partial class NewsView : Form
    {
        public delegate Web showWeb();
        public event showWeb show;
        private static Web web = new Web();
        WebControler wc = new WebControler();

        public NewsView()
        {
            InitializeComponent();
        }

        private void NewsView_Load(object sender, EventArgs e)
        {
            //titleLabel.Location = new Point((this.Width - titleLabel.Width) / 2, titleLabel.Height);
            this.Width = contentTextBox.Width + 50;
            this.Height = titleLabel.Height + contentTextBox.Height + picBox.Height;
            editorLabel.Text = web.PageEditor.Ename;
            titleLabel.Text = web.Title;
            contentTextBox.Text = "     "+web.Content;
            //Console.WriteLine("图片地址是:" + web.PicUrl);
            getUrlImage(web.PicUrl);

        }

        public Web getWeb()
        {
            web = show();
            return web;
        }

        private void getUrlImage(string url)
        {
            try
            {
                System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
                System.Net.WebResponse webres = webreq.GetResponse();
                using (System.IO.Stream stream = webres.GetResponseStream())
                {
                    //picBox.Location = new Point(picBox.Width, contentTextBox.Height);
                    picBox.Image = Image.FromStream(stream);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void delNewsBtn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否删除该新闻", "删除", MessageBoxButtons.OKCancel);
            if(dr == DialogResult.OK)
            {
                wc.delNews(web);
                this.Close();
            }
        }
    }
}
