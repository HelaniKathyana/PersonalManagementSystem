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
    public partial class AddContactView : Form
    {
        static ContactModel cm = new ContactModel();
        private int id;

        public void setId(int id)
        {
            this.id = id;
        }
        public AddContactView()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddContactView_Load(object sender, EventArgs e)
        {
            
        }

        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textName.Text))
            {
                validation.ForeColor = Color.Red;
                validation.Text = "Please enter Full Name.";
                textName.Select();
                return;
            }

            if (string.IsNullOrEmpty(textEmail.Text))
            {
                validation.ForeColor = Color.Red;
                validation.Text = "Please enter Email.";
                textEmail.Select();
                return;
            }

            if (string.IsNullOrEmpty(textMobileNumber.Text))
            {
                validation.ForeColor = Color.Red;
                validation.Text = "Please enter Mobile number.";
                textMobileNumber.Select();
                return;
            }

            if (string.IsNullOrEmpty(textDesignation.Text))
            {
                validation.ForeColor = Color.Red;
                validation.Text = "Please enter Designation.";
                textDesignation.Select();
                return;
            }

            if (string.IsNullOrEmpty(textAddress.Text))
            {
                validation.ForeColor = Color.Red;
                validation.Text = "Please enter Address.";
                textAddress.Select();
                return;
            }


            DialogResult result;
            result = MessageBox.Show("Do you want to  save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cm.addContactData(textName.Text, textEmail.Text, textMobileNumber.Text, textDesignation.Text, textAddress.Text, id);

                validation.ForeColor = Color.Green;
                validation.Text = "The record has been saved successfully.";

                clearFeilds();
                this.Hide();
            }

        }
    }
}