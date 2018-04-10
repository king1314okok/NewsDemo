using Models;
using MySql.Data.MySqlClient;
using System;

namespace DAL
{
    public class UserDataService
    {
        string sqlOption = "server= 112.74.77.163; user id= root;password = aptx-4869;database = newsDemo";
      
        public bool ExecuteScalar(string sql)
        {
            bool result = false;
            MySqlConnection sqlcon = new MySqlConnection(sqlOption);
            try
            {
                sqlcon.Open();
                MySqlCommand sqlcmd = new MySqlCommand(sql,sqlcon);
                Object sqlResult = sqlcmd.ExecuteScalar();
                if (sqlResult != null)
                {
                    result = true;
                }
                else
                    result = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                sqlcon.Close();
            }
            return result;
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

    }
}
