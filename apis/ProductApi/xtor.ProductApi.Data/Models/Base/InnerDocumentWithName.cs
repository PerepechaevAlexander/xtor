namespace xtor.ProductApi.Data.Models.Base;

/// <summary>
/// Базовый класс для вложенных в документы объектов, у которых есть свойство Name.
/// </summary>
public abstract class InnerDocumentWithName : BaseInnerDocument
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;
}