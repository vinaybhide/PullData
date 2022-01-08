
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
            this.dataGridViewStockData = new System.Windows.Forms.DataGridView();
            this.buttonShowNAVData = new System.Windows.Forms.Button();
            this.buttonFetchAllForRange = new System.Windows.Forms.Button();
            this.buttonDownloadLatest = new System.Windows.Forms.Button();
            this.buttonOpenPortfolio = new System.Windows.Forms.Button();
            this.buttonUpdateFromLastFetch = new System.Windows.Forms.Button();
            this.panelMF = new System.Windows.Forms.Panel();
            this.buttonFetchStockMaster = new System.Windows.Forms.Button();
            this.comboBoxExchangeCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxOutputSize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxInterval = new System.Windows.Forms.ComboBox();
            this.buttonGetStockData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBoxSymbol = new System.Windows.Forms.CheckedListBox();
            this.buttonGetSymbols = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockData)).BeginInit();
            this.panelMF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetDataForFromDate
            // 
            this.buttonGetDataForFromDate.Location = new System.Drawing.Point(409, 103);
            this.buttonGetDataForFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetDataForFromDate.Name = "buttonGetDataForFromDate";
            this.buttonGetDataForFromDate.Size = new System.Drawing.Size(231, 30);
            this.buttonGetDataForFromDate.TabIndex = 0;
            this.buttonGetDataForFromDate.Text = "Get data for ALL For From Date";
            this.buttonGetDataForFromDate.UseVisualStyleBackColor = true;
            this.buttonGetDataForFromDate.Click += new System.EventHandler(this.buttonGetDataForFromClicked);
            // 
            // comboBoxFundHouse
            // 
            this.comboBoxFundHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFundHouse.FormattingEnabled = true;
            this.comboBoxFundHouse.Location = new System.Drawing.Point(126, 22);
            this.comboBoxFundHouse.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxFundHouse.Name = "comboBoxFundHouse";
            this.comboBoxFundHouse.Size = new System.Drawing.Size(227, 24);
            this.comboBoxFundHouse.TabIndex = 1;
            this.comboBoxFundHouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxFundHouse_SelectedIndexChanged);
            // 
            // comboBoxSchemeName
            // 
            this.comboBoxSchemeName.FormattingEnabled = true;
            this.comboBoxSchemeName.Location = new System.Drawing.Point(126, 72);
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
            this.dateTimeFromDate.Location = new System.Drawing.Point(126, 116);
            this.dateTimeFromDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeFromDate.Name = "dateTimeFromDate";
            this.dateTimeFromDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimeFromDate.TabIndex = 6;
            // 
            // dateTimeToDate
            // 
            this.dateTimeToDate.Location = new System.Drawing.Point(126, 167);
            this.dateTimeToDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeToDate.Name = "dateTimeToDate";
            this.dateTimeToDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimeToDate.TabIndex = 7;
            // 
            // buttonDateRange
            // 
            this.buttonDateRange.Location = new System.Drawing.Point(409, 141);
            this.buttonDateRange.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDateRange.Name = "buttonDateRange";
            this.buttonDateRange.Size = new System.Drawing.Size(223, 30);
            this.buttonDateRange.TabIndex = 8;
            this.buttonDateRange.Text = "Get Data - MF Code From & To dates";
            this.buttonDateRange.UseVisualStyleBackColor = true;
            this.buttonDateRange.Click += new System.EventHandler(this.buttonDateRange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "From Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 172);
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
            this.buttonLoadFundHouse.Size = new System.Drawing.Size(151, 30);
            this.buttonLoadFundHouse.TabIndex = 11;
            this.buttonLoadFundHouse.Text = "Load Fund House";
            this.buttonLoadFundHouse.UseVisualStyleBackColor = true;
            this.buttonLoadFundHouse.Click += new System.EventHandler(this.buttonLoadFundHouse_Click);
            // 
            // dataGridViewStockData
            // 
            this.dataGridViewStockData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStockData.Location = new System.Drawing.Point(32, 306);
            this.dataGridViewStockData.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewStockData.Name = "dataGridViewStockData";
            this.dataGridViewStockData.RowHeadersWidth = 51;
            this.dataGridViewStockData.Size = new System.Drawing.Size(644, 187);
            this.dataGridViewStockData.TabIndex = 12;
            // 
            // buttonShowNAVData
            // 
            this.buttonShowNAVData.Location = new System.Drawing.Point(171, 254);
            this.buttonShowNAVData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowNAVData.Name = "buttonShowNAVData";
            this.buttonShowNAVData.Size = new System.Drawing.Size(271, 30);
            this.buttonShowNAVData.TabIndex = 13;
            this.buttonShowNAVData.Text = "Show NAV Data for selected scheme";
            this.buttonShowNAVData.UseVisualStyleBackColor = true;
            this.buttonShowNAVData.Click += new System.EventHandler(this.buttonShowNAVData_Click);
            // 
            // buttonFetchAllForRange
            // 
            this.buttonFetchAllForRange.Location = new System.Drawing.Point(409, 178);
            this.buttonFetchAllForRange.Name = "buttonFetchAllForRange";
            this.buttonFetchAllForRange.Size = new System.Drawing.Size(253, 30);
            this.buttonFetchAllForRange.TabIndex = 14;
            this.buttonFetchAllForRange.Text = "Download ALL MF Data - From & To";
            this.buttonFetchAllForRange.UseVisualStyleBackColor = true;
            this.buttonFetchAllForRange.Click += new System.EventHandler(this.buttonFetchAllForRange_Click);
            // 
            // buttonDownloadLatest
            // 
            this.buttonDownloadLatest.Location = new System.Drawing.Point(17, 219);
            this.buttonDownloadLatest.Name = "buttonDownloadLatest";
            this.buttonDownloadLatest.Size = new System.Drawing.Size(230, 25);
            this.buttonDownloadLatest.TabIndex = 15;
            this.buttonDownloadLatest.Text = "Download Yesterday ALL MF";
            this.buttonDownloadLatest.UseVisualStyleBackColor = true;
            this.buttonDownloadLatest.Click += new System.EventHandler(this.buttonDownloadLatest_Click);
            // 
            // buttonOpenPortfolio
            // 
            this.buttonOpenPortfolio.Location = new System.Drawing.Point(475, 219);
            this.buttonOpenPortfolio.Name = "buttonOpenPortfolio";
            this.buttonOpenPortfolio.Size = new System.Drawing.Size(128, 25);
            this.buttonOpenPortfolio.TabIndex = 16;
            this.buttonOpenPortfolio.Text = "Open Portfolio";
            this.buttonOpenPortfolio.UseVisualStyleBackColor = true;
            this.buttonOpenPortfolio.Click += new System.EventHandler(this.buttonOpenPortfolio_Click);
            // 
            // buttonUpdateFromLastFetch
            // 
            this.buttonUpdateFromLastFetch.Location = new System.Drawing.Point(253, 219);
            this.buttonUpdateFromLastFetch.Name = "buttonUpdateFromLastFetch";
            this.buttonUpdateFromLastFetch.Size = new System.Drawing.Size(216, 25);
            this.buttonUpdateFromLastFetch.TabIndex = 17;
            this.buttonUpdateFromLastFetch.Text = "Update from Last Fetch Date";
            this.buttonUpdateFromLastFetch.UseVisualStyleBackColor = true;
            this.buttonUpdateFromLastFetch.Click += new System.EventHandler(this.buttonUpdateFromLastFetch_Click);
            // 
            // panelMF
            // 
            this.panelMF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMF.Controls.Add(this.buttonShowNAVData);
            this.panelMF.Controls.Add(this.buttonOpenPortfolio);
            this.panelMF.Controls.Add(this.buttonUpdateFromLastFetch);
            this.panelMF.Controls.Add(this.buttonGetDataForFromDate);
            this.panelMF.Controls.Add(this.buttonDateRange);
            this.panelMF.Controls.Add(this.buttonDownloadLatest);
            this.panelMF.Controls.Add(this.buttonFetchAllForRange);
            this.panelMF.Controls.Add(this.dateTimeToDate);
            this.panelMF.Controls.Add(this.comboBoxFundHouse);
            this.panelMF.Controls.Add(this.comboBoxSchemeName);
            this.panelMF.Controls.Add(this.label4);
            this.panelMF.Controls.Add(this.dateTimeFromDate);
            this.panelMF.Controls.Add(this.label3);
            this.panelMF.Location = new System.Drawing.Point(13, 13);
            this.panelMF.Name = "panelMF";
            this.panelMF.Size = new System.Drawing.Size(692, 552);
            this.panelMF.TabIndex = 18;
            // 
            // buttonFetchStockMaster
            // 
            this.buttonFetchStockMaster.Location = new System.Drawing.Point(970, 54);
            this.buttonFetchStockMaster.Name = "buttonFetchStockMaster";
            this.buttonFetchStockMaster.Size = new System.Drawing.Size(267, 27);
            this.buttonFetchStockMaster.TabIndex = 19;
            this.buttonFetchStockMaster.Text = "Fetch Stock Master from Web && Insert";
            this.buttonFetchStockMaster.UseVisualStyleBackColor = true;
            this.buttonFetchStockMaster.Click += new System.EventHandler(this.buttonFetchStockMaster_Click);
            // 
            // comboBoxExchangeCode
            // 
            this.comboBoxExchangeCode.FormattingEnabled = true;
            this.comboBoxExchangeCode.Items.AddRange(new object[] {
            "NSE",
            "BSE"});
            this.comboBoxExchangeCode.Location = new System.Drawing.Point(829, 56);
            this.comboBoxExchangeCode.Name = "comboBoxExchangeCode";
            this.comboBoxExchangeCode.Size = new System.Drawing.Size(121, 24);
            this.comboBoxExchangeCode.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Exchange: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(734, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Output size:";
            // 
            // comboBoxOutputSize
            // 
            this.comboBoxOutputSize.FormattingEnabled = true;
            this.comboBoxOutputSize.Items.AddRange(new object[] {
            "Compact",
            "Full"});
            this.comboBoxOutputSize.Location = new System.Drawing.Point(825, 222);
            this.comboBoxOutputSize.Name = "comboBoxOutputSize";
            this.comboBoxOutputSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOutputSize.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(976, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Interval: ";
            // 
            // comboBoxInterval
            // 
            this.comboBoxInterval.FormattingEnabled = true;
            this.comboBoxInterval.Items.AddRange(new object[] {
            "1m",
            "5m",
            "15m",
            "30m",
            "60m",
            "1d",
            "5d",
            "1mo",
            "3mo",
            "6mo",
            "1y",
            "2y",
            "5y",
            "10y",
            "ytd",
            "max"});
            this.comboBoxInterval.Location = new System.Drawing.Point(1045, 222);
            this.comboBoxInterval.Name = "comboBoxInterval";
            this.comboBoxInterval.Size = new System.Drawing.Size(121, 24);
            this.comboBoxInterval.TabIndex = 26;
            // 
            // buttonGetStockData
            // 
            this.buttonGetStockData.Location = new System.Drawing.Point(1183, 224);
            this.buttonGetStockData.Name = "buttonGetStockData";
            this.buttonGetStockData.Size = new System.Drawing.Size(255, 23);
            this.buttonGetStockData.TabIndex = 27;
            this.buttonGetStockData.Text = "Get Stock Data for selected exchange";
            this.buttonGetStockData.UseVisualStyleBackColor = true;
            this.buttonGetStockData.Click += new System.EventHandler(this.buttonGetStockData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(758, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(721, 187);
            this.dataGridView1.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(738, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Symbol: ";
            // 
            // checkedListBoxSymbol
            // 
            this.checkedListBoxSymbol.FormattingEnabled = true;
            this.checkedListBoxSymbol.Location = new System.Drawing.Point(829, 103);
            this.checkedListBoxSymbol.MultiColumn = true;
            this.checkedListBoxSymbol.Name = "checkedListBoxSymbol";
            this.checkedListBoxSymbol.Size = new System.Drawing.Size(359, 106);
            this.checkedListBoxSymbol.TabIndex = 30;
            // 
            // buttonGetSymbols
            // 
            this.buttonGetSymbols.Location = new System.Drawing.Point(1233, 103);
            this.buttonGetSymbols.Name = "buttonGetSymbols";
            this.buttonGetSymbols.Size = new System.Drawing.Size(228, 29);
            this.buttonGetSymbols.TabIndex = 31;
            this.buttonGetSymbols.Text = "Get Symbols for Selected Exchange";
            this.buttonGetSymbols.UseVisualStyleBackColor = true;
            this.buttonGetSymbols.Click += new System.EventHandler(this.buttonGetSymbols_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 637);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(709, 585);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1001, 585);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1770, 745);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonGetSymbols);
            this.Controls.Add(this.checkedListBoxSymbol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGetStockData);
            this.Controls.Add(this.comboBoxInterval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxOutputSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxExchangeCode);
            this.Controls.Add(this.buttonFetchStockMaster);
            this.Controls.Add(this.dataGridViewStockData);
            this.Controls.Add(this.buttonLoadFundHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMF);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStockData)).EndInit();
            this.panelMF.ResumeLayout(false);
            this.panelMF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewStockData;
        private System.Windows.Forms.Button buttonShowNAVData;
        private System.Windows.Forms.Button buttonFetchAllForRange;
        private System.Windows.Forms.Button buttonDownloadLatest;
        private System.Windows.Forms.Button buttonOpenPortfolio;
        private System.Windows.Forms.Button buttonUpdateFromLastFetch;
        private System.Windows.Forms.Panel panelMF;
        private System.Windows.Forms.Button buttonFetchStockMaster;
        private System.Windows.Forms.ComboBox comboBoxExchangeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxOutputSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxInterval;
        private System.Windows.Forms.Button buttonGetStockData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox checkedListBoxSymbol;
        private System.Windows.Forms.Button buttonGetSymbols;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

