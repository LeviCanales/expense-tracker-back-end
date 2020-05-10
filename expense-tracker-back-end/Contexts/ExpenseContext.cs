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

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
