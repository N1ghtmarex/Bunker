using Bunker.Domain.Enums;

namespace Bunker.Domain.Entities;

public class Lobby: BaseEntity<Guid>
{
    /// <summary>
    /// Код подключения
    /// </summary>
    public required string Code { get; set; }
    /// <summary>
    /// Состояние
    /// </summary>
    public required LobbyStatusEnum Status { get; set; }
    /// <summary>
    /// Идентификатор игровой сессии
    /// </summary>
    public Guid GameSessionId { get; set; }
    public required GameSession GameSession { get; set; }
}
