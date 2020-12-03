using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalManagementSystem.Connection;

namespace PersonalManagementSystem.Models
{
    public class UserModel
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

        public DataTable executeIsDuplicate(string username)
        {
            string usernameSQL = "SELECT Email FROM [User] WHERE Username = '" + username + "'";
            DataTable checkDuplicates = PersonalManagementSystem.Connection.ServerConnection.executeSQL(usernameSQL);
            return checkDuplicates;
        }

        public DataTable executeRegisterSql(string name, string email, string username, string password)
        {
            string registerSQL = string.Empty;

            registerSQL += "INSERT INTO [User] (Full_Name, Email, Username, Password)";
            registerSQL += "VALUES ('" + name + "','" + email + "','" + username + "','" + password + "')";

            DataTable userData = ServerConnection.executeSQL(registerSQL);
            return userData;
        }
    }
}
