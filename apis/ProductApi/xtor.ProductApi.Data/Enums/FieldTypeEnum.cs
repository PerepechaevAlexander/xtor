namespace xtor.ProductApi.Data.Enums;

/// <summary>
/// Перечисление типов полей.
/// </summary>
public enum FieldTypeEnum
{
    Int = 0,
    Double = 1,
    String = 2,
    Boolean = 3,
    
    /// <summary>
    /// Словарь. То есть выбор значения из заранее определённого списка.
    /// </summary>
    Dictionary = 4
}