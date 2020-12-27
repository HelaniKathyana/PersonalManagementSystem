using PersonalManagementSystem.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagementSystem.Models
{
    class ReportModel
    {
        public DataTable displayAllReportData(int id)
        {
            string reportSQL = "SELECT Name, Type, Start_Date, End_Date, Created FROM Report WHERE User_ID = '" + id + "'";
            DataTable reportData = ServerConnection.executeSQL(reportSQL);
            return reportData;
        }

        public DataTable addReportData(string name, string type, DateTime startDate, DateTime endDate, DateTime created, int id)
        {
            string reportSQL = string.Empty;
            reportSQL += "INSERT INTO Report (Name, Type, Start_Date, End_Date, Created, User_ID)";
            reportSQL += "VALUES ('" + name + "','" + type + "','" + startDate + "','" + endDate + "','" + created + "','" + id + "')";

            DataTable reportData = ServerConnection.executeSQL(reportSQL);
            return reportData;
        }

        public DataTable getIncomeSummary(int id, DateTime startDate, DateTime endDate)
        {
            string reportSQL = "SELECT Category, SUM(Amount) as Total_Salary FROM Income WHERE User_ID = '" + id + "' AND Transaction_Date BETWEEN '" + startDate + "' AND '" + endDate + "' group by Category order by Category asc";
            DataTable reportData = ServerConnection.executeSQL(reportSQL);
            return reportData;
        }

        public DataTable getExpenseSummary(int id, DateTime startDate, DateTime endDate)
        {
            string reportSQL = "SELECT Category, SUM(Amount) as Total_Salary FROM Expense WHERE User_ID = '" + id + "' AND Transaction_Date BETWEEN '" + startDate + "' AND '" + endDate + "' group by Category order by Category asc";
            DataTable reportData = ServerConnection.executeSQL(reportSQL);
            return reportData;
        }
    }
}
