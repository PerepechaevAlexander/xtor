using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using xtor.ProductApi.Data.Enums;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.SpecificationTemplate;

/// <summary>
/// (Шаблон) Характеристика.
/// </summary>
public class SpecificationFieldTemplate : InnerDocumentWithName
{
    /// <summary>
    /// Тип поля.
    /// </summary>
    [BsonRepresentation(BsonType.Int32)]
    public FieldTypeEnum Type { get; set; }

    /// <summary>
    /// Id словаря, из которого берётся значение, если тип поля - <see cref="FieldTypeEnum.Dictionary"/>
    /// </summary>
    public ObjectId? DictionaryId { get; set; }
    
    /// <summary>
    /// Является ли массивом значений.
    /// </summary>
    public bool IsArray { get; set; }

    /// <summary>
    /// Обязательность поля.
    /// </summary>
    public bool IsRequired { get; set; }
}