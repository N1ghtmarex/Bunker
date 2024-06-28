using Bunker.Domain.Enums;

namespace Bunker.Domain.Entities;

public class Card: BaseEntity<Guid>
{
    /// <summary>
    /// Название
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; set; }
    /// <summary>
    /// Тип
    /// </summary>
    public required CardTypeEnum Type { get; set; }
}
