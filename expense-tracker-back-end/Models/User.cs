using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public ICollection<UserPermission> PermissionLink { get; set; }
        public ICollection<UserSetting> SettingLink { get; set; }
        public ICollection<PaymentType> UserPaymentTypes { get; set; }
        public ICollection<Category> UserCategories { get; set; }
        public ICollection<Expense> UserExpenses { get; set; }
        public ICollection<Alarm> UserAlarms { get; set; }
    }
}
