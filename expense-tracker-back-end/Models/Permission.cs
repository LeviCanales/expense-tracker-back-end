using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string Value { get; set; }
        public ICollection<UserPermission> PermissionLink { get; set; }
    }
}
