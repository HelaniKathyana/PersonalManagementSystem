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
    public partial class CreateReportView : Form
    {

        static ReportModel rm = new ReportModel();
        private int id;

        public void setId(int id)
        {
            this.id = id;
        }

        public CreateReportView()
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

        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btn = MessageBoxButtons.OK;
            MessageBoxIcon ico = MessageBoxIcon.Information;
            string caption = "";

            if (string.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("Please enter Report Name", caption, btn, ico);
                textName.Select();
                return;
            }

            DateTime today = DateTime.Today.Date;
            if (endDatePicker.Value < today)
            {
                MessageBox.Show("You are not allowed to select older day than today!", caption, btn, ico);
                endDatePicker.Select();
                return;
            }

            DialogResult result;
            result = MessageBox.Show("Do you want to save the record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime createdDate = DateTime.Today.Date;
                rm.addReportData(textName.Text, comboBoxType.Text, startDatePicker.Value, endDatePicker.Value, createdDate, id);

                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFeilds();
                this.Close();
            }
        }
    }
}
