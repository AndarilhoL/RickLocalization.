using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence.Mappings
{
    public class DimensionMapping : IEntityTypeConfiguration<Dimension>
    {
        public void Configure(EntityTypeBuilder<Dimension> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(r => r.Rick)
                .WithOne(d => d.Dimension);

            builder.HasOne(m => m.Morty)
                .WithOne(d => d.Dimension);

            builder.ToTable("Dimension");
        }
    }
}