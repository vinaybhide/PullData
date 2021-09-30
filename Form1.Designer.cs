
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNAVData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGetDataForFromDate
            // 
            this.buttonGetDataForFromDate.Location = new System.Drawing.Point(24, 198);
            this.buttonGetDataForFromDate.Name = "buttonGetDataForFromDate";
            this.buttonGetDataForFromDate.Size = new System.Drawing.Size(200, 23);
            this.buttonGetDataForFromDate.TabIndex = 0;
            this.buttonGetDataForFromDate.Text = "Get data for From Date";
            this.buttonGetDataForFromDate.UseVisualStyleBackColor = true;
            this.buttonGetDataForFromDate.Click += new System.EventHandler(this.buttonGetDataForFromClicked);
            // 
            // comboBoxFundHouse
            // 
            this.comboBoxFundHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFundHouse.FormattingEnabled = true;
            this.comboBoxFundHouse.Location = new System.Drawing.Point(145, 26);
            this.comboBoxFundHouse.Name = "comboBoxFundHouse";
            this.comboBoxFundHouse.Size = new System.Drawing.Size(171, 21);
            this.comboBoxFundHouse.TabIndex = 1;
            this.comboBoxFundHouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxFundHouse_SelectedIndexChanged);
            // 
            // comboBoxSchemeName
            // 
            this.comboBoxSchemeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSchemeName.FormattingEnabled = true;
            this.comboBoxSchemeName.Location = new System.Drawing.Point(145, 67);
            this.comboBoxSchemeName.Name = "comboBoxSchemeName";
            this.comboBoxSchemeName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSchemeName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scheme Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fund House:";
            // 
            // dateTimeFromDate
            // 
            this.dateTimeFromDate.Location = new System.Drawing.Point(145, 118);
            this.dateTimeFromDate.Name = "dateTimeFromDate";
            this.dateTimeFromDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFromDate.TabIndex = 6;
            // 
            // dateTimeToDate
            // 
            this.dateTimeToDate.Location = new System.Drawing.Point(145, 156);
            this.dateTimeToDate.Name = "dateTimeToDate";
            this.dateTimeToDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimeToDate.TabIndex = 7;
            // 
            // buttonDateRange
            // 
            this.buttonDateRange.Location = new System.Drawing.Point(243, 198);
            this.buttonDateRange.Name = "buttonDateRange";
            this.buttonDateRange.Size = new System.Drawing.Size(136, 23);
            this.buttonDateRange.TabIndex = 8;
            this.buttonDateRange.Text = "Get Data for range";
            this.buttonDateRange.UseVisualStyleBackColor = true;
            this.buttonDateRange.Click += new System.EventHandler(this.buttonDateRange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "From Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "To Date:";
            // 
            // buttonLoadFundHouse
            // 
            this.buttonLoadFundHouse.Location = new System.Drawing.Point(345, 26);
            this.buttonLoadFundHouse.Name = "buttonLoadFundHouse";
            this.buttonLoadFundHouse.Size = new System.Drawing.Size(113, 23);
            this.buttonLoadFundHouse.TabIndex = 11;
            this.buttonLoadFundHouse.Text = "Load Fund House";
            this.buttonLoadFundHouse.UseVisualStyleBackColor = true;
            this.buttonLoadFundHouse.Click += new System.EventHandler(this.buttonLoadFundHouse_Click);
            // 
            // dataGridViewNAVData
            // 
            this.dataGridViewNAVData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNAVData.Location = new System.Drawing.Point(24, 249);
            this.dataGridViewNAVData.Name = "dataGridViewNAVData";
            this.dataGridViewNAVData.Size = new System.Drawing.Size(732, 150);
            this.dataGridViewNAVData.TabIndex = 12;
            // 
            // buttonShowNAVData
            // 
            this.buttonShowNAVData.Location = new System.Drawing.Point(416, 197);
            this.buttonShowNAVData.Name = "buttonShowNAVData";
            this.buttonShowNAVData.Size = new System.Drawing.Size(130, 23);
            this.buttonShowNAVData.TabIndex = 13;
            this.buttonShowNAVData.Text = "Show NAV Data";
            this.buttonShowNAVData.UseVisualStyleBackColor = true;
            this.buttonShowNAVData.Click += new System.EventHandler(this.buttonShowNAVData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

