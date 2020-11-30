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
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
     
        }

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
            AddContactView addContact = new AddContactView();
            addContact.ShowDialog();

        }
    }
}
