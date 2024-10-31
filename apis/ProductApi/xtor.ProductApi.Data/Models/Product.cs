using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models;

/// <summary>
/// Товар.
/// </summary>
public class Product : DocumentWithName
{
    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// Стоимость.
    /// </summary>
    public double Cost { get; set; }

    /// <summary>
    /// Количество в наличии.
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// Скидка на товар, default = 0.
    /// </summary>
    public double Discount { get; set; } = 0;

    /// <summary>
    /// Id производителя.
    /// </summary>
    public int ManufacturerId { get; set; }
    
    /// <summary>
    /// Id категории.
    /// </summary>
    [BsonId]
    public ObjectId CategoryId { get; set; }

    /// <summary>
    /// Id характеристик.
    /// </summary>
    [BsonId]
    public ObjectId SpecificationId { get; set; }
}