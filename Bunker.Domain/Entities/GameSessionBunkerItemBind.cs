namespace Bunker.Domain.Entities;

public class GameSessionBunkerItemBind
{
    /// <summary>
    /// Идентификатор предмета бункера
    /// </summary>
    public Guid BunkerItemId { get; set; }
    public required BunkerItem BunkerItem { get; set; }
    /// <summary>
    /// Идентификатор игровой сессии
    /// </summary>
    public Guid GameSessionId { get; set; }
    public required GameSession GameSession { get; set; }
    /// <summary>
    /// Количество
    /// </summary>
    public required int Count { get; set; }
    /// <summary>
    /// Состояние
    /// </summary>
    public required string Status { get; set; }
}
