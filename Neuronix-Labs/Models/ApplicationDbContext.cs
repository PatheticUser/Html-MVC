using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace Neuronix_Labs.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

        public DbSet<Article> Articles { get; set; } // Connects Articles table to the database
        public DbSet<Services> Services { get; set; }
    }
}

