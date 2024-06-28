namespace Bunker.Domain.Entities;

public class Event: BaseEntity<Guid>
{
    /// <summary>
    /// Идентификатор игрока
    /// </summary>
    public Guid PlayerId { get; set; }
    public required Player Player { get; set; }
    /// <summary>
    /// Идентификатор игровой сессии
    /// </summary>
    public Guid GameSessionId { get; set; }
    public required GameSession GameSession { get; set; }
    /// <summary>
    /// Тип
    /// </summary>
    public required string Type { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; set; }
    /// <summary>
    /// Карточка игрока
    /// </summary>
    public Guid? PlayerCardId { get; set; }
    public PlayerCardBind? PlayerCardBind { get; set; }
    /// <summary>
    /// Специальная карточка игрока
    /// </summary>
    public Guid? PlayerSpecialCardId { get; set; }
    public PlayerSpecialCardBind? PlayerSpecialCardBind { get; set; }
}
