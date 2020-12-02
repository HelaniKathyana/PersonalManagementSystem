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
        public DataTable executeLoginSql(string username, string password)
        {
            string loginSQL = string.Empty;

            loginSQL += "SELECT * FROM [User] ";
            loginSQL += "WHERE Username = '" + username + "' ";
            loginSQL += "AND Password = '" + password + "'";

            DataTable loginData = ServerConnection.executeSQL(loginSQL);

            return loginData;
        }
    }
}
