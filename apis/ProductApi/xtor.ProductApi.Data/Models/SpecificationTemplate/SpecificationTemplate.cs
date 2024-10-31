using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.SpecificationTemplate;

/// <summary>
/// (Шаблон) Характеристики товара.
/// </summary>
public class SpecificationTemplate : DocumentWithName
{
    /// <summary>
    /// Шаблоны характеристик из общего раздела.
    /// </summary>
    public IEnumerable<SpecificationFieldTemplate> FieldTemplates { get; set; }

    /// <summary>
    /// Шаблоны разделов характеристик.
    /// </summary>
    public IEnumerable<SpecificationSectionTemplate> SectionTemplates { get; set; }
}