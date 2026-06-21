using Microsoft.EntityFrameworkCore;
using StorageManagement.Data.Models;

namespace StorageManagement.Data
{
    public class StorageManagementDbContext : DbContext
    {
        public StorageManagementDbContext(DbContextOptions<StorageManagementDbContext> options) 
         : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StorageManagementDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
