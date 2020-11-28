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

namespace PersonalManagementSystem
{
    public partial class RegisterView : Form
    {
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
            DataTable userData = ServerConnection.executeSQL("SELECT Full_Name FROM Login");
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

            string emailSQL = "SELECT Email FROM Login WHERE Email = '" + txtEmail.Text + "'";
            DataTable checkDuplicates = PersonalManagementSystem.Connection.ServerConnection.executeSQL(emailSQL);

            if(checkDuplicates.Rows.Count > 0)
            {
                MessageBox.Show("The Email already exists. Please try another email.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.SelectAll();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to  save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                string registerSQL = string.Empty;

                registerSQL += "INSERT INTO Login (Full_Name, Email, Password)";
                registerSQL += "VALUES ('" + txtFullName.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')";

                PersonalManagementSystem.Connection.ServerConnection.executeSQL(registerSQL);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadUserData();
                txtFullName.Clear();
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

            }

        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.ShowDialog();
            this.Hide();
        }

        /*        private void labelRegister_Click(object sender, EventArgs e)
                {
                    new LoginView().Show();
                    this.Hide();
                }

                private void buttonRegister_Click(object sender, EventArgs e)
                {
                    if (txtName.Text == "Helani" && txtEmail.Text == "helani@gmail.com" && txtPassword.Text == "123" && txtConfirmPassword.Text == "123")
                    {
                        new LoginView().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Try again!!");
                        txtName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtName.Focus();
                    }
                }*/
    }
}
