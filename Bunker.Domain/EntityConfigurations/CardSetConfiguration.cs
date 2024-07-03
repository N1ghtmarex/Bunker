using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class CardSetConfiguration : IEntityTypeConfiguration<CardSet>
{
    public void Configure(EntityTypeBuilder<CardSet> builder)
    {
        builder.ToTable("card_set");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Type).IsRequired();
    }
}
