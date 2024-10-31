using MongoDB.Bson;
using MongoDB.Driver;
using xtor.ProductApi.Data.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// определяем IMongoDatabase как синглтон TODO мб всё же не синглтон юзать, пугает он меня
builder.Services.AddSingleton(
    new MongoClient(builder.Configuration.GetConnectionString("Mongo"))
        .GetDatabase(builder.Configuration.GetConnectionString("Database")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", async (IMongoDatabase db) =>     // получаем MongoClient через DI
{
    // var db = client.GetDatabase("test");    // обращаемся к базе данных
    var collection = db.GetCollection<Product>("телефоны"); // получаем коллекцию users
    // для теста добавляем начальные данные, если коллекция пуста
    if (await collection.CountDocumentsAsync("{}") == 0)
    {
        await collection.InsertManyAsync(new List<Product>
        {
            new()
            {
                Id = ObjectId.GenerateNewId(),
                Name = "Phone 13"
            },
            new()
            {
                Id = ObjectId.GenerateNewId(),
                Name = "Phone 13 mini"
            }
        });
    }
    var phones =  await collection.Find("{}").ToListAsync();
    return phones.ToJson();  // отправляем клиенту все документы из коллекции
});

app.Run();