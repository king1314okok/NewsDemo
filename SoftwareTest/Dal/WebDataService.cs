using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class WebDataService
    {
        string sqlOption = "server= 112.74.77.163; user id= root;password = aptx-4869;database = newsDemo;charset = utf8";

        public string getWebTitle(string url)
        {
            //请求资源  
            System.Net.WebRequest wb = System.Net.WebRequest.Create(url.Trim());

            //响应请求  
            WebResponse webRes = null;

            //将返回的数据放入流中  
            Stream webStream = null;
            try
            {
                webRes = wb.GetResponse();
                webStream = webRes.GetResponseStream();
            }
            catch
            {
                return "输入的网址不存在或非法...";
            }


            //从流中读出数据  
            StreamReader sr = new StreamReader(webStream, System.Text.Encoding.UTF8);

            //创建可变字符对象，用于保存网页数据   
            StringBuilder sb = new StringBuilder();

            //读出数据存入可变字符中  
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                sb.Append(str);
            }

            //建立获取网页标题正则表达式  
            string regex = @"<title>.+</title>";

            //返回网页标题  
            string title = Regex.Match(sb.ToString(), regex).ToString();
            title = Regex.Replace(title, @"[<title>/]", "");
            return title;
        }

        public string GetContentType(string extension)
        {
            string reval = string.Empty;

            if (string.IsNullOrEmpty(extension))
                return null;

            switch (extension)
            {
                case ".htm":
                    reval = "text/html";
                    break;
                case ".html":
                    reval = "text/html";
                    break;
                case ".txt":
                    reval = "text/plain";
                    break;
                case ".css":
                    reval = "text/css";
                    break;
                case ".png":
                    reval = "image/png";
                    break;
                case ".gif":
                    reval = "image/gif";
                    break;
                case ".jpg":
                    reval = "image/jpg";
                    break;
                case ".jpeg":
                    reval = "image/jgeg";
                    break;
                case ".zip":
                    reval = "application/zip";
                    break;
            }
            return reval;
        }

        public string GetURLResult(string strUrl)
        {
            string strMsg = "";
            try
            {
                WebRequest request = WebRequest.Create(strUrl);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("gb2312"));
                strMsg = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                response.Close();
                return strMsg;
            }
            catch
            {
                Console.WriteLine("连接失败");
                return null;
            }
        }

        public int getPageInfo(List<Web> webs,string sql)
        {
            int i = 0;
            MySqlConnection sqlcon = new MySqlConnection(sqlOption);
            try
            {
                sqlcon.Open();
                MySqlCommand sqlcmd = new MySqlCommand(sql, sqlcon);
                MySqlDataReader read = sqlcmd.ExecuteReader();
                while (read.Read())//读取每行数据
                {
                    //获取字段信息
                    Web queryResult = new Web();
                    queryResult.Id = read.GetInt32("id");
                    queryResult.DateYM = read.GetInt32("dateYM");
                    queryResult.Title = read.GetString("title");
                    queryResult.Content = read.GetString("content");
                    queryResult.PicUrl = read.GetString("picUrl");
                    queryResult.Url = read.GetString("url");
                    queryResult.PageEditor.Ename = read.GetString("Ename");
                    queryResult.PageEditor.Eid = Convert.ToInt32(read.GetString("Eid"));
                    webs.Add(queryResult);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            return i;
        }

        public bool ExecuteNonQuery(string sql)
        {
            bool result = false;
            MySqlConnection sqlcon = new MySqlConnection(sqlOption);
            try
            {
                sqlcon.Open();
                MySqlCommand sqlcmd = new MySqlCommand(sql, sqlcon);
                Object sqlResult = sqlcmd.ExecuteNonQuery();
                if ((int)sqlResult == 1)
                {
                    result = true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlcon.Close();
            }
            return result;
        }

        public DataTable getDataTable(string sql)
        {
            DataSet ds = new DataSet();
            MySqlConnection sqlcon = new MySqlConnection(sqlOption);
            try
            {
                sqlcon.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, sqlcon);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return ds.Tables[0];
        }

        public string getEid(string sql)
        {
            string Eid = "";
            MySqlConnection sqlcon = new MySqlConnection(sqlOption);
            try
            {
                sqlcon.Open();
                MySqlCommand sqlcmd = new MySqlCommand(sql, sqlcon);
                MySqlDataReader read = sqlcmd.ExecuteReader();
                while (read.Read())//读取每行数据
                {
                    //获取字段信息
                    Eid = read.GetInt32("Eid").ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                sqlcon.Close();
            }
            return Eid;
        }
    }
}
