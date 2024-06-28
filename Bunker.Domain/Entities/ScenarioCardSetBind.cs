namespace Bunker.Domain.Entities;

public class ScenarioCardSetBind
{
    /// <summary>
    /// Идентификатор сценария
    /// </summary>
    public Guid ScenarioId { get; set; }
    public required Scenario Scenario { get; set; }
    /// <summary>
    /// Идетификатор набора карточек
    /// </summary>
    public Guid CardSetId { get; set; }
    public required CardSet CardSet { get; set; }
}
