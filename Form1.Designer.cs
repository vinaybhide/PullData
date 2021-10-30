
namespace PullData
{
    partial class Form1
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
            this.buttonGetDataForFromDate = new System.Windows.Forms.Button();
            this.comboBoxFundHouse = new System.Windows.Forms.ComboBox();
            this.comboBoxSchemeName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeFromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimeToDate = new System.Windows.Forms.DateTimePicker();
            this.buttonDateRange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoadFundHouse = new System.Windows.Forms.Button();
            this.dataGridViewNAVData = new System.Windows.Forms.DataGridView();
            this.buttonShowNAVData = new System.Windows.Forms.Button();
            this.buttonFetchAllForRange = new System.Windows.Forms.Button();
            this.buttonDownloadLatest = new System.Windows.Forms.Button();
            this.buttonOpenPortfolio = new System.Windows.Forms.Button();
            this.buttonUpdateFromLastFetch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNAVData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetDataForFromDate
            // 
            this.buttonGetDataForFromDate.Location = new System.Drawing.Point(13, 244);
            this.buttonGetDataForFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetDataForFromDate.Name = "buttonGetDataForFromDate";
            this.buttonGetDataForFromDate.Size = new System.Drawing.Size(231, 28);
            this.buttonGetDataForFromDate.TabIndex = 0;
            this.buttonGetDataForFromDate.Text = "Get data for ALL For From Date";
            this.buttonGetDataForFromDate.UseVisualStyleBackColor = true;
            this.buttonGetDataForFromDate.Click += new System.EventHandler(this.buttonGetDataForFromClicked);
            // 
            // comboBoxFundHouse
            // 
            this.comboBoxFundHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFundHouse.FormattingEnabled = true;
            this.comboBoxFundHouse.Location = new System.Drawing.Point(193, 32);
            this.comboBoxFundHouse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFundHouse.Name = "comboBoxFundHouse";
            this.comboBoxFundHouse.Size = new System.Drawing.Size(227, 24);
            this.comboBoxFundHouse.TabIndex = 1;
            this.comboBoxFundHouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxFundHouse_SelectedIndexChanged);
            // 
            // comboBoxSchemeName
            // 
            this.comboBoxSchemeName.FormattingEnabled = true;
            this.comboBoxSchemeName.Location = new System.Drawing.Point(193, 82);
            this.comboBoxSchemeName.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSchemeName.Name = "comboBoxSchemeName";
            this.comboBoxSchemeName.Size = new System.Drawing.Size(514, 24);
            this.comboBoxSchemeName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scheme Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fund House:";
            // 
            // dateTimeFromDate
            // 
            this.dateTimeFromDate.Location = new System.Drawing.Point(193, 145);
            this.dateTimeFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFromDate.Name = "dateTimeFromDate";
            this.dateTimeFromDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimeFromDate.TabIndex = 6;
            // 
            // dateTimeToDate
            // 
            this.dateTimeToDate.Location = new System.Drawing.Point(193, 192);
            this.dateTimeToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeToDate.Name = "dateTimeToDate";
            this.dateTimeToDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimeToDate.TabIndex = 7;
            // 
            // buttonDateRange
            // 
            this.buttonDateRange.Location = new System.Drawing.Point(252, 244);
            this.buttonDateRange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDateRange.Name = "buttonDateRange";
            this.buttonDateRange.Size = new System.Drawing.Size(223, 28);
            this.buttonDateRange.TabIndex = 8;
            this.buttonDateRange.Text = "Get Data - MF Code From & To dates";
            this.buttonDateRange.UseVisualStyleBackColor = true;
            this.buttonDateRange.Click += new System.EventHandler(this.buttonDateRange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "From Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "To Date:";
            // 
            // buttonLoadFundHouse
            // 
            this.buttonLoadFundHouse.Location = new System.Drawing.Point(460, 32);
            this.buttonLoadFundHouse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadFundHouse.Name = "buttonLoadFundHouse";
            this.buttonLoadFundHouse.Size = new System.Drawing.Size(151, 28);
            this.buttonLoadFundHouse.TabIndex = 11;
            this.buttonLoadFundHouse.Text = "Load Fund House";
            this.buttonLoadFundHouse.UseVisualStyleBackColor = true;
            this.buttonLoadFundHouse.Click += new System.EventHandler(this.buttonLoadFundHouse_Click);
            // 
            // dataGridViewNAVData
            // 
            this.dataGridViewNAVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNAVData.Location = new System.Drawing.Point(32, 306);
            this.dataGridViewNAVData.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewNAVData.Name = "dataGridViewNAVData";
            this.dataGridViewNAVData.RowHeadersWidth = 51;
            this.dataGridViewNAVData.Size = new System.Drawing.Size(1671, 185);
            this.dataGridViewNAVData.TabIndex = 12;
            // 
            // buttonShowNAVData
            // 
            this.buttonShowNAVData.Location = new System.Drawing.Point(140, 516);
            this.buttonShowNAVData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowNAVData.Name = "buttonShowNAVData";
            this.buttonShowNAVData.Size = new System.Drawing.Size(271, 28);
            this.buttonShowNAVData.TabIndex = 13;
            this.buttonShowNAVData.Text = "Show NAV Data for selected scheme";
            this.buttonShowNAVData.UseVisualStyleBackColor = true;
            this.buttonShowNAVData.Click += new System.EventHandler(this.buttonShowNAVData_Click);
            // 
            // buttonFetchAllForRange
            // 
            this.buttonFetchAllForRange.Location = new System.Drawing.Point(482, 244);
            this.buttonFetchAllForRange.Name = "buttonFetchAllForRange";
            this.buttonFetchAllForRange.Size = new System.Drawing.Size(253, 28);
            this.buttonFetchAllForRange.TabIndex = 14;
            this.buttonFetchAllForRange.Text = "Download ALL MF Data - From & To";
            this.buttonFetchAllForRange.UseVisualStyleBackColor = true;
            this.buttonFetchAllForRange.Click += new System.EventHandler(this.buttonFetchAllForRange_Click);
            // 
            // buttonDownloadLatest
            // 
            this.buttonDownloadLatest.Location = new System.Drawing.Point(741, 248);
            this.buttonDownloadLatest.Name = "buttonDownloadLatest";
            this.buttonDownloadLatest.Size = new System.Drawing.Size(230, 23);
            this.buttonDownloadLatest.TabIndex = 15;
            this.buttonDownloadLatest.Text = "Download Yesterday ALL MF";
            this.buttonDownloadLatest.UseVisualStyleBackColor = true;
            this.buttonDownloadLatest.Click += new System.EventHandler(this.buttonDownloadLatest_Click);
            // 
            // buttonOpenPortfolio
            // 
            this.buttonOpenPortfolio.Location = new System.Drawing.Point(1199, 247);
            this.buttonOpenPortfolio.Name = "buttonOpenPortfolio";
            this.buttonOpenPortfolio.Size = new System.Drawing.Size(128, 23);
            this.buttonOpenPortfolio.TabIndex = 16;
            this.buttonOpenPortfolio.Text = "Open Portfolio";
            this.buttonOpenPortfolio.UseVisualStyleBackColor = true;
            this.buttonOpenPortfolio.Click += new System.EventHandler(this.buttonOpenPortfolio_Click);
            // 
            // buttonUpdateFromLastFetch
            // 
            this.buttonUpdateFromLastFetch.Location = new System.Drawing.Point(977, 249);
            this.buttonUpdateFromLastFetch.Name = "buttonUpdateFromLastFetch";
            this.buttonUpdateFromLastFetch.Size = new System.Drawing.Size(216, 23);
            this.buttonUpdateFromLastFetch.TabIndex = 17;
            this.buttonUpdateFromLastFetch.Text = "Update from Last Fetch Date";
            this.buttonUpdateFromLastFetch.UseVisualStyleBackColor = true;
            this.buttonUpdateFromLastFetch.Click += new System.EventHandler(this.buttonUpdateFromLastFetch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 679);
            this.Controls.Add(this.buttonUpdateFromLastFetch);
            this.Controls.Add(this.buttonOpenPortfolio);
            this.Controls.Add(this.buttonDownloadLatest);
            this.Controls.Add(this.buttonFetchAllForRange);
            this.Controls.Add(this.buttonShowNAVData);
            this.Controls.Add(this.dataGridViewNAVData);
            this.Controls.Add(this.buttonLoadFundHouse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDateRange);
            this.Controls.Add(this.dateTimeToDate);
            this.Controls.Add(this.dateTimeFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSchemeName);
            this.Controls.Add(this.comboBoxFundHouse);
            this.Controls.Add(this.buttonGetDataForFromDate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNAVData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetDataForFromDate;
        private System.Windows.Forms.ComboBox comboBoxFundHouse;
        private System.Windows.Forms.ComboBox comboBoxSchemeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeFromDate;
        private System.Windows.Forms.DateTimePicker dateTimeToDate;
        private System.Windows.Forms.Button buttonDateRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoadFundHouse;
        private System.Windows.Forms.DataGridView dataGridViewNAVData;
        private System.Windows.Forms.Button buttonShowNAVData;
        private System.Windows.Forms.Button buttonFetchAllForRange;
        private System.Windows.Forms.Button buttonDownloadLatest;
        private System.Windows.Forms.Button buttonOpenPortfolio;
        private System.Windows.Forms.Button buttonUpdateFromLastFetch;
    }
}

