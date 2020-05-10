using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public string Image { get; set; }
        public System.DateTime CreationDate { get; set; }

        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public int PaymentTypeID { get; set; }
    }
}
