using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class CardSetCardBindConfiguration : IEntityTypeConfiguration<CardSetCardBind>
{
    public void Configure(EntityTypeBuilder<CardSetCardBind> builder)
    {
        builder.ToTable("card_set_card_bind");

        builder.HasKey(x => new { x.CardSetId, x.CardId });

        builder.Property(x => x.CardSetId).IsRequired();
        builder.HasOne(x => x.CardSet)
            .WithMany()
            .HasForeignKey(x => x.CardSetId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.CardId).IsRequired();
        builder.HasOne(x => x.Card)
            .WithMany()
            .HasForeignKey(x => x.CardId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
