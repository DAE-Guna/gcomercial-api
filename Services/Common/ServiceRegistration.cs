using gcomercial_api.Services.Almacen;
using gcomercial_api.Services.Filtros;
using Microsoft.Extensions.DependencyInjection;
using gcomercial_api.Services;

namespace gcomercial_api.Services.Common
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddCommonServices(this IServiceCollection services)
        {
            services.AddScoped<IQueryBuilderService, QueryBuilderService>();
            services.AddScoped<IDatabaseService, DatabaseService>();
            
            services.AddScoped<IAlmacenService, AlmacenService>();
            services.AddScoped<IProductoService, ProductoService>();
            services.AddScoped<IProveedorService, ProveedorService>();
            services.AddScoped<IFiltrosService, FiltrosService>();
            
            return services;
        }
    }
}
