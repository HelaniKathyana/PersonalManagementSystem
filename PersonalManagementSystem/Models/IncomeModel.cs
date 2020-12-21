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
            string contactSQL = "SELECT Income_ID, Payment_From, Description, Category, Account, Transaction_Date, Amount FROM Income WHERE User_ID = '" + id + "'";
            DataTable contactData = ServerConnection.executeSQL(contactSQL);
            return contactData;
        }
    }
}
