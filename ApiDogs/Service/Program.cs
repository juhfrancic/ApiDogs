using ApiDogs.Data;
using ApiDogs.Repositories;
using ApiDogs.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddHttpClient<DogsService>(client => client.BaseAddress = new Uri("https://dogapi.dog/api/v2/breeds/"));

builder.Services.AddSingleton<ConnectionDB>();
builder.Services.AddSingleton<DogsRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
