using PersonalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalManagementSystem.Views
{
    public partial class UpdateContactView : Form
    {
        public int id;
        static ContactModel cm = new ContactModel();

        public void setId(int id)
        {
            this.id = id;
            displayContactDetails(id);
        }

        public int getId()
        {
            return this.id;
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
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";

            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Please enter the Full name", caption, btn, ico);
                textName.Select();
                return;
            }

            Regex rEmail = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (textEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(textEmail.Text))
                {
                    MessageBox.Show("Invalid Email Address", caption, btn, MessageBoxIcon.Error);
                    textEmail.Select();
                    return;
                }
            }

            Regex rMobile = new Regex("^[0-9]{10}");
            bool isValid = rMobile.IsMatch(textMobileNumber.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter valid Mobile number", caption, btn, ico);
                textMobileNumber.Select();
                return;
            }

            if (string.IsNullOrEmpty(textDesignation.Text))
            {
                MessageBox.Show("Please enter Designation", caption, btn, ico);
                textDesignation.Select();
                return;
            }

            if (string.IsNullOrEmpty(textAddress.Text))
            {
                MessageBox.Show("Please enter Address", caption, btn, ico);
                textAddress.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to update the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cm.updateContactData(textName.Text, textEmail.Text, textMobileNumber.Text, textDesignation.Text, textAddress.Text, this.id);

                MessageBox.Show("The record has been updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
        }

        private void displayContactDetails(int id)
        {
            ContactModel cm = new ContactModel();
            DataTable contactData = cm.displayContactDataById(id);

            foreach (DataRow row in contactData.Rows)
            {
                textName.Text = row["Name"].ToString();
                textEmail.Text = row["Email"].ToString();
                textMobileNumber.Text = row["Mobile_Number"].ToString();
                textDesignation.Text = row["Designation"].ToString();
                textAddress.Text = row["Address"].ToString();
            }
        }
    }
}
