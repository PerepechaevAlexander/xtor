using xtor.ProductApi.Logic.Dtos.Base;

namespace xtor.ProductApi.Logic.Dtos;

/// <summary>
/// Полное дто категории товара.
/// </summary>
public class CategoryFullDto : DtoWithName
{
    /// <summary>
    /// Шаблон характеристик
    /// </summary>
    public SpecificationTemplateFullDto Specification { get; set; }
}