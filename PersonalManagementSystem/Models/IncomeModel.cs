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

        public DataTable displayIncomeDataById(int id)
        {
            string incomeSQL = "SELECT Description, Category, Account, Transaction_Date, Amount, c.Name AS Payment_From, i.Contact_ID FROM Income AS i INNER JOIN Contact AS c ON i.Contact_ID = c.Contact_ID WHERE Income_ID = '" + id + "'";
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
            string incomeSQL = string.Empty;
            incomeSQL += "INSERT INTO Income (Description, Category, Account, Transaction_Date, Amount, Contact_ID, User_ID)";
            incomeSQL += "VALUES ('" + description + "','" + category + "','" + account + "','" + date + "','" + amount + "','" + conid + "','" + userid + "')";

            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable deleteIncomeData(object id)
        {
            string incomeSQL = "DELETE FROM Income WHERE Income_ID = '" + id + "'";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable updateIncomeData(string description, string category, string account, DateTime date, float amount, int conid, int incomeid)
        {
            string incomeSQL = "UPDATE Income SET Description = '" + description + "', Category = '" + category + "', Account = '" + account + "', Transaction_Date = '" + date + "',  Amount = '" + amount + "', Contact_ID = '" + conid + "' WHERE Income_ID = '" + incomeid + "'";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable searchIncomeData(string name)
        {
            string incomeSQL = "SELECT i.Income_ID, c.Name AS Payment_From, i.Description, i.Category, i.Account, i.Transaction_Date, i.Amount FROM Income AS i INNER JOIN Contact AS c ON i.Contact_ID = c.Contact_ID WHERE c.Name LIKE '" + name + "%'";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }

        public DataTable getIncomeCategoryOverview(int id)
        {
            string incomeSQL = "SELECT Category, count(Income_ID) as Total from Income where User_ID = '" + id + "' group by Category order by Category asc";
            DataTable incomeData = ServerConnection.executeSQL(incomeSQL);
            return incomeData;
        }
    }
}
