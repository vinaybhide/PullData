using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PullData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxFundHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fundhouse = comboBoxFundHouse.SelectedText.ToString();
            int code = System.Convert.ToInt32(comboBoxFundHouse.SelectedValue);

            if (code > 0)
            {
                DataManager dataMgr = new DataManager();
                DataTable tableSchemes = dataMgr.getSchemesTable(fundhousecode: code);

                comboBoxSchemeName.DisplayMember = "SCHEMENAME";
                comboBoxSchemeName.ValueMember = "SCHEMECODE";
                comboBoxSchemeName.DataSource = tableSchemes;
            }
        }

        private void buttonDateRange_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimeFromDate.Value;
            DateTime toDate = dateTimeToDate.Value;
            int code = System.Convert.ToInt32(comboBoxFundHouse.SelectedValue);

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            DataManager dataMgr = new DataManager();
            dataMgr.getHistoryNAVForMFCode(code.ToString(), fromDate.ToString("yyyy-MM-dd"), todt: toDate.ToString("yyyy-MM-dd"));

            MessageBox.Show(stopwatch.Elapsed.TotalSeconds.ToString() + "- seconds with one transaction.");
        }
        private void buttonGetDataForFromClicked(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimeFromDate.Value;
            DataManager dataMgr = new DataManager();
            dataMgr.getAllMFNAVForDate(selectedDate.ToString("yyyy-MM-dd"));
        }

        private void buttonLoadFundHouse_Click(object sender, EventArgs e)
        {
            DataManager dataMgr = new DataManager();
            DataTable tableFundHouse = dataMgr.getFundHouseTable();
            comboBoxFundHouse.DisplayMember = "NAME";
            comboBoxFundHouse.ValueMember = "FUNDHOUSECODE";
            comboBoxFundHouse.DataSource = tableFundHouse;
        }

        private void buttonShowNAVData_Click(object sender, EventArgs e)
        {
            DataManager dataMgr = new DataManager();
            DataTable tableNAV = dataMgr.getNAVRecordsTable(System.Convert.ToInt32(comboBoxSchemeName.SelectedValue), dateTimeFromDate.Text, dateTimeToDate.Text);
            dataGridViewNAVData.DataSource = tableNAV;
        }

        private void buttonFetchAllForRange_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            DataManager dataMgr = new DataManager();
            dataMgr.TestLoadFromTo(dateTimeFromDate.Value, dateTimeToDate.Value);

            MessageBox.Show(stopwatch.Elapsed.TotalSeconds.ToString() + "- seconds with one transaction.");
        }

        private void buttonDownloadLatest_Click(object sender, EventArgs e)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            DataManager dataMgr = new DataManager();
            dataMgr.getAllMFNAVToday();

            MessageBox.Show(stopwatch.Elapsed.TotalSeconds.ToString() + "- seconds with one transaction.");

        }
        private void buttonOpenPortfolio_Click(object sender, EventArgs e)
        {
            DataManager dataMgr = new DataManager();
            DataTable portfolioTable = dataMgr.openMFPortfolio("a@a.com", "TestPF", "2");
            dataGridViewNAVData.DataSource = portfolioTable;
        }

        private void buttonUpdateFromLastFetch_Click(object sender, EventArgs e)
        {
            DataManager dataMgr = new DataManager();
            dataMgr.UpdateNAVFromLastFetchDate();
        }
    }
}
