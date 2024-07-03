using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class BunkerItemConfiguration : IEntityTypeConfiguration<BunkerItem>
{
    public void Configure(EntityTypeBuilder<BunkerItem> builder)
    {
        builder.ToTable("bunker_item");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Status).IsRequired();
    }
}
