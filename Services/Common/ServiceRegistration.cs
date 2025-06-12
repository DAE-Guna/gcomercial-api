using gcomercial_api.Services.Almacen;
using gcomercial_api.Services.Filtros;
using Microsoft.Extensions.DependencyInjection;
using gcomercial_api.Services;
using gcomercial_api.Services.Existencias;
using gcomercial_api.Services.OrdenCompra;
using gcomercial_api.Services.Compras;

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
            services.AddScoped<IExistenciaService, ExistenciasService>();
            services.AddScoped<IOrdenCompraService, OrdenCompraService>();
            services.AddScoped<ICompraService, ComprasService>();

            return services;
        }
    }
}
