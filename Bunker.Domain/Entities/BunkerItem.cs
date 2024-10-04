using Bunker.Domain.Enums;

namespace Bunker.Domain.Entities;

// TODO: В эту и другие сущности полезно добавить интерфейс IHasArchiveAttribute архивности (помтека на удаление) и интерфейс IHasTrackDateAttribute для историчности данных - когда добавили запись и когда удалили.
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
