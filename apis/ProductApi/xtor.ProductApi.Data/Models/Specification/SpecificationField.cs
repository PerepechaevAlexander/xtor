using MongoDB.Bson;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.Specification;

/// <summary>
/// Характеристика.
/// </summary>
public class SpecificationField : InnerDocumentWithName
{
    /// <summary>
    /// Значение характеристики.
    /// </summary>
    public BsonValue Value { get; set; }
}