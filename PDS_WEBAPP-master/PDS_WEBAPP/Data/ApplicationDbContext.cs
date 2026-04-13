using Microsoft.EntityFrameworkCore;
using PDS_WebApp.Models;

namespace PDS_WebApp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<PersonalDataSheet> PersonalDataSheets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalDataSheet>()
                .Property(p => p.Height)
                .HasColumnType("decimal(5,2)");

            modelBuilder.Entity<PersonalDataSheet>()
                .Property(p => p.Weight)
                .HasColumnType("decimal(5,2)");
        }
    }
}
