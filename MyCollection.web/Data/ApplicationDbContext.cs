using Microsoft.EntityFrameworkCore;
using MyCollection.web.Models;

namespace MyCollection.web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Artist> Artists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist { Id = 1, FirstName = "Gerrit", LastName = "Baeten" },
                new Artist { Id = 2, FirstName = "", LastName = "Banksy" },
                new Artist { Id = 3, FirstName = "Etienne", LastName = "Bauwens" },
                new Artist { Id = 4, FirstName = "Geert", LastName = "Bauwens" },
                new Artist { Id = 5, FirstName = "René", LastName = "Bekaert" }
                );
        }
    }
}
