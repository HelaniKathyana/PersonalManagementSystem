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
        static String contId;
      
        public void setId(int id)
        {
            user_id = id;
        }
        static ContactModel cm = new ContactModel();
        static IncomeModel im = new IncomeModel();
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            loadContactData();
            loadIncomeData();
        }

        //Income View
        private void loadIncomeData()
        {
            DataTable incomeData = im.displayAllIncomeData(user_id);

            dataGridViewIncome.DataSource = incomeData;
            dataGridViewIncome.Columns[0].HeaderText = "Id";
            dataGridViewIncome.Columns[1].HeaderText = "Payment From";
            dataGridViewIncome.Columns[2].HeaderText = "Description";
            dataGridViewIncome.Columns[3].HeaderText = "Category";
            dataGridViewIncome.Columns[4].HeaderText = "Account";
            dataGridViewIncome.Columns[5].HeaderText = "Transaction Date";
            dataGridViewIncome.Columns[6].HeaderText = "Amount";
        }

        private void buttonAddIncome_Click(object sender, EventArgs e)
        {
            Form incomeOverlay = new Form();
            try
            {
                using (AddIncomeView addIncome = new AddIncomeView())
                {
                    addIncome.setId(user_id);
                    incomeOverlay.StartPosition = FormStartPosition.Manual;
                    incomeOverlay.FormBorderStyle = FormBorderStyle.None;
                    incomeOverlay.Opacity = .50d;
                    incomeOverlay.BackColor = Color.Black;
                    incomeOverlay.WindowState = FormWindowState.Maximized;
                    incomeOverlay.TopMost = true;
                    incomeOverlay.Location = this.Location;
                    incomeOverlay.ShowInTaskbar = false;
                    incomeOverlay.Show();

                    addIncome.Owner = incomeOverlay;
                    addIncome.ShowDialog();

                    incomeOverlay.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                incomeOverlay.Dispose();
                loadIncomeData();
            }
        }

        // Contact View
        private void textSearchName_TextChanged(object sender, EventArgs e)
        {
            DataTable contactData = cm.searchContactData(textSearchContact.Text);
            dataGridViewContact.DataSource = contactData;
        }

        private void loadContactData()
        {
            DataTable contactData = cm.displayAllContactData(user_id);

            dataGridViewContact.DataSource = contactData;
            dataGridViewContact.Columns[0].HeaderText = "Id";
            dataGridViewContact.Columns[1].HeaderText = "Name";
            dataGridViewContact.Columns[2].HeaderText = "Email";
            dataGridViewContact.Columns[3].HeaderText = "Mobile Number";
            dataGridViewContact.Columns[4].HeaderText = "Designation";
            dataGridViewContact.Columns[5].HeaderText = "Address";
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            Form contactOverlay = new Form();
            try
            {
                using (AddContactView addContact = new AddContactView())
                {
                    addContact.setId(user_id);
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
                loadContactData();
            }
        }

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    cm.deleteContactData(dataGridViewContact.CurrentRow.Cells[0].Value);
                    loadContactData();
                    MessageBox.Show("The selected record has been deletecd.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                // and error occured
            }
        }

        private void buttonEditContacts_Click(object sender, EventArgs e)
        {
            Form contactOverlay = new Form();
            try
            {
                using (UpdateContactView updateContact = new UpdateContactView())
                {
                    updateContact.setId(int.Parse(contId));
                    contactOverlay.StartPosition = FormStartPosition.Manual;
                    contactOverlay.FormBorderStyle = FormBorderStyle.None;
                    contactOverlay.Opacity = .50d;
                    contactOverlay.BackColor = Color.Black;
                    contactOverlay.WindowState = FormWindowState.Maximized;
                    contactOverlay.TopMost = true;
                    contactOverlay.Location = this.Location;
                    contactOverlay.ShowInTaskbar = false;
                    contactOverlay.Show();

                    updateContact.Owner = contactOverlay;
                    updateContact.ShowDialog();

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
                loadContactData();
            }
        }

        private void dataGridViewContact_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contId = dataGridViewContact.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

    }
}
