using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence.Mappings
{
    public class MortyMapping : IEntityTypeConfiguration<Morty>
    {
        public void Configure(EntityTypeBuilder<Morty> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(m => m.Rick)
                .WithOne(r => r.Morty);

            builder.HasOne(m => m.Dimension)
                .WithOne(d => d.Morty);

            builder.ToTable("Morty");
        }
    }
}