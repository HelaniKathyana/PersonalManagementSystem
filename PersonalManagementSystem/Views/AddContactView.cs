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

        MainView mv = new MainView();

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
            result = MessageBox.Show("Do you want to save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                cm.addContactData(textName.Text, textEmail.Text, textMobileNumber.Text, textDesignation.Text, textAddress.Text, id);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFeilds();
                this.Hide();
            }

        }
    }
}