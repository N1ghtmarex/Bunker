namespace Bunker.Domain.Entities;

public class SpecialCard: BaseEntity<Guid>
{
    /// <summary>
    /// Базовое действие
    /// </summary>
    public required string BaseAction { get; set; }
    /// <summary>
    /// Название
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public required string Description { get; set; }
    /// <summary>
    /// Выполняемый скрипт
    /// </summary>
    public required string Script { get; set; }
}
