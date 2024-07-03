using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class PlayerSpecialCardBindConfiguration : IEntityTypeConfiguration<PlayerSpecialCardBind>
{
    public void Configure(EntityTypeBuilder<PlayerSpecialCardBind> builder)
    {
        builder.ToTable("player_special_card_bind");

        builder.HasKey(x => new { x.PlayerId, x.SpecialCardId });

        builder.Property(x => x.PlayerId).IsRequired();
        builder.HasOne(x => x.Player)
            .WithMany()
            .HasForeignKey(x => x.PlayerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.SpecialCardId).IsRequired();
        builder.HasOne(x => x.SpecialCard)
            .WithMany()
            .HasForeignKey(x => x.SpecialCardId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.IsUsed).IsRequired();
    }
}
