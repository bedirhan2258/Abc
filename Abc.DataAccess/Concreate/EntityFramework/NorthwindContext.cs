using Abc.Northwind.Entities.Concreate;
using Microsoft.EntityFrameworkCore;

namespace Abc.DataAccess.Concreate.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\S2012; Initial Catalog=Northwind; User Id=sa; Password=1");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
