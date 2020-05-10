using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Setting
    {
        public int SettingID { get; set; }
        public string SettingName { get; set; }
        public string Value { get; set; }
        public ICollection<UserSetting> UserLink { get; set; }
    }
}
