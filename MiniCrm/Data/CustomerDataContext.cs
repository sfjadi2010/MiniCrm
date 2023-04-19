using Microsoft.EntityFrameworkCore;
using MiniCrm.Models;

namespace MiniCrm.Data
{
    public class CustomerDataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MiniCrm.db");
        }
    }
}
