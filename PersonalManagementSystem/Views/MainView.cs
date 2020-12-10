using PersonalManagementSystem.Models;
using PersonalManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalManagementSystem
{
    public partial class MainView : Form
    {
        private int user_id;
        public void setId(int id)
        {
            user_id = id;
        }
        static ContactModel cm = new ContactModel();
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            loadContactData();
        }

        // Contact View
        private void SearchContactText_Enter(object sender, EventArgs e)
        {
            if (textSearchContact.Text == " Search Contacts")
            {
                textSearchContact.Text = "";

                textSearchContact.ForeColor = Color.Black;
            }
        }

        private void SearchContactText_Leave(object sender, EventArgs e)
        {
            if (textSearchContact.Text == "")
            {
                textSearchContact.Text = " Search Contacts";

                textSearchContact.ForeColor = Color.Silver;
            }
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Form contactOverlay = new Form();
            try
            {
                using (AddContactView addContact = new AddContactView())
                {
                    contactOverlay.StartPosition = FormStartPosition.Manual;
                    contactOverlay.FormBorderStyle = FormBorderStyle.None;
                    contactOverlay.Opacity = .50d;
                    contactOverlay.BackColor = Color.Black;
                    contactOverlay.WindowState = FormWindowState.Maximized;
                    contactOverlay.TopMost = true;
                    contactOverlay.Location = this.Location;
                    contactOverlay.ShowInTaskbar = false;
                    contactOverlay.Show();

                    addContact.Owner = contactOverlay;
                    addContact.ShowDialog();

                    contactOverlay.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                contactOverlay.Dispose();
            }
        }

        private void loadContactData()
        {
            DataTable contactData = cm.displayAllContactData(user_id);

            dataGridViewContact.DataSource = contactData;
            dataGridViewContact.Columns[0].HeaderText = "Name";
            dataGridViewContact.Columns[1].HeaderText = "Email";
            dataGridViewContact.Columns[2].HeaderText = "Mobile Number";
            dataGridViewContact.Columns[3].HeaderText = "Designation";
            dataGridViewContact.Columns[4].HeaderText = "Address";
        }

    }
}
