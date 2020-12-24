using PersonalManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalManagementSystem.Views
{
    public partial class AddExpenseView : Form
    {
        static ExpenseModel em = new ExpenseModel();
        private int id;

        public void setId(int id)
        {
            this.id = id;
            displayPaymentToList(id);
        }
        public AddExpenseView()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearFeilds()
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Text = string.Empty;
            }
        }

        private void displayPaymentToList(int id)
        {
            DataTable expenseData = em.displayPaymentToList(id);
            comboBoxPaymentTo.DataSource = expenseData;
            comboBoxPaymentTo.DisplayMember = "Payment_To";
            comboBoxPaymentTo.ValueMember = "Contact_ID";
        }

        private void buttonAddExpense_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";

            if (string.IsNullOrEmpty(textDescription.Text))
            {
                MessageBox.Show("Please enter Payment Description", caption, btn, ico);
                textDescription.Select();
                return;
            }

            if (string.IsNullOrEmpty(textCategory.Text))
            {
                MessageBox.Show("Please enter Category", caption, btn, ico);
                textCategory.Select();
                return;
            }

            if (string.IsNullOrEmpty(textAccount.Text))
            {
                MessageBox.Show("Please enter Account", caption, btn, ico);
                textAccount.Select();
                return;
            }

            if (String.IsNullOrEmpty(textAmount.Text) || System.Text.RegularExpressions.Regex.IsMatch(textAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter Amount", caption, btn, ico);
                textAmount.Text = null;
                textAmount.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int contactId = (int)comboBoxPaymentTo.SelectedValue;

                em.addExpenseData(textDescription.Text, textCategory.Text, textAccount.Text, dateTimePicker.Value, float.Parse(textAmount.Text), contactId, id);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFeilds();
                this.Close();
            }
        }
    }
}
