using System.Configuration;
using backend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using backend.Interfaces;
using backend.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDBContext>(options =>{

    var connectionString = builder.Configuration.GetConnectionString("MySqlConnection");
    if (string.IsNullOrEmpty(connectionString))
    {
        throw new ArgumentNullException("MySQL connnection string is missing!");
    }
    options.UseMySQL(connectionString);
});

builder.Services.AddScoped<IUserRepository, UserRepository>();

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
