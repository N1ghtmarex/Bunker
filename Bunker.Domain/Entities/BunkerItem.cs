using Bunker.Domain.Enums;

namespace Bunker.Domain.Entities;

public class BunkerItem: BaseEntity<Guid>
{
    /// <summary>
    /// Название
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Состояние
    /// </summary>
    public required ItemStatusEnum Status { get; set; }
}
