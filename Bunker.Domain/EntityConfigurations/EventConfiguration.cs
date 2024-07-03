using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bunker.Domain.EntityConfigurations;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("event");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();

        builder.Property(x => x.PlayerId).IsRequired();
        builder.HasOne(x => x.Player)
            .WithMany()
            .HasForeignKey(x => x.PlayerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.GameSessionId).IsRequired();
        builder.HasOne(x => x.GameSession)
            .WithMany()
            .HasForeignKey(x => x.GameSessionId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(x => x.Type).IsRequired();
        builder.Property(x => x.Description).IsRequired();

        builder.HasOne(x => x.PlayerCardBind)
            .WithMany()
            .HasForeignKey(x => x.PlayerCardId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(x => x.PlayerSpecialCardBind)
            .WithMany()
            .HasForeignKey(x => x.PlayerSpecialCardId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
