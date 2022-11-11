using Microsoft.EntityFrameworkCore;

namespace ComputerStore.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Category> categories => Set<Category>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Purchase> Purchases => Set<Purchase>();

        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Configure();
            modelBuilder.Seed();
        }
    }
}
