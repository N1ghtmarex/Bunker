using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class GameSessionCardSetBindConfiguration : IEntityTypeConfiguration<GameSessionCardSetBind>
{
    public void Configure(EntityTypeBuilder<GameSessionCardSetBind> builder)
    {
        builder.ToTable("game_session_card_set_bind");

        builder.HasKey(x => new { x.CardSetId, x.GameSessionId });

        builder.Property(x => x.CardSetId).IsRequired();
        builder.HasOne(x => x.CardSet)
            .WithMany()
            .HasForeignKey(x => x.CardSetId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.GameSessionId).IsRequired();
        builder.HasOne(x => x.GameSession)
            .WithMany()
            .HasForeignKey(x => x.GameSessionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
