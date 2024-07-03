using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class CardSetSpecialCardBindConfiguration : IEntityTypeConfiguration<CardSetSpecialCardBind>
{
    public void Configure(EntityTypeBuilder<CardSetSpecialCardBind> builder)
    {
        builder.ToTable("card_set_special_card_bind");

        builder.HasKey(x => new { x.CardSetId, x.SpecialCardId });

        builder.Property(x => x.CardSetId).IsRequired();
        builder.HasOne(x => x.CardSet)
            .WithMany()
            .HasForeignKey(x => x.CardSetId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.SpecialCardId).IsRequired();
        builder.HasOne(x => x.SpecialCard)
            .WithMany()
            .HasForeignKey(x => x.SpecialCardId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
