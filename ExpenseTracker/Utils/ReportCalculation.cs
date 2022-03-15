using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Utils
{
    public class ReportCalculation
    {
        ExpenseTrackerData dbData;

        public ReportCalculation(ExpenseTrackerData dbData)
        {
            this.dbData = dbData;
        }

        public List<Array> WeeklyReportData()
        {
            List<Array> data = new List<Array>();

            for (int i = 0; i > -7; i--)
            {
                DateTime date = DateTime.Today.AddDays(i);
                DataRow[] results;
                results = this.dbData.Transaction.Select("date = '" + date.ToString("dd/MM/yyyy") + "'");

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

                String[] array = { date.ToString("dd/MM/yyyy"), income.ToString(), expense.ToString() };
                data.Add(array);
            }

            return data;
        }
    }
}
