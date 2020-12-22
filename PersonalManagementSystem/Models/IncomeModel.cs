using PersonalManagementSystem.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagementSystem.Models
{
    class IncomeModel
    {
        public DataTable displayAllIncomeData(int id)
        {
            string incomeSQL = "SELECT i.Income_ID, c.Name AS Payment_From, i.Description, i.Category, i.Account, i.Transaction_Date, i.Amount FROM Income AS i INNER JOIN Contact AS c ON i.Contact_ID = c.Contact_ID WHERE i.User_ID = '" + id + "'";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable displayPaymentFromList(int id)
        {
            string incomeSQL = "SELECT Contact_ID, Name AS Payment_From FROM Contact WHERE User_ID = '" + id + "'";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable addIncomeData(string description, string category, string account, DateTime date, float amount, int conid, int userid)
        {
            string contactSQL = string.Empty;
            contactSQL += "INSERT INTO Income (Description, Category, Account, Transaction_Date, Amount, Contact_ID, User_ID)";
            contactSQL += "VALUES ('" + description + "','" + category + "','" + account + "','" + date + "','" + amount + "','" + conid + "','" + userid + "')";

            DataTable contactData = ServerConnection.executeSQL(contactSQL);
            return contactData;
        }
    }
}
