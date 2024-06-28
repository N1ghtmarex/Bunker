namespace Bunker.Domain.Entities;

public class CardSetCardBind
{
    /// <summary>
    /// Идентификатор набора карточек
    /// </summary>
    public Guid CardSetId { get; set; }
    public required CardSet CardSet { get; set; }
    /// <summary>
    /// Идентификатор карточки
    /// </summary>
    public Guid CardId { get; set; }
    public required Card Card { get; set; }
}
