using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.SpecificationTemplate;

/// <summary>
/// (Шаблон) Раздел характеристик.
/// </summary>
public class SpecificationSectionTemplate : InnerDocumentWithName
{
    /// <summary>
    /// Шаблоны характеристик в разделе.
    /// </summary>
    public IEnumerable<SpecificationFieldTemplate> FieldTemplates { get; set; }
}