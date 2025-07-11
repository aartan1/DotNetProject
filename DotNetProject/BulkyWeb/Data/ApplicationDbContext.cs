using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using BulkyWeb.Models;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category>Categories{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { İd = 1, Name = "Action", DisplayOrder = 1 },
                new Category { İd = 2, Name = "History", DisplayOrder = 2 },
                new Category { İd = 3, Name = "Scifi", DisplayOrder = 3 }
                );
        }
    }
}
