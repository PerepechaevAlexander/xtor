using MongoDB.Bson;
using MongoDB.Driver;
using xtor.ProductApi.Data.Contracts;
using xtor.ProductApi.Data.Enums;
using xtor.ProductApi.Data.Models;
using xtor.ProductApi.Data.Models.SpecificationTemplate;

namespace xtor.ProductApi.Data;

/// <summary>
/// Сервис для работы с бд. // TODO нахер он мне нужен вообще?
/// </summary>
public class DbContext : IDbContext
{
    private readonly IMongoCollection<Product> _products;
    private readonly IMongoCollection<Category> _categories;
    private readonly IMongoCollection<SpecificationTemplate> _templates;

    public DbContext(IMongoDatabase database)
    {
        _products = database.GetCollection<Product>(CollectionNameEnum.PRODUCT);
        _categories = database.GetCollection<Category>(CollectionNameEnum.CATEGORY);
        _templates = database.GetCollection<SpecificationTemplate>(CollectionNameEnum.SPECIFICATION_TEMPLATE);
    }

    public async Task<List<Product>> GetProductsByCategoryAsync(ObjectId categoryId)
    {
        var filter = Builders<Product>.Filter.Eq(p => p.CategoryId, categoryId);
        
        return await _products.Find(filter).ToListAsync();
    }
}