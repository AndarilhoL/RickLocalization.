using Microsoft.EntityFrameworkCore;
using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence
{
    public class RickLocalizationContext : DbContext
    {
        public RickLocalizationContext(DbContextOptions<RickLocalizationContext> options): base(options)
        {
            
        }

        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<Morty> Morties { get; set; }
        public DbSet<Rick> Ricks { get; set; }
    }
}