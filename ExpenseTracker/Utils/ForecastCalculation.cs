using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Utils
{
    internal class ForecastCalculation
    {
        ExpenseTrackerData dbData;

        public ForecastCalculation(ExpenseTrackerData dbData)
        {
            this.dbData = dbData;
        }

        public Double GetAverageExpense()
        {

            DataRow[] results;
            results = this.dbData.Transaction.Select("type = 'Expense'");
            Double expense = 0.0;
            HashSet<String> days = new HashSet<String>();

            foreach (DataRow dataRow in results)
            {
                expense += Double.Parse(dataRow["amount"].ToString());
                days.Add(dataRow["date"].ToString());
            }

            return expense / days.Count();
        }

        public Double GetAverageIncome()
        {

            DataRow[] results;
            results = this.dbData.Transaction.Select("type = 'Income'");
            Double income = 0.0;
            HashSet<String> days = new HashSet<String>();

            foreach (DataRow dataRow in results)
            {
                income += Double.Parse(dataRow["amount"].ToString());
                days.Add(dataRow["date"].ToString());
            }

            return income / days.Count();
        }
    }
}
