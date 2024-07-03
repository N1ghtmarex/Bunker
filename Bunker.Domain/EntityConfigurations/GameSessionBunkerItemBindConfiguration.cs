using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class GameSessionBunkerItemBindConfiguration : IEntityTypeConfiguration<GameSessionBunkerItemBind>
{
    public void Configure(EntityTypeBuilder<GameSessionBunkerItemBind> builder)
    {
        builder.ToTable("game_session_bunker_item_bind");
        
        builder.HasKey(x => new { x.BunkerItemId, x.GameSessionId });

        builder.Property(x => x.BunkerItemId).IsRequired();
        builder.HasOne(x => x.BunkerItem)
            .WithMany()
            .HasForeignKey(x => x.BunkerItemId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.GameSessionId).IsRequired();
        builder.HasOne(x => x.GameSession)
            .WithMany()
            .HasForeignKey(x => x.GameSessionId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
