using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalManagementSystem.Connection;
using PersonalManagementSystem.Models;

namespace PersonalManagementSystem
{
    public partial class RegisterView : Form
    {
        static RegisterModel rm = new RegisterModel();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            loadUserData();
        }

        private void loadUserData()
        {
            DataTable userData = ServerConnection.executeSQL("SELECT Full_Name FROM [User]");
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";

            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Please enter Full Name.", caption, btn, ico);
                txtFullName.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Please enter Email.", caption, btn, ico);
                txtEmail.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter Username.", caption, btn, ico);
                txtUsername.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter Password.", caption, btn, ico);
                txtPassword.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Please enter Confirm Password.", caption, btn, ico);
                txtConfirmPassword.Select();
                return;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Your Password and Confirm Password do not match.", caption, btn, ico);
                txtConfirmPassword.SelectAll();
                return;
            }

            DataTable checkDuplicates = rm.executeIsDuplicate(txtUsername.Text);

            if(checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The Username already exists. Please try another username.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to  save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                rm.executeRegisterSql(txtFullName.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadUserData();
                txtFullName.Clear();
                txtEmail.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }
    }
}
