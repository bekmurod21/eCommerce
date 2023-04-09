using eCommerce.Domain.Entities.Orders;
using eCommerce.Domain.Entities.Products;
using eCommerce.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string query = "Server=(localdb)\\MSSQLLocalDB;" +
                           "Database=eCommerceDb;" +
                           "Trusted_Connection=true";
            optionsBuilder.UseSqlServer(query);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
