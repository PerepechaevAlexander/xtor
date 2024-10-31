using MongoDB.Bson;
using MongoDB.Driver;
using xtor.ProductApi.Data.Contracts;
using xtor.ProductApi.Data.Enums;
using xtor.ProductApi.Data.Models;

namespace xtor.ProductApi.Data.Repositories;

/// <inheritdoc/>
public class CategoryRepository : ICategoryRepository
{
    public CategoryRepository(IMongoDatabase database)
    {
        Categories = database.GetCollection<Category>(CollectionNameEnum.CATEGORY);
    }

    public IMongoCollection<Category> Categories { get; set; }


    /// <inheritdoc/>
    public Category Add(Category entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Category Update(Category entity)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public void Delete(ObjectId id)
    {
        throw new NotImplementedException();
    }
}