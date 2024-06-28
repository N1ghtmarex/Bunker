namespace Bunker.Domain.Entities;

public class Player: BaseEntity<Guid>
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    public required User User { get; set; }
    /// <summary>
    /// Идентификатор лобби
    /// </summary>
    public Guid LobbyId { get; set; }
    public required Lobby Lobby { get; set; }
    /// <summary>
    /// Возраст
    /// </summary>
    public required int Age { get; set; }
    /// <summary>
    /// Пол
    /// </summary>
    public required string Gender { get; set; }
    /// <summary>
    /// Ориентация
    /// </summary>
    public required string Orientation { get; set; }
}
