using ExpenseTracker.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    internal class TransactionProfile
    {
        ExpenseTrackerData dbData;

        public TransactionProfile(ExpenseTrackerData dbData)
        {
            this.dbData = dbData;
        }

        public void SeedTransactions()
        {
            List<TransactionData> trasactionDatas = new List<TransactionData>();
            trasactionDatas.Add(new TransactionData
            {
                note = "Salary",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                type = "Income",
                amount = 800,
                isReccuring = true
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Rental Income",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                type = "Income",
                amount = 200,
                isReccuring = true
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Shopping",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 100,
                isReccuring = false
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Movie Night",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 150,
                isReccuring = false
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Miscellaneous",
                date = DateTime.Today.ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 50,
                isReccuring = false
            });

            trasactionDatas.Add(new TransactionData
            {
                note = "Passive Income",
                date = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
                type = "Income",
                amount = 100,
                isReccuring = false
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Party",
                date = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 100,
                isReccuring = false
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Food",
                date = DateTime.Today.AddDays(-1).ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 50,
                isReccuring = false
            });

            trasactionDatas.Add(new TransactionData
            {
                note = "Utility Bills",
                date = DateTime.Today.AddDays(-2).ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 150,
                isReccuring = true
            });
            trasactionDatas.Add(new TransactionData
            {
                note = "Food",
                date = DateTime.Today.AddDays(-5).ToString("dd/MM/yyyy"),
                type = "Expense",
                amount = 50,
                isReccuring = false
            });

            foreach (TransactionData transactionData in trasactionDatas)
            {
                ExpenseTrackerData.TransactionRow row = this.dbData.Transaction.NewTransactionRow();
                row.note = transactionData.note;
                row.date = transactionData.date;
                row.type = transactionData.type;
                row.amount = transactionData.amount;
                row.isReccuring = transactionData.isReccuring;
                row.user_id = 1;
                this.dbData.Transaction.AddTransactionRow(row);
            }
        }
    }
}
