using Abc.Northwind.Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace Abc.DataAccess.Concreate.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\S2012; Database=Northwind; Trusted_Connection=true");
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
