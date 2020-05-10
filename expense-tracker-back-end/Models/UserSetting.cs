using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class UserSetting
    {
        public int UserID { get; set; }
        public int SettingID { get; set; }

        public User User { get; set; }
        public Setting Setting { get; set; }
    }
}
