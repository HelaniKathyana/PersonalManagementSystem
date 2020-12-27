
namespace PersonalManagementSystem.Views
{
    partial class CreateReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReportView));
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelCreateReport = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.PictureBox();
            this.labelReportType = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.bunifuSeparator.LineThickness = 1;
            this.bunifuSeparator.Location = new System.Drawing.Point(28, 55);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(569, 16);
            this.bunifuSeparator.TabIndex = 6;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // labelCreateReport
            // 
            this.labelCreateReport.AutoSize = true;
            this.labelCreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.labelCreateReport.ForeColor = System.Drawing.Color.DimGray;
            this.labelCreateReport.Location = new System.Drawing.Point(23, 27);
            this.labelCreateReport.Name = "labelCreateReport";
            this.labelCreateReport.Size = new System.Drawing.Size(131, 25);
            this.labelCreateReport.TabIndex = 5;
            this.labelCreateReport.Text = "Create Report";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Image = global::PersonalManagementSystem.Properties.Resources.close;
            this.buttonClose.Location = new System.Drawing.Point(570, 14);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonClose.TabIndex = 4;
            this.buttonClose.TabStop = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelReportType
            // 
            this.labelReportType.AutoSize = true;
            this.labelReportType.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReportType.Location = new System.Drawing.Point(306, 74);
            this.labelReportType.Name = "labelReportType";
            this.labelReportType.Size = new System.Drawing.Size(99, 20);
            this.labelReportType.TabIndex = 18;
            this.labelReportType.Text = "Report Type :";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(20, 142);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(85, 20);
            this.labelStartDate.TabIndex = 17;
            this.labelStartDate.Text = "Start Date :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(20, 74);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 20);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Report Name :";
            // 
            // textName
            // 
            this.textName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textName.ForeColor = System.Drawing.Color.Black;
            this.textName.Location = new System.Drawing.Point(21, 102);
            this.textName.Multiline = true;
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(271, 30);
            this.textName.TabIndex = 15;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DisplayMember = "Pdf";
            this.comboBoxType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Pdf",
            "Csv",
            "Docx"});
            this.comboBoxType.Location = new System.Drawing.Point(310, 103);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(271, 29);
            this.comboBoxType.TabIndex = 19;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDatePicker.Location = new System.Drawing.Point(21, 171);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(271, 29);
            this.startDatePicker.TabIndex = 20;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(306, 142);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(79, 20);
            this.labelEndDate.TabIndex = 21;
            this.labelEndDate.Text = "End Date :";
            // 
            // endDatePicker
            // 
            this.endDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDatePicker.Location = new System.Drawing.Point(310, 171);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(271, 29);
            this.endDatePicker.TabIndex = 22;
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateReport.BackColor = System.Drawing.Color.White;
            this.buttonCreateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonCreateReport.FlatAppearance.BorderSize = 3;
            this.buttonCreateReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonCreateReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.buttonCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateReport.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonCreateReport.ForeColor = System.Drawing.Color.Black;
            this.buttonCreateReport.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateReport.Image")));
            this.buttonCreateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreateReport.Location = new System.Drawing.Point(389, 234);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonCreateReport.Size = new System.Drawing.Size(192, 36);
            this.buttonCreateReport.TabIndex = 23;
            this.buttonCreateReport.Text = "Generate Report";
            this.buttonCreateReport.UseVisualStyleBackColor = false;
            this.buttonCreateReport.Click += new System.EventHandler(this.buttonCreateReport_Click);
            // 
            // CreateReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(610, 310);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelReportType);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.bunifuSeparator);
            this.Controls.Add(this.labelCreateReport);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.Label labelCreateReport;
        private System.Windows.Forms.PictureBox buttonClose;
        private System.Windows.Forms.Label labelReportType;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button buttonCreateReport;
    }
}