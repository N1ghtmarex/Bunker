using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class ScenarioDisasterBindConfiguration : IEntityTypeConfiguration<ScenarioDisasterBind>
{
    public void Configure(EntityTypeBuilder<ScenarioDisasterBind> builder)
    {
        builder.ToTable("scenario_disaster_bind");

        builder.HasKey(x => new { x.ScenarioId, x.DisasterId });

        builder.Property(x => x.ScenarioId).IsRequired();
        builder.HasOne(x => x.Scenario)
            .WithMany()
            .HasForeignKey(x => x.ScenarioId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.DisasterId).IsRequired();
        builder.HasOne(x => x.Disaster)
            .WithMany()
            .HasForeignKey(x => x.DisasterId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
