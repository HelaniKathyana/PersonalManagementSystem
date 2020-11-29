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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUserEmail.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtUserEmail.Text) &&
               !string.IsNullOrEmpty(txtPassword.Text))
            {
                string loginSQL = string.Empty;

                loginSQL += "SELECT * FROM Login ";
                loginSQL += "WHERE Email = '" + txtUserEmail.Text + "' ";
                loginSQL += "AND Password = '" + txtPassword.Text + "'";

                DataTable userData = ServerConnection.executeSQL(loginSQL);

                if(userData.Rows.Count > 0)
                {
                    txtUserEmail.Clear();
                    txtPassword.Clear();
                    checkBoxShowPwd.Checked = false;

                    MainView main = new MainView();
                    main.Show();
                    this.Hide();
                    main = null;

                    this.txtUserEmail.Select();
                }
                else
                {
                    MessageBox.Show("The username or password is incorrect. Try again.", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUserEmail.Focus();
                    txtUserEmail.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserEmail.Select();
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
    }
}
