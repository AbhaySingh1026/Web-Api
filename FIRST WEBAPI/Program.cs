using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FIRST_WEBAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<FIRST_WEBAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FIRST_WEBAPIContext") ?? throw new InvalidOperationException("Connection string 'FIRST_WEBAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
