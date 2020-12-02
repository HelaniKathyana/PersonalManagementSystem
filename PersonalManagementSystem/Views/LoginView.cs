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
    public partial class LoginView : Form
    {
        static LoginModel lm = new LoginModel();
        public LoginView()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
    //        txtUsername.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUsername.Text) &&
               !string.IsNullOrEmpty(txtPassword.Text))
            {

                DataTable userData = lm.executeLoginSql(txtUsername.Text, txtPassword.Text);

                if (userData.Rows.Count > 0)
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    checkBoxShowPwd.Checked = false;

                    MessageBox.Show("Successfully Log In.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MainView main = new MainView();
                    main.Show();
                    this.Hide();
                    main = null;

                    this.txtUsername.Select();
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect. Try again.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsername.Focus();
                    txtUsername.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Select();
            }
        }

        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxShowPwd.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView();
            register.Show();
            this.Hide();
        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";

                txtUsername.ForeColor = Color.Black;
            }
        }

        private void UsernameText_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";

                txtUsername.ForeColor = Color.Silver;
            }
        }

        private void PasswordText_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";

                txtPassword.UseSystemPasswordChar = true;
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void PasswordText_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";

                txtPassword.UseSystemPasswordChar = false;
                txtPassword.ForeColor = Color.Silver;
            }
        }
    }
}
