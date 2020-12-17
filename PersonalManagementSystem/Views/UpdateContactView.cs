using PersonalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalManagementSystem.Views
{
    public partial class UpdateContactView : Form
    {
        private int id;
        static ContactModel cm = new ContactModel();

        public void setId(int id)
        {
            this.id = id;
        }
        public UpdateContactView()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdateContact_Click(object sender, EventArgs e)
        {
            /* cm.updateContactData(textName.Text);

            MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            this.Hide();
        }

        private void DisplayContactDetails()
        {
            ContactModel cm = new ContactModel();
            DataTable contactData = cm.displayContactDataById(id);


            foreach (DataRow row in contactData.Rows)
            {
                string idn = row["Contact_ID"].ToString();
                id = int.Parse(idn);
            }

            if (contactData.Rows.Count > 0)
            {


            }
        }
    }
}
