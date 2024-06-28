namespace Bunker.Domain.Entities;

public class User: BaseEntity<Guid>
{
    /// <summary>
    /// Имя пользователя
    /// </summary>
    public required string Username { get; set; }
}
