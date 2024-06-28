namespace Bunker.Domain.Entities;

public class CardSet: BaseEntity<Guid>
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
    public required string Type { get; set; }
}
