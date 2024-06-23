using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products {get; set;}
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){ProductId=1,ProductName="Computer",Price=17_000},
                new Product(){ProductId=2,ProductName="Keyboard",Price=17_000},
                new Product(){ProductId=3,ProductName="Monitor",Price=17_000},
                new Product(){ProductId=4,ProductName="Mouse",Price=17_000},
                new Product(){ProductId=5,ProductName="Mouse Pad",Price=17_000}
            );
        }
    }
}