using Microsoft.EntityFrameworkCore;

namespace Zanobya.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public ApplicationDbContext()
        {

        }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderLine> Orderline { get; set; }

        public DbSet<Products> Products { get; set; }

    }
}
