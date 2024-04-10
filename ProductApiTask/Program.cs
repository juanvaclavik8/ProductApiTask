using ProductApiTask.DataAccessLayer;
using ProductApiTask.Logging;
using ProductApiTask.ServiceLayer;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ILogging, Logging>();
builder.Services.AddSingleton<IDataAccess, DataAccess>();
builder.Services.AddSingleton<IService, ProductService>( s =>
        new ProductService(s.GetRequiredService<IDataAccess>(),
        s.GetRequiredService<ILogging>()
        )
    );


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
