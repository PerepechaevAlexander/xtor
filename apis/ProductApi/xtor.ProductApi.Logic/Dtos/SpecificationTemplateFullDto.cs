using xtor.ProductApi.Logic.Dtos.Base;

namespace xtor.ProductApi.Logic.Dtos;

/// <summary>
/// Полное дто (шаблона) раздела характеристик.
/// </summary>
public class SpecificationTemplateFullDto : DtoWithName
{
    /// <summary>
    /// Шаблоны характеристик из общего раздела.
    /// </summary>
    public IEnumerable<SpecificationFieldTemplateFullDto> FieldTemplates { get; set; }

    /// <summary>
    /// Шаблоны разделов характеристик.
    /// </summary>
    public IEnumerable<SpecificationSectionTemplateFullDto> SectionTemplates { get; set; }
}