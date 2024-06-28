namespace Bunker.Domain.Entities;

public class PlayerSpecialCardBind
{
    /// <summary>
    /// Идентификатор игрока
    /// </summary>
    public Guid PlayerId { get; set; }
    public required Player Player { get; set; }
    /// <summary>
    /// Идентификатор специальной карточки
    /// </summary>
    public Guid SpecialCardId { get; set; }
    public required SpecialCard SpecialCard { get; set; }
    /// <summary>
    /// Использовано?
    /// </summary>
    public required bool IsUsed { get; set; }
}
