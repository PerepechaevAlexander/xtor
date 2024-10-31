using xtor.ProductApi.Logic.Dtos.Base;

namespace xtor.ProductApi.Logic.Dtos;

/// <summary>
/// Полное дто (шаблона) раздела характеристик.
/// </summary>
public class SpecificationSectionTemplateFullDto : DtoWithName
{
    /// <summary>
    /// Шаблоны характеристик в разделе.
    /// </summary>
    public IEnumerable<SpecificationFieldTemplateFullDto> FieldTemplates { get; set; }
}