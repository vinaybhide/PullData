using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                DataTable tableSchemes = DataManager.getSchemesTable(fundhousecode: code);

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


            DataManager.getHistoryNAVForMFCode(code.ToString(), fromDate.ToString("yyyy-MM-dd"), todt: toDate.ToString("yyyy-MM-dd"));


        }
        private void buttonGetDataForFromClicked(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimeFromDate.Value;
            DataManager.getAllMFNAVForDate(selectedDate.ToString("yyyy-MM-dd"));
        }

        private void buttonLoadFundHouse_Click(object sender, EventArgs e)
        {
            DataTable tableFundHouse = DataManager.getFundHouseTable();
            comboBoxFundHouse.DisplayMember = "NAME";
            comboBoxFundHouse.ValueMember = "FUNDHOUSECODE";
            comboBoxFundHouse.DataSource = tableFundHouse;
        }

        private void buttonShowNAVData_Click(object sender, EventArgs e)
        {
            DataTable tableNAV = DataManager.getNAVRecordsTable(System.Convert.ToInt32(comboBoxSchemeName.SelectedValue), dateTimeFromDate.Text, dateTimeToDate.Text);
            dataGridViewNAVData.DataSource = tableNAV;
        }

    }
}
