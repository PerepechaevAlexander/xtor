using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models;

/// <summary>
/// Категория товара.
/// </summary>
public class Category : DocumentWithName
{
    /// <summary>
    /// Наименование коллекции в бд.
    /// </summary>
    public string CollectionName { get; set; } = null!;
    
    /// <summary>
    /// Id шаблона характеристик.
    /// </summary>
    [BsonId]
    public ObjectId SpecificationsTemplateId { get; set; }
}