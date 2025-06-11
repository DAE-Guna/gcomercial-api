using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Models.Shared;
using System.Linq;
using gcomercial_api.Models.GestionComercial;
using Microsoft.Data.SqlClient;
using gcomercial_api.Services.Common;
using gcomercial_api.Services.Almacen;

namespace gcomercial_api.Services
{
    public class BusquedaProductoRequest : GenericSearchRequest
    {
        // Propiedades específicas para almacenes si se necesitan
    }

    public interface IProductoService : IGenericService<BusquedaProductoRequest>
    {
        Task<PaginatedResult<Dictionary<string, object>>> BuscarProductosAsync(BusquedaProductoRequest request);
        Task<object> UpdateProductoStatusAsync(int id, UpdateStatusRequest request);
    }

    public class ProductoService : IProductoService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IQueryBuilderService _queryBuilder;
        private readonly IDatabaseService _databaseService;
        private const string MODULO = "productos";
        private const string VIEW_NAME = "Vw_Productos";
        private const string TABLE_NAME = "Productos";
        private const string ORDER_BY_COLUMN = "codigo";

        public ProductoService(
            GestionComercialDbContext context,
            IQueryBuilderService queryBuilder,
            IDatabaseService databaseService)
        {
            _context = context;
            _queryBuilder = queryBuilder;
            _databaseService = databaseService;
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarProductosAsync(BusquedaProductoRequest request)
        {
            try
            {
                if (request.Page < 1) request.Page = 1;
                if (request.PageSize < 1 || request.PageSize > 100) request.PageSize = 10;

                var camposFiltrables = await _databaseService.ObtenerCamposFiltrablesAsync(MODULO);

                var sqlInfo = _queryBuilder.BuildQuery(request, VIEW_NAME, camposFiltrables, ORDER_BY_COLUMN);

                using var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                var total = await _databaseService.EjecutarConteoAsync(connection, sqlInfo);

                var items = await _databaseService.EjecutarConsultaDatosAsync(connection, sqlInfo);

                return new PaginatedResult<Dictionary<string, object>>
                {
                    Items = items,
                    Pagination = new PaginationInfo
                    {
                        Total = total,
                        PageSize = request.PageSize,
                        CurrentPage = request.Page,
                        TotalPages = (int)Math.Ceiling((double)total / request.PageSize),
                        HasMore = total > request.Page * request.PageSize
                    }
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en BuscarAsync: {ex.Message}", ex);
            }
        }

        public async Task<object> UpdateProductoStatusAsync(int id, UpdateStatusRequest request)
        {
            return await _databaseService.UpdateStatusAsync(TABLE_NAME, id, request, "Productos");
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(BusquedaProductoRequest request)
        {
            return await BuscarProductosAsync(request);
        }

        public async Task<object> UpdateStatusAsync(int id, UpdateStatusRequest request)
        {
            return await UpdateProductoStatusAsync(id, request);
        }
    }
}