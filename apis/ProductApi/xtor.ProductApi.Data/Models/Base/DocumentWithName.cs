namespace xtor.ProductApi.Data.Models.Base;

/// <summary>
/// Базовый класс для моделей документов, у которых есть свойство Name.
/// </summary>
public abstract class DocumentWithName : BaseDocument
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;
}