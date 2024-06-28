namespace Bunker.Domain.Entities;

public class ScenarioBunkerItemBind
{
    /// <summary>
    /// Идентификатор сценария
    /// </summary>
    public Guid ScenarioId { get; set; }
    public required Scenario Scenario { get; set; }
    /// <summary>
    /// Идентификатор предмета бункера
    /// </summary>
    public Guid BunkerItemId { get; set; }
    public required BunkerItem BunkerItem { get; set; }
}
