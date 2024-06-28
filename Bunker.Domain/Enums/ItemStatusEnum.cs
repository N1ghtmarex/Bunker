using System.ComponentModel;

namespace Bunker.Domain.Enums;

/// <summary>
/// Состояние предмета
/// </summary>
public enum ItemStatusEnum
{
    /// <summary>
    /// Неисправно
    /// </summary>
    [Description("Неисправно")]
    Defective = 0,

    /// <summary>
    /// Нормальное
    /// </summary>
    [Description("Нормальное")]
    Normal = 1,

    /// <summary>
    /// Отличное
    /// </summary>
    [Description("Отличное")]
    Excellent = 2
}
