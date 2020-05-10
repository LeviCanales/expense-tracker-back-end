using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace expense_tracker_back_end.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
    }
}
