using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class ScenarioCardSetBindConfiguration : IEntityTypeConfiguration<ScenarioCardSetBind>
{
    public void Configure(EntityTypeBuilder<ScenarioCardSetBind> builder)
    {
        builder.ToTable("scenario_card_set_bind");

        builder.HasKey(x => new { x.ScenarioId, x.CardSetId });

        builder.Property(x => x.ScenarioId).IsRequired();
        builder.HasOne(x => x.Scenario)
            .WithMany()
            .HasForeignKey(x => x.ScenarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.CardSetId).IsRequired();
        builder.HasOne(x => x.CardSet)
            .WithMany()
            .HasForeignKey(x => x.CardSetId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
