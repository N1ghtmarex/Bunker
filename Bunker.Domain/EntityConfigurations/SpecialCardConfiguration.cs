using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class SpecialCardConfiguration : IEntityTypeConfiguration<SpecialCard>
{
    public void Configure(EntityTypeBuilder<SpecialCard> builder)
    {
        builder.ToTable("special_card");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.BaseAction).IsRequired();
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Description).IsRequired();
        builder.Property(x => x.Script).IsRequired();
    }
}
