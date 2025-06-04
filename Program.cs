using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Services;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers();


builder.Services.AddDbContext<GeneralDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GeneralConnection")));

builder.Services.AddDbContext<PachucaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PachucaConnection")));

builder.Services.AddDbContext<CuernavacaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CuernavacaConnection")));

builder.Services.AddDbContext<GestionComercialDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("GestionComercialConnection")));


builder.Services.AddScoped<IAlmacenService, AlmacenService>();
builder.Services.AddScoped<IProductoService, ProductoService>();
builder.Services.AddScoped<IProveedorService, ProveedorService>();


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
