using API.Infra;
using API.Infra.Data;
using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region [Database]
//Desafio trocar a estrutura para um outro banco SQL Server ou Oracle
builder.Services.AddDbContext<DataContext>(
        options => options.UseNpgsql(builder.Configuration.GetSection("DatabaseSettings:ConnectionString").Value));

builder.Services.AddTransient<DataContext>();

#endregion

#region [DI]
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<NewsService>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
