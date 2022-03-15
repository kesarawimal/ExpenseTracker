using ExpenseTracker.DataObjects;
using ExpenseTracker.Models;
using ExpenseTracker.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class MainForm : Form
    {
        ExpenseTrackerData dbData = new ExpenseTrackerData();
        UserProfile userProfile = new UserProfile();

        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckAuthentication(object sender, EventArgs e)
        {
            Boolean hasAuthenticated = this.userProfile.HasAuthenticated();

            if (hasAuthenticated == false)
            {
                LoginView loginView = new LoginView();
                //loginView.Show();
                //this.Hide();
            }
        }

        private void AddTransaction(object sender, EventArgs e)
        {
            AddTransactionView addTransactionView = new AddTransactionView();
            addTransactionView.ShowDialog();
            TransactionData transactionData = addTransactionView.transactionData;
            addTransactionView.Dispose();

            //store
            if (transactionData != null)
            {
                ExpenseTrackerData.TransactionRow row = this.dbData.Transaction.NewTransactionRow();
                row.note = transactionData.note;
                row.date = transactionData.date;
                row.type = transactionData.type;
                row.amount = transactionData.amount;
                row.isReccuring = transactionData.isReccuring;
                row.frequency = transactionData.frequency;
                row.period = transactionData.period;
                row.user_id = this.userProfile.getUserId();
                this.dbData.Transaction.AddTransactionRow(row);

                if (transactionData.isReccuring)
                {
                    for (int i = 1; i <= transactionData.period; i++)
                    {
                        DateTime date;
                        if (transactionData.frequency == "Daily")
                        {
                            date = DateTime.ParseExact(transactionData.date, "dd/MM/yyyy", null).AddDays(1 * i);
                        } else if (transactionData.frequency == "Weekly")
                        {
                            date = DateTime.ParseExact(transactionData.date, "dd/MM/yyyy", null).AddDays(7 * i);
                        } else
                        {
                            date = DateTime.ParseExact(transactionData.date, "dd/MM/yyyy", null).AddDays(30 * i);
                        }

                        ExpenseTrackerData.TransactionRow iRow = this.dbData.Transaction.NewTransactionRow();
                        iRow.note = transactionData.note;
                        iRow.date = date.ToString("dd/MM/yyyy");
                        iRow.type = transactionData.type;
                        iRow.amount = transactionData.amount;
                        iRow.isReccuring = transactionData.isReccuring;
                        iRow.user_id = this.userProfile.getUserId();
                        this.dbData.Transaction.AddTransactionRow(iRow);
                    }
                }
            }
        }

        private void TabSelected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == transactions)
            {
                this.dtgTransactions.DataSource = this.dbData.Transaction;
            }

            if (e.TabPage == dashboard)
            {

                DashboardCalculation dashboardCalculation = new DashboardCalculation(dbData);
                DashboardData todayDashboardData = dashboardCalculation.TodayDashboardData();
                this.lblTodayIncome.Text = todayDashboardData.income.ToString() + " USD";
                this.lblTodayExpense.Text = todayDashboardData.expense.ToString() + " USD";
                this.lblTodayBalance.Text = todayDashboardData.balance.ToString() + " USD";

                DashboardData yesterdayDashboardData = dashboardCalculation.YesterdayDashboardData();
                this.lblYesterdayIncome.Text = yesterdayDashboardData.income.ToString() + " USD";
                this.lblYesterdayExpense.Text = yesterdayDashboardData.expense.ToString() + " USD";
                this.lblYesterdayBalance.Text = yesterdayDashboardData.balance.ToString() + " USD";
                

                DashboardData last7daysDashboardData = dashboardCalculation.Last7daysDashboardData();
                this.lbl7daysIncome.Text = last7daysDashboardData.income.ToString() + " USD";
                this.lbl7daysExpense.Text = last7daysDashboardData.expense.ToString() + " USD";
                this.lbl7daysBalance.Text = last7daysDashboardData.balance.ToString() + " USD";

            }

            if (e.TabPage == reports)
            {
                DateTime last7days = DateTime.Today.AddDays(-7);
                DataRow[] results;
                results = this.dbData.Transaction.Select("date > '" + last7days.ToString("dd/MM/yyyy") + "'");
               
                // clear all data
                this.chrtWeeklyReport.Series["Income"].Points.Clear();
                this.chrtWeeklyReport.Series["Expense"].Points.Clear(); 
                this.chrtWeeklyOverallReport.Series["Income"].Points.Clear();
                this.chrtWeeklyOverallReport.Series["Expense"].Points.Clear();

                Double overallIncome = 0.0;
                Double overallExpense = 0.0;
                ReportCalculation reportCalculation = new ReportCalculation(this.dbData);

                foreach (String[] array in reportCalculation.WeeklyReportData())
                {
                    this.chrtWeeklyReport.Series["Income"].Points.AddXY(array[0], array[1]);
                    this.chrtWeeklyReport.Series["Expense"].Points.AddXY(array[0], array[2]);

                    overallIncome += Double.Parse(array[1].ToString());
                    overallExpense += Double.Parse(array[2].ToString());
                }

                this.chrtWeeklyOverallReport.Series["Income"].Points.AddXY("Last 7 Days", overallIncome);
                this.chrtWeeklyOverallReport.Series["Expense"].Points.AddXY("Last 7 Days", overallExpense);
            }
        }

        private void dtgTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.dbData.Transaction.Rows[e.RowIndex].Delete();
            }
        }

        private void ForecasteValues(object sender, EventArgs e)
        {
            DateTime forecastDate = this.dtForecastDate.Value.Date;
            DateTime today = DateTime.Today;
            Double days = (forecastDate - today).TotalDays;

            ForecastCalculation forecastCalculation = new ForecastCalculation(this.dbData);

            this.lblPredictIncome.Text = (forecastCalculation.GetAverageIncome() * days).ToString() + " USD";
            this.lblPredictExpense.Text = (forecastCalculation.GetAverageExpense() * days).ToString() + " USD";
        }
    }
}
