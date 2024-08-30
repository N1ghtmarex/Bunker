namespace Bunker.Domain.Entities;

public class GameSession: BaseEntity<Guid>
{
    // TODO: как-будто недоделанный класс
    /// <summary>
    /// Идентификатор катастрофы из сценария
    /// </summary>
    public Guid ScenarioDisasterId { get; set; }
    public required ScenarioDisasterBind ScenarioDisasterBind { get; set; }
}
