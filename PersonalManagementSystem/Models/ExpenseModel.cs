using PersonalManagementSystem.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagementSystem.Models
{
    class ExpenseModel
    {
        public DataTable displayAllExpenseData(int id)
        {
            string expenseSQL = "SELECT e.Expense_ID, c.Name AS Payment_To, e.Description, e.Category, e.Account, e.Transaction_Date, e.Amount FROM Expense AS e INNER JOIN Contact AS c ON e.Contact_ID = c.Contact_ID WHERE e.User_ID = '" + id + "'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable displayPaymentToList(int id)
        {
            string expenseSQL = "SELECT Contact_ID, Name AS Payment_To FROM Contact WHERE User_ID = '" + id + "'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable addExpenseData(string description, string category, string account, DateTime date, float amount, int conid, int userid)
        {
            string expenseSQL = string.Empty;
            expenseSQL += "INSERT INTO Expense (Description, Category, Account, Transaction_Date, Amount, Contact_ID, User_ID)";
            expenseSQL += "VALUES ('" + description + "','" + category + "','" + account + "','" + date + "','" + amount + "','" + conid + "','" + userid + "')";

            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable deleteExpenseData(object id)
        {
            string expenseSQL = "DELETE FROM Expense WHERE Expense_ID = '" + id + "'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable displayExpenseDataById(int id)
        {
            string expenseSQL = "SELECT Description, Category, Account, Transaction_Date, Amount, c.Name AS Payment_To, e.Contact_ID FROM Expense AS e INNER JOIN Contact AS c ON e.Contact_ID = c.Contact_ID WHERE Expense_ID = '" + id + "'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable updateExpenseData(string description, string category, string account, DateTime date, float amount, int conid, int expenseId)
        {
            string expenseSQL = "UPDATE Expense SET Description = '" + description + "', Category = '" + category + "', Account = '" + account + "', Transaction_Date = '" + date + "',  Amount = '" + amount + "', Contact_ID = '" + conid + "' WHERE Expense_ID = '" + expenseId + "'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable searchExpenseData(string name)
        {
            string expenseSQL = "SELECT e.Expense_ID, c.Name AS Payment_To, e.Description, e.Category, e.Account, e.Transaction_Date, e.Amount FROM Expense AS e INNER JOIN Contact AS c ON e.Contact_ID = c.Contact_ID WHERE c.Name LIKE '" + name + "%'";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable getExpenseCategoryOverview(int id)
        {
            string expenseSQL = "SELECT Category, count(Expense_ID) as Total from Expense where User_ID = '" + id + "' group by Category order by Category asc";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }

        public DataTable getTotalExpenses(int id)
        {
            string expenseSQL = "SELECT year(Transaction_Date) as Year, SUM(Amount) as Total from Expense where User_ID = '" + id + "' AND Transaction_Date is not null group by year(Transaction_Date) order by year(Transaction_Date) asc";
            DataTable expenseData = ServerConnection.executeSQL(expenseSQL);
            return expenseData;
        }
    }
}
