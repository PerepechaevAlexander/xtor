using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.Specification;

/// <summary>
/// Раздел характеристик.
/// </summary>
public class SpecificationSection : InnerDocumentWithName
{
    /// <summary>
    /// Характеристики в разделе.
    /// </summary>
    public IEnumerable<SpecificationField> Fields { get; set; }
}