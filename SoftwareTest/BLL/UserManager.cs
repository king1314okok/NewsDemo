using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        UserDataService userData = new UserDataService();

        public bool login(User user)
        {
            string sql = String.Format("select * from user where username = '{0}' and password = '{1}'", user.Username, user.Password);
            return userData.ExecuteScalar(sql);
        }

        public bool ifRegister(User user)
        {
            string sql = String.Format("select * from user where username = '{0}'", user.Username);
            return userData.ExecuteScalar(sql);
        }

        public bool register(User user)
        {
            string sql = String.Format("insert into user(username,password,tel,email) values('{0}','{1}','{2}','{3}')", user.Username, user.Password, user.Tel, user.Email);
            return userData.ExecuteNonQuery(sql);
        }
    }
}
