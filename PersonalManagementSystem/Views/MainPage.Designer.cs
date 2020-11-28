
namespace PersonalManagementSystem.Views
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.mainViewTabControl = new System.Windows.Forms.TabControl();
            this.dashboardTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelTotalBalance = new System.Windows.Forms.Label();
            this.pictureBoxBalance = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelProfit = new System.Windows.Forms.Label();
            this.labelTotalProfit = new System.Windows.Forms.Label();
            this.pictureBoxProfit = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelExpense = new System.Windows.Forms.Label();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.pictureBoxExpense = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelIncome = new System.Windows.Forms.Label();
            this.pictureBoxIncome = new System.Windows.Forms.PictureBox();
            this.inomeTabPage = new System.Windows.Forms.TabPage();
            this.expensesTabPage = new System.Windows.Forms.TabPage();
            this.contactsTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.predictionTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.mainViewTabControl.SuspendLayout();
            this.dashboardTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 19.75F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(54, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(91, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Fedha";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(907, 55);
            this.panelTitleBar.TabIndex = 2;
            // 
            // mainViewTabControl
            // 
            this.mainViewTabControl.Controls.Add(this.dashboardTabPage);
            this.mainViewTabControl.Controls.Add(this.inomeTabPage);
            this.mainViewTabControl.Controls.Add(this.expensesTabPage);
            this.mainViewTabControl.Controls.Add(this.contactsTabPage);
            this.mainViewTabControl.Controls.Add(this.reportsTabPage);
            this.mainViewTabControl.Controls.Add(this.predictionTabPage);
            this.mainViewTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainViewTabControl.Location = new System.Drawing.Point(0, 55);
            this.mainViewTabControl.Name = "mainViewTabControl";
            this.mainViewTabControl.Padding = new System.Drawing.Point(24, 12);
            this.mainViewTabControl.SelectedIndex = 0;
            this.mainViewTabControl.Size = new System.Drawing.Size(907, 395);
            this.mainViewTabControl.TabIndex = 3;
            // 
            // dashboardTabPage
            // 
            this.dashboardTabPage.Controls.Add(this.label4);
            this.dashboardTabPage.Controls.Add(this.label5);
            this.dashboardTabPage.Controls.Add(this.label3);
            this.dashboardTabPage.Controls.Add(this.pictureBox4);
            this.dashboardTabPage.Controls.Add(this.label2);
            this.dashboardTabPage.Controls.Add(this.pictureBox3);
            this.dashboardTabPage.Controls.Add(this.label1);
            this.dashboardTabPage.Controls.Add(this.pictureBox2);
            this.dashboardTabPage.Controls.Add(this.panel1);
            this.dashboardTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardTabPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboardTabPage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dashboardTabPage.Location = new System.Drawing.Point(4, 44);
            this.dashboardTabPage.Name = "dashboardTabPage";
            this.dashboardTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardTabPage.Size = new System.Drawing.Size(899, 347);
            this.dashboardTabPage.TabIndex = 0;
            this.dashboardTabPage.Text = "Dashboard";
            this.dashboardTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelTotalIncome);
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.labelTotalBalance);
            this.panel1.Controls.Add(this.pictureBoxBalance);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.labelProfit);
            this.panel1.Controls.Add(this.labelTotalProfit);
            this.panel1.Controls.Add(this.pictureBoxProfit);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.labelExpense);
            this.panel1.Controls.Add(this.labelTotalExpense);
            this.panel1.Controls.Add(this.pictureBoxExpense);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.labelIncome);
            this.panel1.Controls.Add(this.pictureBoxIncome);
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 84);
            this.panel1.TabIndex = 17;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalIncome.ForeColor = System.Drawing.Color.Gray;
            this.labelTotalIncome.Location = new System.Drawing.Point(90, 19);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(104, 21);
            this.labelTotalIncome.TabIndex = 2;
            this.labelTotalIncome.Text = "Total Income";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelBalance.ForeColor = System.Drawing.Color.DimGray;
            this.labelBalance.Location = new System.Drawing.Point(763, 41);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(48, 28);
            this.labelBalance.TabIndex = 15;
            this.labelBalance.Text = "000";
            // 
            // labelTotalBalance
            // 
            this.labelTotalBalance.AutoSize = true;
            this.labelTotalBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalBalance.ForeColor = System.Drawing.Color.Gray;
            this.labelTotalBalance.Location = new System.Drawing.Point(763, 19);
            this.labelTotalBalance.Name = "labelTotalBalance";
            this.labelTotalBalance.Size = new System.Drawing.Size(66, 21);
            this.labelTotalBalance.TabIndex = 13;
            this.labelTotalBalance.Text = "Balance";
            // 
            // pictureBoxBalance
            // 
            this.pictureBoxBalance.Image = global::PersonalManagementSystem.Properties.Resources.Balance;
            this.pictureBoxBalance.Location = new System.Drawing.Point(702, 19);
            this.pictureBoxBalance.Name = "pictureBoxBalance";
            this.pictureBoxBalance.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxBalance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBalance.TabIndex = 14;
            this.pictureBoxBalance.TabStop = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(658, 17);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(11, 53);
            this.bunifuSeparator2.TabIndex = 12;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // labelProfit
            // 
            this.labelProfit.AutoSize = true;
            this.labelProfit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelProfit.ForeColor = System.Drawing.Color.DimGray;
            this.labelProfit.Location = new System.Drawing.Point(562, 41);
            this.labelProfit.Name = "labelProfit";
            this.labelProfit.Size = new System.Drawing.Size(48, 28);
            this.labelProfit.TabIndex = 11;
            this.labelProfit.Text = "000";
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.AutoSize = true;
            this.labelTotalProfit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalProfit.ForeColor = System.Drawing.Color.Gray;
            this.labelTotalProfit.Location = new System.Drawing.Point(562, 19);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(51, 21);
            this.labelTotalProfit.TabIndex = 9;
            this.labelTotalProfit.Text = "Profit";
            // 
            // pictureBoxProfit
            // 
            this.pictureBoxProfit.Image = global::PersonalManagementSystem.Properties.Resources.profit;
            this.pictureBoxProfit.Location = new System.Drawing.Point(502, 19);
            this.pictureBoxProfit.Name = "pictureBoxProfit";
            this.pictureBoxProfit.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProfit.TabIndex = 10;
            this.pictureBoxProfit.TabStop = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(450, 17);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(11, 53);
            this.bunifuSeparator3.TabIndex = 8;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // labelExpense
            // 
            this.labelExpense.AutoSize = true;
            this.labelExpense.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelExpense.ForeColor = System.Drawing.Color.DimGray;
            this.labelExpense.Location = new System.Drawing.Point(299, 41);
            this.labelExpense.Name = "labelExpense";
            this.labelExpense.Size = new System.Drawing.Size(48, 28);
            this.labelExpense.TabIndex = 7;
            this.labelExpense.Text = "000";
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalExpense.ForeColor = System.Drawing.Color.Gray;
            this.labelTotalExpense.Location = new System.Drawing.Point(299, 19);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(137, 21);
            this.labelTotalExpense.TabIndex = 5;
            this.labelTotalExpense.Text = "Total Expenditure";
            // 
            // pictureBoxExpense
            // 
            this.pictureBoxExpense.Image = global::PersonalManagementSystem.Properties.Resources.TotalExpense;
            this.pictureBoxExpense.Location = new System.Drawing.Point(243, 19);
            this.pictureBoxExpense.Name = "pictureBoxExpense";
            this.pictureBoxExpense.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxExpense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpense.TabIndex = 6;
            this.pictureBoxExpense.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(210, 17);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(11, 53);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelIncome.ForeColor = System.Drawing.Color.DimGray;
            this.labelIncome.Location = new System.Drawing.Point(90, 41);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(48, 28);
            this.labelIncome.TabIndex = 3;
            this.labelIncome.Text = "000";
            // 
            // pictureBoxIncome
            // 
            this.pictureBoxIncome.Image = global::PersonalManagementSystem.Properties.Resources.TotalIncome;
            this.pictureBoxIncome.Location = new System.Drawing.Point(34, 19);
            this.pictureBoxIncome.Name = "pictureBoxIncome";
            this.pictureBoxIncome.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxIncome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIncome.TabIndex = 2;
            this.pictureBoxIncome.TabStop = false;
            // 
            // inomeTabPage
            // 
            this.inomeTabPage.Location = new System.Drawing.Point(4, 44);
            this.inomeTabPage.Name = "inomeTabPage";
            this.inomeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.inomeTabPage.Size = new System.Drawing.Size(899, 347);
            this.inomeTabPage.TabIndex = 1;
            this.inomeTabPage.Text = "Income";
            this.inomeTabPage.UseVisualStyleBackColor = true;
            // 
            // expensesTabPage
            // 
            this.expensesTabPage.Location = new System.Drawing.Point(4, 44);
            this.expensesTabPage.Name = "expensesTabPage";
            this.expensesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.expensesTabPage.Size = new System.Drawing.Size(899, 347);
            this.expensesTabPage.TabIndex = 2;
            this.expensesTabPage.Text = "Expenses";
            this.expensesTabPage.UseVisualStyleBackColor = true;
            // 
            // contactsTabPage
            // 
            this.contactsTabPage.Location = new System.Drawing.Point(4, 44);
            this.contactsTabPage.Name = "contactsTabPage";
            this.contactsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.contactsTabPage.Size = new System.Drawing.Size(899, 347);
            this.contactsTabPage.TabIndex = 3;
            this.contactsTabPage.Text = "Contacts";
            this.contactsTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Location = new System.Drawing.Point(4, 44);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(899, 347);
            this.reportsTabPage.TabIndex = 4;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // predictionTabPage
            // 
            this.predictionTabPage.Location = new System.Drawing.Point(4, 44);
            this.predictionTabPage.Name = "predictionTabPage";
            this.predictionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.predictionTabPage.Size = new System.Drawing.Size(899, 347);
            this.predictionTabPage.TabIndex = 5;
            this.predictionTabPage.Text = "Prediction";
            this.predictionTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(225, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Balance";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(201, 163);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 18);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(124, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Expenses";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Magenta;
            this.pictureBox3.Location = new System.Drawing.Point(100, 163);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 18);
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(35, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Income";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.pictureBox2.Location = new System.Drawing.Point(11, 163);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 18);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(75, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Income Category Overview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(587, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Expense Category Overview";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 450);
            this.Controls.Add(this.mainViewTabControl);
            this.Controls.Add(this.panelTitleBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.mainViewTabControl.ResumeLayout(false);
            this.dashboardTabPage.ResumeLayout(false);
            this.dashboardTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.TabControl mainViewTabControl;
        private System.Windows.Forms.TabPage dashboardTabPage;
        private System.Windows.Forms.TabPage inomeTabPage;
        private System.Windows.Forms.TabPage expensesTabPage;
        private System.Windows.Forms.TabPage contactsTabPage;
        private System.Windows.Forms.TabPage reportsTabPage;
        private System.Windows.Forms.TabPage predictionTabPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelTotalBalance;
        private System.Windows.Forms.PictureBox pictureBoxBalance;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label labelProfit;
        private System.Windows.Forms.Label labelTotalProfit;
        private System.Windows.Forms.PictureBox pictureBoxProfit;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label labelExpense;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.PictureBox pictureBoxExpense;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.PictureBox pictureBoxIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}