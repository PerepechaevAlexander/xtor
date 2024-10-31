using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace xtor.ProductApi.Data.Models.Base;

/// <summary>
/// Базовый класс для моделей документов из бд.
/// </summary>
public abstract class BaseDocument
{
    /// <summary>
    /// Идентификатор объекта.
    /// </summary>
    [BsonId]
    public ObjectId Id { get; set; }
}