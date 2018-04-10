
using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BLL
{
    public class WebControler
    {
        WebDataService wds = new WebDataService();

        public string getWebTitle(string url)
        {
            return wds.getWebTitle(url);
        }

        public string getURLResult(string url)
        {
            return wds.GetURLResult(url);
        }

        public int getPageInfo(List<Web> webs)
        {
            string sql = "select news.id,dateYM,title,content,picUrl,url,editor.Ename,editor.Eid from news,editor,editedPage where editedPage.id = news.id and editedPage.Eid = editor.Eid;";
            return wds.getPageInfo(webs,sql);
        }

        public bool addNews(Web wb)
        {
            bool result = false;
            string Eid = getEid(wb);
            string sql3 = String.Format("insert into editor(Ename) values('{0}')",wb.PageEditor.Ename);
            if (Eid == "fail")
                wds.ExecuteNonQuery(sql3);//插入editor
            string sql1 = String.Format("insert into news(id,title,content,dateYM,picUrl,url) values('{0}','{1}','{2}','{3}','{4}','{5}')", wb.Id, wb.Title, wb.Content, wb.DateYM, wb.PicUrl, wb.Url);
            string sql2 = String.Format("insert into editedPage(id,Eid) values({0},'{1}')", wb.Id, getEid(wb));
            if (wds.ExecuteNonQuery(sql1) && wds.ExecuteNonQuery(sql2))
                result = true;
            return result;
        }

        public bool delNews(Web wb)
        {
            string sql = String.Format("delete from news where news.id = '{0}'", wb.Id);
            return wds.ExecuteNonQuery(sql);
        }

        public int getSearchNews(List<Web> webs,string searchTitle)
        {
            string sql = String.Format("select news.id,dateYM,title,content,picUrl,url,editor.Ename,editor.Eid from news,editor,editedPage where editedPage.id = news.id and editedPage.Eid = editor.Eid and title like '%{0}%'", searchTitle);
            return wds.getPageInfo(webs, sql);
        }

        public DataTable getDataTable()
        {
            string sql = "select * from user";
            return wds.getDataTable(sql);
        }

        public string getEid(Web wb)
        {
            string sql = String.Format("select Eid from editor where Ename = '{0}'",wb.PageEditor.Ename);
            string result = wds.getEid(sql);
            if (result == "")
                return "fail";
            else
                return result;
        }
    }
}
