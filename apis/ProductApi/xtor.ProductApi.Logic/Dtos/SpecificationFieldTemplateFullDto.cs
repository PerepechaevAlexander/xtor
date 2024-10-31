using xtor.ProductApi.Logic.Dtos.Base;

namespace xtor.ProductApi.Logic.Dtos;

/// <summary>
/// Полное дто (шаблона) характеристики.
/// </summary>
public class SpecificationFieldTemplateFullDto : DtoWithName
{
    /// <summary>
    /// Тип поля.
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Словарь значений. // TODO скорее всего тут будет дто, а не стринга
    /// </summary>
    public string? Dictionary { get; set; }

    /// <summary>
    /// Является ли массивом значений.
    /// </summary>
    public bool IsArray { get; set; }

    /// <summary>
    /// Обязательность поля.
    /// </summary>
    public bool IsRequired { get; set; }
}