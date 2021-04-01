using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence
{
    public class RickLocalizationContext : DbContext
    {
        public RickLocalizationContext(DbContextOptions<RickLocalizationContext> options) : base(options)
        {

        }

        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Morty> Morties { get; set; }
        public DbSet<Rick> Ricks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Rick>()
                .HasOne(r => r.Morty)
                .WithOne(m => m.Rick)
                .HasForeignKey<Morty>(m => m.Id);

            builder.Entity<Morty>()
                .HasOne(m => m.Rick)
                .WithOne(r => r.Morty)
                .HasForeignKey<Rick>(r => r.Id);

            //Dimensão -> Rick
            builder.Entity<Dimension>()
                .HasOne(d => d.Rick)
                .WithOne(r => r.Dimension)
                .HasForeignKey<Rick>(r => r.Id);

            //Dimensão -> Morty
            builder.Entity<Dimension>()
                .HasOne(d => d.Morty)
                .WithOne(m => m.Dimension)
                .HasForeignKey<Morty>(m => m.Id);
        }
    }
}