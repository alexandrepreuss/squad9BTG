using Microsoft.EntityFrameworkCore;
using Squad9.Client.API.Application;
using Squad9.Client.API.Application.Contracts;
using Squad9.Client.API.AppService;
using Squad9.Client.API.AppService.Contracts;
using Squad9.Client.API.Infra.Contracts;
using Squad9.Client.API.Infra.Factories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IClientAplication, ClientAplication>();
builder.Services.AddSingleton<IClientAppService, ClientAppService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();
