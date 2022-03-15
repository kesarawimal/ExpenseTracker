using ExpenseTracker.DataObjects;
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
    public partial class AddTransactionView : Form
    {
        public TransactionData transactionData { get; set; }

        public AddTransactionView()
        {
            InitializeComponent();
        }

        private void SaveTransaction(object sender, EventArgs e)
        {
            if (this.transactionData == null)
            {
                this.transactionData = new TransactionData();
            }
            this.transactionData.note = this.txtNote.Text;
            this.transactionData.date = this.dtDate.Text;
            this.transactionData.type = this.cmbType.Text;
            this.transactionData.amount = Convert.ToInt32(this.numAmount.Value);
            this.transactionData.isReccuring = this.chkReccuring.Checked;
            this.transactionData.frequency = this.cmbFrequency.Text;
            this.transactionData.period = Convert.ToInt32(this.numPeriod.Value);
            this.Hide();
        }

        private void ChangeReccuringOptions(object sender, EventArgs e)
        {
            if (this.chkReccuring.Checked)
            {
                this.tblReccuring.Show();
            } else
            {
                this.tblReccuring.Hide();
            }
        }
    }
}
