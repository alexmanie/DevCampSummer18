using FormsSummerCamp2018.Entities;
using FormsSummerCamp2018.Utils;
using QuickType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.textBox1.LostFocus += TextBox1_LostFocus;
        }

        private void TextBox1_LostFocus(object sender, EventArgs e)
        {
            
        }

        private async void btnGetData_Click(object sender, EventArgs e)
        {
            // GetData
            //object data = Utils.FileUtils.ReadSampleDataAsObject();
            //var sampleData = SampleData.FromJson(data.ToString());

            var budgetsData = await Utils.FileUtils.ReadBudgetDataAsync();
            var budgetsDataJson = Budget.FromJson(budgetsData);

            var contractsData = await Utils.FileUtils.ReadContractsDataAsync();
            var contractsDataJson = Contract.FromJson(contractsData);

            var workData = await Utils.FileUtils.ReadWorkDataAsync();
            var workDataJson = Work.FromJson(workData);

            var budgetsOver = CalculateUtils.CalculateOverImputed(budgetsDataJson, workDataJson);
            var budgetsUnder = CalculateUtils.CalculateUnderImputed(budgetsDataJson, workDataJson);

            this.gridOverImputed.DataSource = budgetsOver;
            this.gridUnderImputed.DataSource = budgetsUnder;
        }
    }
}
