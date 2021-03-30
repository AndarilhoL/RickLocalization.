using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RickLocalization.Domain.Models;

namespace RickLocalization.Persistence.Mappings
{
    public class RickMapping : IEntityTypeConfiguration<Rick>
    {
        public void Configure(EntityTypeBuilder<Rick> builder)
        {
            builder.HasKey(d => d.Id);

            builder.HasOne(r => r.Morty)
                .WithOne(m => m.Rick);

            builder.HasOne(r => r.Dimension)
                .WithOne(d => d.Rick);

            builder.HasMany(r => r.DimensionsTraveller)
                .WithOne(dt => dt.Rick);

            builder.ToTable("Rick");
        }
    }
}