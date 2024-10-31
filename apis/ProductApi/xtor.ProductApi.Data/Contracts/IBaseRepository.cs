using MongoDB.Bson;
using xtor.ProductApi.Data.Models.Base;

namespace xtor.ProductApi.Data.Contracts;

/// <summary>
/// Базовый сервис для работы с моделями документов из бд.
/// </summary>
/// <typeparam name="T"><see cref="BaseDocument"/></typeparam>
public interface IBaseRepository<T> where T : BaseDocument
{
    /// <summary>
    /// Добавить документ в коллекцию.
    /// </summary>
    /// <param name="entity">Новый документ.</param>
    /// <returns>Модель созданного документа.</returns>
    T Add(T entity);
    
    /// <summary>
    /// Обновить документ в коллекции.
    /// </summary>
    /// <param name="entity">Обновлённый документ.</param>
    /// <returns>Модель созданного документа.</returns>
    T Update(T entity);

    /// <summary>
    /// Удалить документ из коллекции.
    /// </summary>
    /// <param name="id">Id удаляемого документа.</param>
    void Delete(ObjectId id);
}