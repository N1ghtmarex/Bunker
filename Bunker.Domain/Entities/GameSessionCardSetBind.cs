namespace Bunker.Domain.Entities;

public class GameSessionCardSetBind
{
    /// <summary>
    /// Идентификатор игровой сессии
    /// </summary>
    public Guid GameSessionId { get; set; }
    public required GameSession GameSession { get; set; }
    /// <summary>
    /// Идентификатор набора карточек
    /// </summary>
    public Guid CardSetId { get; set; }
    public required CardSet CardSet { get; set; }
}
