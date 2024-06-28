namespace Bunker.Domain.Entities;

public class Scenario: BaseEntity<Guid>
{
    /// <summary>
    /// Название
    /// </summary>
    public required string Name { get; set; }
}
