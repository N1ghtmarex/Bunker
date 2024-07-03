using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class PlayerCardBindConfiguration : IEntityTypeConfiguration<PlayerCardBind>
{
    public void Configure(EntityTypeBuilder<PlayerCardBind> builder)
    {
        builder.ToTable("player_card_bind");

        builder.HasKey(x => new { x.PlayerId, x.CardId });

        builder.Property(x => x.PlayerId).IsRequired();
        builder.HasOne(x => x.Player)
            .WithMany()
            .HasForeignKey(x => x.PlayerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.CardId).IsRequired();
        builder.HasOne(x => x.Card)
            .WithMany()
            .HasForeignKey(x => x.CardId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.IsKnown).IsRequired();
    }
}
