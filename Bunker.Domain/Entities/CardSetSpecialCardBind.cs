namespace Bunker.Domain.Entities;

public class CardSetSpecialCardBind
{
    /// <summary>
    /// Идентификатор набора карточек
    /// </summary>
    public Guid CardSetId { get; set; }
    public required CardSet CardSet { get; set; }
    /// <summary>
    /// Идентификатор специальной карточки
    /// </summary>
    public Guid SpecialCardId { get; set; }
    public required SpecialCard SpecialCard { get; set; }
}
