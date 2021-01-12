using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace PersonalManagementSystem
{
    public partial class MainView : Form
    {
        private int user_id;
        static String incomeId;
        static String expenseId;
        static String contId;
        DateTime startDate;
        DateTime endDate;
        DateTime dateStart = DateTime.Today;
        DateTime dateEnd = DateTime.Today.AddDays(-28);

        public void setId(int id)
        {
            user_id = id;
            displayIncomeYearList(id);
            displayExpenseYearList(id);
        }

        static IncomeModel im = new IncomeModel();
        static ExpenseModel em = new ExpenseModel();
        static ContactModel cm = new ContactModel();
        static ReportModel rm = new ReportModel();

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
            loadTotalExpense();
            loadTotalContact();
            loadIncomeExpenseChart();
            loadIncomeCategoryOverviewChart();
            loadExpenseCategoryOverviewChart();
            loadReportData();
        }

        //sign up
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            LoginView login = new LoginView();
            login.Show();
            this.Hide();
        }

        private void loadIncomeExpenseChart()
        {
            DataTable incomeData = im.getTotalIncomes(user_id);
            DataTable expenseData = em.getTotalExpenses(user_id);

            cartesianChartIncomeExpense.Series = new SeriesCollection();
            ColumnSeries colSeriesIncomeObj = new ColumnSeries
            {
                Title = "Income",
                Values = new ChartValues<double> { }     
            };

            foreach (DataRow dr in incomeData.Rows)
            {
                colSeriesIncomeObj.Values.Add(double.Parse(dr["Total"].ToString()));
            }

            ColumnSeries colSeriesExpenseObj = new ColumnSeries
            {
                Title = "Expense",
                Values = new ChartValues<double> {}
            };

            foreach (DataRow dr in expenseData.Rows)
            {
                colSeriesExpenseObj.Values.Add(double.Parse(dr["Total"].ToString()));
            }

            //adding series will update and animate the chart automatically
            cartesianChartIncomeExpense.Series.Add(colSeriesIncomeObj);
            cartesianChartIncomeExpense.Series.Add(colSeriesExpenseObj);

            cartesianChartIncomeExpense.AxisX.Add(
             new Axis
            {
                Title = "Years",
                Labels = new[] { "2019", "2020", "2021" }
            });

            cartesianChartIncomeExpense.AxisY.Add(new Axis
            {
                Title = "Total",
                LabelFormatter = value => value.ToString("N")
            });
        }


        private void loadIncomeCategoryOverviewChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable incomeData = im.getIncomeCategoryOverview(user_id);

            pieChartIncomeCategory.Series = new SeriesCollection();
            foreach (DataRow dr in incomeData.Rows)
            {
                PieSeries pieSeriesObj = new PieSeries
                {
                    Title = dr["Category"].ToString(),
                    Values = new ChartValues<double> { double.Parse(dr["Total"].ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                pieChartIncomeCategory.Series.Add(pieSeriesObj);
            }

            pieChartIncomeCategory.LegendLocation = LegendLocation.Bottom;
        }
    
        private void loadExpenseCategoryOverviewChart()
        {
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataTable expenseData = em.getExpenseCategoryOverview(user_id);

            pieChartExpenseCategory.Series = new SeriesCollection();
            foreach (DataRow dr in expenseData.Rows)
            {
                PieSeries pieSeriesObj = new PieSeries
                {
                    Title = dr["Category"].ToString(),
                    Values = new ChartValues<double> { double.Parse(dr["Total"].ToString()) },
                    DataLabels = true,
                    LabelPoint = labelPoint
                };
                pieChartExpenseCategory.Series.Add(pieSeriesObj);
            }

            pieChartExpenseCategory.LegendLocation = LegendLocation.Bottom;
        }

        //Income View

        //search method for Income
        private void textSearchIncomeName_TextChanged(object sender, EventArgs e)
        {
            DataTable incomeData = im.searchIncomeData(textSearchIncome.Text, user_id);
            dataGridViewIncome.DataSource = incomeData;
        }

        private void displayIncomeYearList(int id)
        {
            DataTable incomeData = im.displayYearList(id);
            comboBoxIncome.DataSource = incomeData;
            comboBoxIncome.DisplayMember = "Year";
            comboBoxIncome.ValueMember = "Year";
        }

        private void comboBoxIncome_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedYear = comboBoxIncome.SelectedValue.ToString();
            DataTable incomeData = im.displayIncomeDataByYear(selectedYear, user_id);
            dataGridViewIncome.DataSource = incomeData;
        }

        // load all the income details by given user id
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
            labelIncome.Text = sum.ToString();
        }

        //add method for income
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

        //delete method for income
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

        //update method for income
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

        //set income id
        private void dataGridViewIncome_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            incomeId = dataGridViewIncome.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //Expense View

        //search method for Expense 
        private void textSearchExpenseName_TextChanged(object sender, EventArgs e)
        {
            DataTable expenseData = em.searchExpenseData(textSearchExpense.Text, user_id);
            dataGridViewExpense.DataSource = expenseData;
        }

        private void displayExpenseYearList(int id)
        {
            DataTable expenseData = em.displayYearList(id);
            comboBoxExpense.DataSource = expenseData;
            comboBoxExpense.DisplayMember = "Year";
            comboBoxExpense.ValueMember = "Year";
        }

        private void comboBoxExpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedYear = comboBoxExpense.SelectedValue.ToString();
            DataTable expenseData = em.displayExpenseDataByYear(selectedYear, user_id);
            dataGridViewExpense.DataSource = expenseData;
        }

        // load all the expense details by given user id
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

        private void loadTotalExpense()
        {
            int sum = 0;
            for (int i = 0; i < dataGridViewExpense.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridViewExpense.Rows[i].Cells[6].Value);
            }
            expenseTotal.Text = "Total Expense : " + sum.ToString();
            labelExpense.Text = sum.ToString();
        }

        //add method for expense
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
                loadTotalExpense();
            }
        }

        //delete method for expense
        private void buttonDeleteExpense_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    em.deleteExpenseData(dataGridViewExpense.CurrentRow.Cells[0].Value);
                    loadExpenseData();
                    loadTotalExpense();
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

        //update method for expense
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
                loadTotalExpense();
            }
        }

        //set expense id
        private void dataGridViewExpense_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            expenseId = dataGridViewExpense.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        // Contact View

        //search method for contact 
        private void textSearchContactName_TextChanged(object sender, EventArgs e)
        {
            DataTable contactData = cm.searchContactData(textSearchContact.Text, user_id);
            dataGridViewContact.DataSource = contactData;
        }

        // load all the contact details by given user id
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

        private void loadTotalContact()
        {
            labelContact.Text = dataGridViewContact.Rows.Count.ToString();
        }

        //add method for contact
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
                loadTotalContact();
            }
        }

        //delete method for contact
        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    cm.deleteContactData(dataGridViewContact.CurrentRow.Cells[0].Value);
                    loadContactData();
                    loadTotalContact();
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

        //update method for contact
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
                loadTotalContact();
            }
        }

        //set contact id
        private void dataGridViewContact_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            contId = dataGridViewContact.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        //Report View

        //load all the report details for given id
        private void loadReportData()
        {
            DataTable reportData = rm.displayAllReportData(user_id);

            dataGridViewRepot.DataSource = reportData;
            dataGridViewRepot.Columns[0].HeaderText = "Name";
            dataGridViewRepot.Columns[1].HeaderText = "Type";
            dataGridViewRepot.Columns[2].HeaderText = "Start Date";
            dataGridViewRepot.Columns[3].HeaderText = "End Date";
            dataGridViewRepot.Columns[4].HeaderText = "Created";
        }

        //create method for report
        private void buttonCreateReport_Click(object sender, EventArgs e)
        {
            Form reportOverlay = new Form();
            try
            {
                using (CreateReportView createReport = new CreateReportView())
                {
                    createReport.setId(user_id);
                    reportOverlay.StartPosition = FormStartPosition.Manual;
                    reportOverlay.FormBorderStyle = FormBorderStyle.None;
                    reportOverlay.Opacity = .50d;
                    reportOverlay.BackColor = Color.Black;
                    reportOverlay.WindowState = FormWindowState.Maximized;
                    reportOverlay.TopMost = true;
                    reportOverlay.Location = this.Location;
                    reportOverlay.ShowInTaskbar = false;
                    reportOverlay.Show();

                    createReport.Owner = reportOverlay;
                    createReport.ShowDialog();

                    reportOverlay.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reportOverlay.Dispose();
                loadReportData();
            }
        }

        //delete method for report
        private void buttonDeleteReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to permanently delete the selected record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                {
                    rm.deleteReportData(dataGridViewRepot.CurrentRow.Cells[0].Value);
                    loadReportData();
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

        private void dataGridViewReport_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            startDate = (DateTime)dataGridViewRepot.Rows[e.RowIndex].Cells[2].Value;
            endDate = (DateTime)dataGridViewRepot.Rows[e.RowIndex].Cells[3].Value;
            loadIncomeSummary(this.user_id, startDate, endDate);
            loadExpenseSummary(this.user_id, startDate, endDate);
            MakeDataTable(this.user_id, startDate, endDate, "");
        }

        private void loadIncomeSummary(int user_id, DateTime startDate, DateTime endDate)
        {
            DataTable reportData = rm.getIncomeSummary(user_id, startDate, endDate);
            
            dataGridViewSummaryIncome.DataSource = reportData;
            dataGridViewSummaryIncome.Columns[0].HeaderText = "Category";
            dataGridViewSummaryIncome.Columns[1].HeaderText = "Total Amount";           
        }

        private void loadExpenseSummary(int user_id, DateTime startDate, DateTime endDate)
        {
            DataTable reportData = rm.getExpenseSummary(user_id, startDate, endDate);

            dataGridViewSummaryExpense.DataSource = reportData;
            dataGridViewSummaryExpense.Columns[0].HeaderText = "Category";
            dataGridViewSummaryExpense.Columns[1].HeaderText = "Total Amount";
        }

        //pdf implementation
        void ExportDataTableToPdf(DataTable dtblIncomeTable, DataTable dtblExpenseTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Add line break
            document.Add(new Chunk("\n"));

            //Report Sub Header
            Paragraph prgIncomeSubHeader = new Paragraph();
            BaseFont btnIncomeSubHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            var subIncomeHeaderFontColour = new BaseColor(128, 128, 128);
            iTextSharp.text.Font fntIncome = new iTextSharp.text.Font(btnIncomeSubHeader, 12, 1, subIncomeHeaderFontColour);
            prgIncomeSubHeader.Alignment = Element.ALIGN_LEFT;
            prgIncomeSubHeader.Add(new Chunk("Income Summary", fntIncome));
            document.Add(prgIncomeSubHeader);

            //Write the table
            PdfPTable incomeTable = new PdfPTable(dtblIncomeTable.Columns.Count);
            //Table header
            BaseFont btnIncomeColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            var columnIncomeHeaderFontColour = new BaseColor(255, 255, 255);
            iTextSharp.text.Font fntIncomeColumnHeader = new iTextSharp.text.Font(btnIncomeColumnHeader, 10, 1, columnIncomeHeaderFontColour);
            for (int i = 0; i < dtblIncomeTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                var backgroundFontColour = new BaseColor(128, 128, 128);
                cell.BackgroundColor = backgroundFontColour;
                cell.AddElement(new Chunk(dtblIncomeTable.Columns[i].ColumnName.ToUpper(), fntIncomeColumnHeader));
                incomeTable.AddCell(cell);
            }

            //table Data
            for (int i = 0; i < dtblIncomeTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblIncomeTable.Columns.Count; j++)
                {
                    incomeTable.AddCell(dtblIncomeTable.Rows[i][j].ToString());
                }
            }

            //Add line break
            document.Add(new Chunk("\n"));
            document.Add(incomeTable);
            document.Add(new Chunk("\n"));

            //Report Sub Header
            Paragraph prgExpenseSubHeader = new Paragraph();
            BaseFont btnExpenseSubHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            var subExpenseHeaderFontColour = new BaseColor(128, 128, 128);
            iTextSharp.text.Font fntExpense = new iTextSharp.text.Font(btnExpenseSubHeader, 12, 1, subExpenseHeaderFontColour);
            prgExpenseSubHeader.Alignment = Element.ALIGN_LEFT;
            prgExpenseSubHeader.Add(new Chunk("Expense Summary", fntExpense));
            document.Add(prgExpenseSubHeader);

            document.Add(new Chunk("\n"));

            //Write the table
            PdfPTable expenseTable = new PdfPTable(dtblExpenseTable.Columns.Count);
            //Table header
            BaseFont btnExpenseColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            var columnHeaderFontColour = new BaseColor(255, 255, 255);
            iTextSharp.text.Font fntExpenseColumnHeader = new iTextSharp.text.Font(btnExpenseColumnHeader, 10, 1, columnHeaderFontColour);
            for (int i = 0; i < dtblExpenseTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                var backgroundFontColour = new BaseColor(128, 128, 128);
                cell.BackgroundColor = backgroundFontColour;
                cell.AddElement(new Chunk(dtblExpenseTable.Columns[i].ColumnName.ToUpper(), fntExpenseColumnHeader));
                expenseTable.AddCell(cell);
            }

            //table Data
            for (int i = 0; i < dtblExpenseTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblExpenseTable.Columns.Count; j++)
                {
                    expenseTable.AddCell(dtblExpenseTable.Rows[i][j].ToString());
                }
            }
 
            document.Add(expenseTable);
            document.Close();
            writer.Close();
            fs.Close();
        }

        //data for pdf reports
        DataTable MakeDataTable(int user_id, DateTime startDate, DateTime endDate, string name)
        {
            //Create income table object
            if (name.Equals("income"))
            {
                DataTable reportData = rm.getIncomeSummary(user_id, startDate, endDate);
                return reportData;
            }
            else
            {
                DataTable reportData = rm.getExpenseSummary(user_id, startDate, endDate);
                return reportData;
            }
        }

        //generate pdf for incomes and expenses
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = MakeDataTable(user_id, startDate, endDate, "income");
                DataTable dtb2 = MakeDataTable(user_id, startDate, endDate, "expense");
                ExportDataTableToPdf(dtbl, dtb2, @"D:\Report.pdf", "Income and Expense Summary Report");
                System.Diagnostics.Process.Start(@"D:\Report.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        //Prediction
        private int averageExpenditure()
        {
            int expense = 0;
            DataTable expenseData = em.getTotalExpensesForDateRange(user_id, dateEnd, dateStart);

            foreach (DataRow row in expenseData.Rows)
            {
                Console.WriteLine(row["Total"].ToString());
                String expensed = row["Total"].ToString();
                expense = int.Parse(expensed);            
            }
            int average = expense / 28;
            return average;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            int averageExpenses = averageExpenditure();
            endDate = dateTimePickerEnd.Value;
            String  data = (endDate - dateStart).TotalDays.ToString();
            float date = float.Parse(data);
            float predictExpense = averageExpenses * date;
            textBoxPredictedTotalExpense.Text = predictExpense.ToString();
        }
    }
}