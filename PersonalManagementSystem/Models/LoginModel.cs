using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalManagementSystem.Connection;

namespace PersonalManagementSystem.Models
{
    class LoginModel
    {
        public DataTable executeLoginSql(string email, string password)
        {
            string loginSQL = string.Empty;

            loginSQL += "SELECT * FROM Login ";
            loginSQL += "WHERE Email = '" + email + "' ";
            loginSQL += "AND Password = '" + password + "'";

            DataTable userData = ServerConnection.executeSQL(loginSQL);

            return userData;
        }
    }
}
