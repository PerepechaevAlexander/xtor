namespace xtor.ProductApi.Logic.Dtos.Base;

/// <summary>
/// Дто, у которой есть свойство Name.
/// </summary>
public class DtoWithName : BaseDto
{
    /// <summary>
    /// Наименование.
    /// </summary>
    public string Name { get; set; } = null!;
}