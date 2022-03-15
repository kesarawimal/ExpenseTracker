using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.DataObjects
{
    public class TransactionData
    {
        public String note { get; set; }
        public String date { get; set; }
        public String type { get; set; }
        public int amount { get; set; }
        public Boolean isReccuring { get; set; }
        public String frequency { get; set; }
        public int period { get; set; }
    }
}
