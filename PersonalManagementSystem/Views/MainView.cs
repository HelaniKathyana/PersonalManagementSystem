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
        static String incomeId;
        static String expenseId;
        static String contId;

        public void setId(int id)
        {
            user_id = id;
        }

        static IncomeModel im = new IncomeModel();
        static ExpenseModel em = new ExpenseModel();
        static ContactModel cm = new ContactModel();
        
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {   
            loadIncomeData();
            loadExpenseData();
            loadContactData();
            loadTotalIncome();
        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }

        //Income View
        private void textSearchIncomeName_TextChanged(object sender, EventArgs e)
        {
            DataTable incomeData = im.searchIncomeData(textSearchIncome.Text);
            dataGridViewIncome.DataSource = incomeData;
        }

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

        private void loadTotalIncome()
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewIncome.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewIncome.Rows[i].Cells[6].Value);
            }
            incomeTotal.Text = "Total Income : " + sum.ToString();
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
                loadTotalIncome();
            }
        }

        private void buttonDeleteIncome_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    im.deleteIncomeData(dataGridViewIncome.CurrentRow.Cells[0].Value);
                    loadIncomeData();
                    loadTotalIncome();
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

        private void buttonEditIncome_Click(object sender, EventArgs e)
        {
            Form contactOverlay = new Form();
            try
            {
                using (UpdateIncomeView updateContact = new UpdateIncomeView())
                {
                    updateContact.setId(int.Parse(incomeId));
                    updateContact.setEnteredId(user_id);
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
                loadIncomeData();
                loadTotalIncome();
            }
        }

        private void dataGridViewIncome_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            incomeId = dataGridViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //Expense View
        private void loadExpenseData()
        {
            DataTable expenseData = em.displayAllExpenseData(user_id);

            dataGridViewExpense.DataSource = expenseData;
            dataGridViewExpense.Columns[0].HeaderText = "Id";
            dataGridViewExpense.Columns[1].HeaderText = "Payment To";
            dataGridViewExpense.Columns[2].HeaderText = "Description";
            dataGridViewExpense.Columns[3].HeaderText = "Category";
            dataGridViewExpense.Columns[4].HeaderText = "Account";
            dataGridViewExpense.Columns[5].HeaderText = "Transaction Date";
            dataGridViewExpense.Columns[6].HeaderText = "Amount";
        }

        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            Form expenseOverlay = new Form();
            try
            {
                using (AddExpenseView addExpense = new AddExpenseView())
                {
                    addExpense.setId(user_id);
                    expenseOverlay.StartPosition = FormStartPosition.Manual;
                    expenseOverlay.FormBorderStyle = FormBorderStyle.None;
                    expenseOverlay.Opacity = .50d;
                    expenseOverlay.BackColor = Color.Black;
                    expenseOverlay.WindowState = FormWindowState.Maximized;
                    expenseOverlay.TopMost = true;
                    expenseOverlay.Location = this.Location;
                    expenseOverlay.ShowInTaskbar = false;
                    expenseOverlay.Show();

                    addExpense.Owner = expenseOverlay;
                    addExpense.ShowDialog();

                    expenseOverlay.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                expenseOverlay.Dispose();
                loadExpenseData();
            
            }
        }

        private void buttonDeleteExpense_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    em.deleteExpenseData(dataGridViewExpense.CurrentRow.Cells[0].Value);
                    loadExpenseData();
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

        private void buttonEditExpense_Click(object sender, EventArgs e)
        {
            Form expenseOverlay = new Form();
            try
            {
                using (UpdateExpenseView updateExpense = new UpdateExpenseView())
                {
                    updateExpense.setId(int.Parse(expenseId));
                    updateExpense.setEnteredId(user_id);
                    expenseOverlay.StartPosition = FormStartPosition.Manual;
                    expenseOverlay.FormBorderStyle = FormBorderStyle.None;
                    expenseOverlay.Opacity = .50d;
                    expenseOverlay.BackColor = Color.Black;
                    expenseOverlay.WindowState = FormWindowState.Maximized;
                    expenseOverlay.TopMost = true;
                    expenseOverlay.Location = this.Location;
                    expenseOverlay.ShowInTaskbar = false;
                    expenseOverlay.Show();

                    updateExpense.Owner = expenseOverlay;
                    updateExpense.ShowDialog();

                    expenseOverlay.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                expenseOverlay.Dispose();
                loadExpenseData();
            }
        }

        private void dataGridViewExpense_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            expenseId = dataGridViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        // Contact View
        private void textSearchContactName_TextChanged(object sender, EventArgs e)
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
