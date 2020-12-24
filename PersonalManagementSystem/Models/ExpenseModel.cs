﻿using PersonalManagementSystem.Connection;
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
    }
}