﻿
namespace PersonalManagementSystem.Views
{
    partial class AddExpenseView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpenseView));
            this.labelAmount = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPaymentTo = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAccount = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPayementTo = new System.Windows.Forms.Label();
            this.textAmount = new System.Windows.Forms.TextBox();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.textAccount = new System.Windows.Forms.TextBox();
            this.textCategory = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelAddExpense = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(18, 360);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(72, 20);
            this.labelAmount.TabIndex = 47;
            this.labelAmount.Text = "Amount :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(19, 322);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(395, 27);
            this.dateTimePicker.TabIndex = 46;
            // 
            // comboBoxPaymentTo
            // 
            this.comboBoxPaymentTo.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxPaymentTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentTo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentTo.ForeColor = System.Drawing.Color.Black;
            this.comboBoxPaymentTo.FormattingEnabled = true;
            this.comboBoxPaymentTo.ItemHeight = 20;
            this.comboBoxPaymentTo.Location = new System.Drawing.Point(19, 115);
            this.comboBoxPaymentTo.Name = "comboBoxPaymentTo";
            this.comboBoxPaymentTo.Size = new System.Drawing.Size(395, 28);
            this.comboBoxPaymentTo.TabIndex = 45;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(18, 291);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(131, 20);
            this.labelDate.TabIndex = 44;
            this.labelDate.Text = "Transaction Date :";
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.Location = new System.Drawing.Point(219, 219);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(73, 20);
            this.labelAccount.TabIndex = 43;
            this.labelAccount.Text = "Account :";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(18, 219);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(80, 20);
            this.labelCategory.TabIndex = 42;
            this.labelCategory.Text = "Category :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(18, 151);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(159, 20);
            this.labelDescription.TabIndex = 41;
            this.labelDescription.Text = "Payment Description :";
            // 
            // labelPayementTo
            // 
            this.labelPayementTo.AutoSize = true;
            this.labelPayementTo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayementTo.Location = new System.Drawing.Point(18, 87);
            this.labelPayementTo.Name = "labelPayementTo";
            this.labelPayementTo.Size = new System.Drawing.Size(97, 20);
            this.labelPayementTo.TabIndex = 40;
            this.labelPayementTo.Text = "Payment To :";
            // 
            // textAmount
            // 
            this.textAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAmount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textAmount.ForeColor = System.Drawing.Color.Black;
            this.textAmount.Location = new System.Drawing.Point(19, 391);
            this.textAmount.Multiline = true;
            this.textAmount.Name = "textAmount";
            this.textAmount.Size = new System.Drawing.Size(395, 30);
            this.textAmount.TabIndex = 39;
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddExpense.BackColor = System.Drawing.Color.White;
            this.buttonAddExpense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonAddExpense.FlatAppearance.BorderSize = 3;
            this.buttonAddExpense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAddExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAddExpense.ForeColor = System.Drawing.Color.Black;
            this.buttonAddExpense.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddExpense.Image")));
            this.buttonAddExpense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddExpense.Location = new System.Drawing.Point(260, 446);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonAddExpense.Size = new System.Drawing.Size(154, 36);
            this.buttonAddExpense.TabIndex = 38;
            this.buttonAddExpense.Text = "Add Expense";
            this.buttonAddExpense.UseVisualStyleBackColor = false;
            this.buttonAddExpense.Click += new System.EventHandler(this.buttonAddExpense_Click);
            // 
            // textAccount
            // 
            this.textAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textAccount.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textAccount.ForeColor = System.Drawing.Color.Black;
            this.textAccount.Location = new System.Drawing.Point(223, 247);
            this.textAccount.Multiline = true;
            this.textAccount.Name = "textAccount";
            this.textAccount.Size = new System.Drawing.Size(191, 30);
            this.textAccount.TabIndex = 37;
            // 
            // textCategory
            // 
            this.textCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCategory.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textCategory.ForeColor = System.Drawing.Color.Black;
            this.textCategory.Location = new System.Drawing.Point(19, 247);
            this.textCategory.Multiline = true;
            this.textCategory.Name = "textCategory";
            this.textCategory.Size = new System.Drawing.Size(191, 30);
            this.textCategory.TabIndex = 36;
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textDescription.ForeColor = System.Drawing.Color.Black;
            this.textDescription.Location = new System.Drawing.Point(19, 179);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(395, 30);
            this.textDescription.TabIndex = 35;
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator.LineThickness = 1;
            this.bunifuSeparator.Location = new System.Drawing.Point(20, 63);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(395, 16);
            this.bunifuSeparator.TabIndex = 34;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // labelAddExpense
            // 
            this.labelAddExpense.AutoSize = true;
            this.labelAddExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelAddExpense.ForeColor = System.Drawing.Color.DimGray;
            this.labelAddExpense.Location = new System.Drawing.Point(21, 35);
            this.labelAddExpense.Name = "labelAddExpense";
            this.labelAddExpense.Size = new System.Drawing.Size(122, 25);
            this.labelAddExpense.TabIndex = 33;
            this.labelAddExpense.Text = "Add Expense";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Image = global::PersonalManagementSystem.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(394, 22);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 32;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AddExpenseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(436, 518);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxPaymentTo);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPayementTo);
            this.Controls.Add(this.textAmount);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.textAccount);
            this.Controls.Add(this.textCategory);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.bunifuSeparator);
            this.Controls.Add(this.labelAddExpense);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExpenseView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxPaymentTo;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPayementTo;
        private System.Windows.Forms.TextBox textAmount;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.TextBox textAccount;
        private System.Windows.Forms.TextBox textCategory;
        private System.Windows.Forms.TextBox textDescription;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.Label labelAddExpense;
        private System.Windows.Forms.PictureBox buttonClose;
    }
}