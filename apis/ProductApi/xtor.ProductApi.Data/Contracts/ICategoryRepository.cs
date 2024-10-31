using xtor.ProductApi.Data.Models;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Contracts;

/// <summary>
/// Сервис для работы с коллекцией <see cref="Category"/>.
/// </summary>
public interface ICategoryRepository : IBaseRepository<Category>
{
    
}