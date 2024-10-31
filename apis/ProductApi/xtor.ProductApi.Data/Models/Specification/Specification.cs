using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Models.Specification;

/// <summary>
/// Характеристики товара.
/// </summary>
public class Specification : BaseDocument
{
    /// <summary>
    /// Характеристики из общего раздела.
    /// </summary>
    public IEnumerable<SpecificationField> Fields { get; set; }
    
    /// <summary>
    /// Разделы характеристик.
    /// </summary>
    public IEnumerable<SpecificationSection> Sections { get; set; }
}