using System.ComponentModel;

namespace Bunker.Domain.Enums;

public enum LobbyStatusEnum
{
    /// <summary>
    /// Ожидание игроков
    /// </summary>
    [Description("Ожидание")]
    Waiting = 0,

    /// <summary>
    /// В игре
    /// </summary>
    [Description("В игре")]
    InGame = 1,

    /// <summary>
    /// Игра закончилась, в лобби нет игроков
    /// </summary>
    [Description("Закончено")]
    Exited = 2
}
