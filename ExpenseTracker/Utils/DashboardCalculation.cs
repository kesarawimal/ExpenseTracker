using ExpenseTracker.DataObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Utils
{
    public class DashboardCalculation
    {
        ExpenseTrackerData dbData;

        public DashboardCalculation(ExpenseTrackerData dbData)
        {
            this.dbData = dbData;
        }

        public DashboardData TodayDashboardData()
        {
            DashboardData dashboardDate = new DashboardData();
            DateTime today = DateTime.Today;
            DataRow[] results;
            results = this.dbData.Transaction.Select("date = '" + today.ToString("dd/MM/yyyy") + "'");

            Double income = 0.0;
            Double expense = 0.0;

            foreach (DataRow dataRow in results)
            {
                if (dataRow["type"].ToString() == "Income")
                {
                    income += Double.Parse(dataRow["amount"].ToString());
                }
                else
                {
                    expense += Double.Parse(dataRow["amount"].ToString());
                }
            }

            dashboardDate.income = income;
            dashboardDate.expense = expense;
            dashboardDate.balance = income - expense;

            return dashboardDate;
        }

        public DashboardData YesterdayDashboardData()
        {
            DashboardData dashboardDate = new DashboardData();
            DateTime yesterday = DateTime.Today.AddDays(-1);
            DataRow[] results;
            results = this.dbData.Transaction.Select("date = '" + yesterday.ToString("dd/MM/yyyy") + "'");

            Double income = 0.0;
            Double expense = 0.0;

            foreach (DataRow dataRow in results)
            {
                if (dataRow["type"].ToString() == "Income")
                {
                    income += Double.Parse(dataRow["amount"].ToString());
                }
                else
                {
                    expense += Double.Parse(dataRow["amount"].ToString());
                }
            }

            dashboardDate.income = income;
            dashboardDate.expense = expense;
            dashboardDate.balance = income - expense;

            return dashboardDate;
        }

        public DashboardData Last7daysDashboardData()
        {
            DashboardData dashboardDate = new DashboardData();
            DateTime last7days = DateTime.Today.AddDays(-7);
            DataRow[] results;
            results = this.dbData.Transaction.Select("date > '" + last7days.ToString("dd/MM/yyyy") + "'");

            Double income = 0.0;
            Double expense = 0.0;

            foreach (DataRow dataRow in results)
            {
                if (dataRow["type"].ToString() == "Income")
                {
                    income += Double.Parse(dataRow["amount"].ToString());
                }
                else
                {
                    expense += Double.Parse(dataRow["amount"].ToString());
                }
            }

            dashboardDate.income = income;
            dashboardDate.expense = expense;
            dashboardDate.balance = income - expense;

            return dashboardDate;
        }
    }
}
