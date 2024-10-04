namespace Bunker.Domain.Entities;

public class CardSetCardBind
{
    /// <summary>
    /// Идентификатор набора карточек
    /// </summary>
    public Guid CardSetId { get; set; }

    // TODO: Зря помечаешь объекты как required. Представим ситуацию: Карта и Набор карт уже созданы, ты хочешь их связать. Атрибут required обязывает задать значение свойству. Соответственно тебе придется при создании связки передавать сюда объекты карт и наборов, что не очень удобно (гораздо удобнее просто передать id).
    public required CardSet CardSet { get; set; }
    /// <summary>
    /// Идентификатор карточки
    /// </summary>
    public Guid CardId { get; set; }
    public required Card Card { get; set; }
}
