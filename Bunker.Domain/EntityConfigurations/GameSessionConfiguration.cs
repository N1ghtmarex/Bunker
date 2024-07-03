using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class GameSessionConfiguration : IEntityTypeConfiguration<GameSession>
{
    public void Configure(EntityTypeBuilder<GameSession> builder)
    {
        builder.ToTable("game_session");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.ScenarioDisasterId).IsRequired();
        builder.HasOne(x => x.ScenarioDisasterBind)
            .WithMany()
            .HasForeignKey(x => x.ScenarioDisasterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
