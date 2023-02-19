using ContossoPizza.Models;
using Microsoft.EntityFrameworkCore;

namespace ContossoPizza.Data
{
    public class ContossoPizzaContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=ContossoPizzaDb;Trusted_Connection=True;Integrated Security=True;");
        }
    }
}
