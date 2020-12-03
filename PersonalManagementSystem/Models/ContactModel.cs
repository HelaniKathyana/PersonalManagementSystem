using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonalManagementSystem.Connection;

namespace PersonalManagementSystem.Models
{
    public class ContactModel
    {
        public DataTable displayAllContactData(int id)
        {
            string contactSQL = "SELECT Name, Email, Mobile_Number, Designation, Address FROM Contact WHERE User_ID = '" + id + "'";
            DataTable contactData = ServerConnection.executeSQL(contactSQL);
            return contactData;
        }

        public DataTable addContactData(int id)
        {
            string contactSQL = "SELECT Name, Email, Mobile_Number, Designation, Address FROM Contact WHERE User_ID = '" + id + "'";
            DataTable contactData = ServerConnection.executeSQL(contactSQL);
            return contactData;
        }
    }
}
