﻿using PersonalManagementSystem.Models;
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
    public partial class AddIncomeView : Form
    {
        static IncomeModel im = new IncomeModel();
        private int id;

        public void setId(int id)
        {
            this.id = id;
            displayPaymentFromList(id);
        }

        public int getId()
        {
            return id;
        }

        public AddIncomeView()
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

        private void displayPaymentFromList(int id)
        {
            DataTable incomeData = im.displayPaymentFromList(id);
            comboBoxPaymentFrom.DataSource = incomeData;
            comboBoxPaymentFrom.DisplayMember = "Payment_From";
            comboBoxPaymentFrom.ValueMember = "Contact_ID";
        }

        private void buttonAddIncome_Click(object sender, EventArgs e)
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
                int contactId = (int) comboBoxPaymentFrom.SelectedValue;
               
                im.addIncomeData(textDescription.Text, textCategory.Text, textAccount.Text, dateTimePicker.Value, float.Parse(textAmount.Text), contactId, id);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFeilds();
                this.Close();
            }
        }

    }
}
