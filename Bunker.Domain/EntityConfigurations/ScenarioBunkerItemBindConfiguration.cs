using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class ScenarioBunkerItemBindConfiguration : IEntityTypeConfiguration<ScenarioBunkerItemBind>
{
    public void Configure(EntityTypeBuilder<ScenarioBunkerItemBind> builder)
    {
        builder.ToTable("scenario_bunker_item_bind");

        builder.HasKey(x => new { x.ScenarioId, x.BunkerItemId });

        builder.Property(x => x.ScenarioId).IsRequired();
        builder.HasOne(x => x.Scenario)
            .WithMany()
            .HasForeignKey(x => x.ScenarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.BunkerItemId).IsRequired();
        builder.HasOne(x => x.BunkerItem)
            .WithMany()
            .HasForeignKey(x => x.BunkerItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
