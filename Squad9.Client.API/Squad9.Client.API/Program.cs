using Microsoft.EntityFrameworkCore;
using Squad9.Client.API.Application;
using Squad9.Client.API.Application.Contracts;
using Squad9.Client.API.AppService;
using Squad9.Client.API.AppService.Contracts;
using Squad9.Client.API.Infra.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSingleton<IClientAplication, ClientAplication>();
builder.Services.AddSingleton<IClientAppService, ClientAppService>();
builder.Services.AddDbContext<ClientContext>
    (options => options.UseSqlServer(
        "Data Source=squad9sqserver.cvpksv55zfzp.us-east-1.rds.amazonaws.com; Initial Catalog=Cliente; Integrated Security=False; User ID=admin; Password=squad9DB; Connect Timeout=15; Encrypt=False; TrustServerCertificate=False"));

builder.Services.AddSwaggerGen();

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
