namespace Bunker.Domain.Entities;

public class Disaster: BaseEntity<Guid>
{
    /// <summary>
    /// Название
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; set; }
}
