using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalManagementSystem.Connection;

namespace PersonalManagementSystem.Models
{
    class RegisterModel
    {
        public DataTable executeIsDuplicate(string email)
        {
            string emailSQL = "SELECT Email FROM Login WHERE Email = '" + email + "'";
            DataTable checkDuplicates = PersonalManagementSystem.Connection.ServerConnection.executeSQL(emailSQL);
            return checkDuplicates;
        }

        public DataTable executeRegisterSql(string name, string email, string password)
        {
            string registerSQL = string.Empty;

            registerSQL += "INSERT INTO Login (Full_Name, Email, Password)";
            registerSQL += "VALUES ('" + name + "','" + email + "','" + password + "')";

            DataTable userData = ServerConnection.executeSQL(registerSQL);
            return userData;

        }
    }
}
