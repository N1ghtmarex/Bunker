using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class CardConfiguration : IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.ToTable("card");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        // TODO: Можно накинуть индекс на уникальность, если хотим чтобы имена карт, наборов были уникальными
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Type).IsRequired();
    }
}
