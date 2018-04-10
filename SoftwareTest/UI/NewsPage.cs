using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace UI
{
    public partial class NewsPage : Form
    {
        public delegate string showUserName();
        public event showUserName showName;

        private WebControler wc = new WebControler();
        private List<Web> webs = new List<Web>();
        private List<LinkLabel> linkLabels = new List<LinkLabel>();
        private Web currentWeb = new Web();
        static int rowsNum = 0;
        static int pageNum = 1;
        static int currentPage = 1;
        static int remain = 0;
        Object form;

        public NewsPage(Object form)
        {
            this.form = form;
            InitializeComponent();
        }

        public NewsPage()
        {
            InitializeComponent();
        }

        private void NewsView_Load(object sender, EventArgs e)
        {
            loadLinkLabel();
        }

        public void setTitleUserName()
        {
            this.Text = "欢迎您," + showName() + " !";
        }


        private void loadLinkLabel()
        {
            resetWebsLabel();
            showPages();
        }

        private void cutTitle()
        {
            foreach (Web wb in webs)
            {
                if (wb.Title.Length >= 20)
                {
                    wb.Title = wb.Title.Substring(0, 20);
                }
            }
        }

        private int getPageNum()
        {
            pageNum = 1;
            int result = rowsNum;
            while(true)
            {
                if (result > 5)
                {
                    result = result - 5;
                    pageNum++;
                }
                else
                    break;
            }
            return pageNum;
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            if(currentPage == pageNum)
            {
                MessageBox.Show("这是最后一页!");
                return;
            }
            if (pageNum != 0)
            {
                if((currentPage+1) == pageNum)
                {
                    for(int i = 0; i < remain; i++)
                        linkLabels[i].Text = webs[i + 5 * (currentPage)].Title;
                    for (int i = remain; i < 5; i++)
                        linkLabels[i].Text = "";
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (currentPage != pageNum)
                            linkLabels[i].Text = webs[i + 5 * (currentPage)].Title;
                    }
                }
            }
            currentPage++;
            pageNumLabel.Text = currentPage.ToString();
        }

        private void previousPageBtn_Click(object sender, EventArgs e)
        {
            if (currentPage == 1)
            {
                MessageBox.Show("这是第一页!");
                return;
            }
            currentPage--;
            if (pageNum != 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (currentPage != 0)
                        linkLabels[i].Text = webs[i + 5 * (currentPage-1)].Title;
                }
            }
            pageNumLabel.Text = currentPage.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentWeb = webs[0 + (currentPage-1) * 5];
            sendWeb();
            new NewsView().Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentWeb = webs[1 + (currentPage-1) * 5];
            sendWeb();
            new NewsView().Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentWeb = webs[2 + (currentPage - 1) * 5];
            sendWeb();
            new NewsView().Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentWeb = webs[3 + (currentPage - 1) * 5];
            sendWeb();
            new NewsView().Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            currentWeb = webs[4 + (currentPage - 1) * 5];
            sendWeb();
            new NewsView().Show();
        }

        private void sendWeb()
        {
            NewsView nv = new NewsView();
            nv.show += new NewsView.showWeb(setWeb);
            nv.getWeb();
        }

        private Web setWeb()
        {
            return currentWeb;
        }

        private void newsAddBtn_Click(object sender, EventArgs e)
        {
            new NewsAdd().Show();
        }

        private void flushBtn_Click(object sender, EventArgs e)
        {
            loadLinkLabel();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string title = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("输入要查找的标题(模糊查找)", "查找"));
            searchFlush(title);
            showPages();
        }

        private void resetWebsLabel()
        {
            linkLabels.Clear();
            webs.Clear();
            linkLabels.Add(linkLabel1);
            linkLabels.Add(linkLabel2);
            linkLabels.Add(linkLabel3);
            linkLabels.Add(linkLabel4);
            linkLabels.Add(linkLabel5);
            rowsNum = wc.getPageInfo(webs);
            remain = rowsNum % 5;
            getPageNum();
            currentPage = 1;
            cutTitle();
        }

        private void searchFlush(string title)
        {
            linkLabels.Clear();
            webs.Clear();
            linkLabels.Add(linkLabel1);
            linkLabels.Add(linkLabel2);
            linkLabels.Add(linkLabel3);
            linkLabels.Add(linkLabel4);
            linkLabels.Add(linkLabel5);
            rowsNum = wc.getSearchNews(webs,title);
            remain = rowsNum % 5;
            getPageNum();
            currentPage = 1;
            cutTitle();
        }

        private void showPages()
        {
            pageNumLabel.Text = currentPage.ToString();
            if (rowsNum <= 5)
            {
                foreach (LinkLabel lb in linkLabels)
                {
                    lb.Text = "";
                }
            }
            if (currentPage != pageNum)
            {
                for (int i = 0; i < 5; i++)
                    linkLabels[i].Text = webs[i + 5 * (currentPage - 1)].Title;
            }
            else
            {
                for (int i = 0; i < remain; i++)
                    linkLabels[i].Text = webs[i + 5 * (currentPage - 1)].Title;
            }
        }

        private void NewsPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fm = (Form)form;
            fm.Close();
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            string helpText = "本系统用于用户管理多人共享新闻网页,既共享新闻网页书签.登入后,点击新闻列表即可查看新闻,点击下面按钮即可进行添加查找新闻等操作.";
            MessageBox.Show(helpText, "帮助");
        }
    }
}
