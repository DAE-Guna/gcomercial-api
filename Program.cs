using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Services;
using gcomercial_api.Services.Filtros;
using gcomercial_api.Services.Almacen;
using gcomercial_api.Services.Common;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMemoryCache();


builder.Services.AddDbContext<GeneralDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GeneralConnection")));

builder.Services.AddDbContext<PachucaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PachucaConnection")));

builder.Services.AddDbContext<CuernavacaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CuernavacaConnection")));

builder.Services.AddDbContext<GestionComercialDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GestionComercialConnection")));

builder.Services.AddCommonServices();




// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(p => p.AddDefaultPolicy(
    policy =>
    {
        policy
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    })
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
