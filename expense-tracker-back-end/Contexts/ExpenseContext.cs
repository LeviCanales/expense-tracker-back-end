using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using expense_tracker_back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace expense_tracker_back_end.Contexts
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPermission>().HasKey(id=> new { id.UserID, id.PermissionID });
            modelBuilder.Entity<UserSetting>().HasKey(id => new { id.UserID, id.SettingID });
        }

        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
    }
}
