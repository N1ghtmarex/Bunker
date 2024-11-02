using Bunker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Bunker.Domain;

// TODO: сгенерить миграцию
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<BunkerItem> BunkerItems { get; set; } = null!;
    public DbSet<Card> Cards { get; set; } = null!;
    public DbSet<CardSet> CardSets { get; set; } = null!;
    public DbSet<CardSetCardBind> CardSetCardBind { get; set; } = null!;
    public DbSet<CardSetSpecialCardBind> CardSetSpecialCardBind { get; set; } = null!;
    public DbSet<Disaster> Disasters { get; set; } = null!;
    public DbSet<Event> Events { get; set; } = null!;
    public DbSet<GameSession> GameSessions { get; set; } = null!;
    public DbSet<GameSessionBunkerItemBind> GameSessionBunkerItemBind { get; set; } = null!;
    public DbSet<GameSessionCardSetBind> GameSessionCardSetBind { get; set; } = null!;
    public DbSet<Lobby> Lobbies { get; set; } = null!;
    public DbSet<Player> Players { get; set; } = null!;
    public DbSet<PlayerCardBind> PlayerCardBind { get; set; } = null!;
    public DbSet<PlayerSpecialCardBind> PlayerSpecialCardBind { get; set; } = null!;
    public DbSet<Scenario> Scenarios { get; set; } = null!;
    public DbSet<ScenarioBunkerItemBind> ScenarioBunkerItemBind { get; set; } = null!;
    public DbSet<ScenarioCardSetBind> ScenarioCardSetBind { get; set; } = null!;
    public DbSet<ScenarioDisasterBind> ScenarioDisasterBind { get; set; } = null!;
    public DbSet<SpecialCard> SpecialCards { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;

    // TODO: можно добавить методы для автоматического обновления полей трекинга даты
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).GetTypeInfo().Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSnakeCaseNamingConvention();
    }
}
