using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.ToTable("player");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.UserId).IsRequired();
        builder.HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.LobbyId).IsRequired();
        builder.HasOne(x => x.Lobby)
            .WithMany()
            .HasForeignKey(x => x.LobbyId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.Age).IsRequired();
        builder.Property(x => x.Gender).IsRequired();
        builder.Property(x => x.Orientation).IsRequired();
    }
}
