using System.ComponentModel;

namespace Bunker.Domain.Enums;

/// <summary>
/// Тип карточки
/// </summary>
public enum CardTypeEnum
{
    /// <summary>
    /// Здоровье
    /// </summary>
    [Description("Здоровье")]
    Health = 0,

    /// <summary>
    /// Телосложение
    /// </summary>
    [Description("Телосложение")]
    Body = 1,

    /// <summary>
    /// Профессия
    /// </summary>
    [Description("Профессия")]
    Profession = 2,

    /// <summary>
    /// Хобби
    /// </summary>
    [Description("Хобби")]
    Hobby = 3,

    /// <summary>
    /// Человеческая черта
    /// </summary>
    [Description("Человеческая черта")]
    HumanTrait = 4,

    /// <summary>
    /// Фобия
    /// </summary>
    [Description("Фобия")]
    Phobia = 5,

    /// <summary>
    /// Дополнительная информация
    /// </summary>
    [Description("Дополнительная информация")]
    Additional = 6
}
