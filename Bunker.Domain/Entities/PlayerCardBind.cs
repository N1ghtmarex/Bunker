namespace Bunker.Domain.Entities;

public class PlayerCardBind
{
    /// <summary>
    /// Идентификатор игрока
    /// </summary>
    public Guid PlayerId { get; set; }
    public required Player Player { get; set; }
    /// <summary>
    /// Идентификатор карточки
    /// </summary>
    public Guid CardId { get; set; }
    public required Card Card { get; set; }
    /// <summary>
    /// Известно ли другим игрокам?
    /// </summary>
    public required bool IsKnown { get; set; }
}
