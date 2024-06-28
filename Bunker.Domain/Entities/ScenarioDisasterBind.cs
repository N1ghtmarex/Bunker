namespace Bunker.Domain.Entities;

public class ScenarioDisasterBind
{
    /// <summary>
    /// Идентификатор сценария
    /// </summary>
    public Guid ScenarioId { get; set; }
    public required Scenario Scenario { get; set; }
    /// <summary>
    /// Идентификатор катастрофы
    /// </summary>
    public Guid DisasterId { get; set; }
    public required Disaster Disaster { get; set; }
}
