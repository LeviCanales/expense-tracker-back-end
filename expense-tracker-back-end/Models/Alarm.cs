using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Alarm
    {
        public int AlarmID { get; set; }
        public string Description { get; set; }
        public decimal MaxCost { get; set; }
        public int MaxQuantity { get; set; }
        public System.DateTime StartCountDate { get; set; }

        public int UserID { get; set; }
        public int CategoryID { get; set; }
    }
}
