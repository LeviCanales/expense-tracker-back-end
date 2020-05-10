using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class PaymentType
    {
        public int PaymentTypeID { get; set; }
        public string PaymentTypeName { get; set; }
        public int UserID { get; set; }
    }
}
