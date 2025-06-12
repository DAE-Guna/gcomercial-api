using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Models.Shared;
using gcomercial_api.Services;
using gcomercial_api.Services.Common;

namespace gcomercial_api.Services
{
    public class BusquedaProveedorRequest : GenericSearchRequest
    {
        // Propiedades específicas para almacenes si se necesitan
    }

    public interface IProveedorService : IGenericService<BusquedaProveedorRequest>
    {
        Task<PaginatedResult<Dictionary<string, object>>> BuscarProveedorAsync(BusquedaProveedorRequest request);
        Task<object> UpdateProveedorStatusAsync(int id, UpdateStatusRequest request);
    }

    public class ProveedorService : IProveedorService
    {

        private readonly GestionComercialDbContext _context;
        private readonly IQueryBuilderService _queryBuilder;
        private readonly IDatabaseService _databaseService;
        private const string MODULO = "proveedores";
        private const string VIEW_NAME = "VW_Proveedores";
        private const string TABLE_NAME = "Proveedores";
        private const string ORDER_BY_COLUMN = "id";

        public ProveedorService(
            GestionComercialDbContext context,
            IQueryBuilderService queryBuilder,
            IDatabaseService databaseService)
        {
            _context = context;
            _queryBuilder = queryBuilder;
            _databaseService = databaseService;
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarProveedorAsync(BusquedaProveedorRequest request)
        {
            try
            {
                if (request.Page < 1) request.Page = 1;
                if (request.PageSize < 1 || request.PageSize > 100) request.PageSize = 10;

                var camposFiltrables = await _databaseService.ObtenerCamposFiltrablesAsync(MODULO);

                var camposConsulta = await _databaseService.ObtenerCamposConsultaAsync(MODULO);

                var sqlInfo = _queryBuilder.BuildQuery(request, VIEW_NAME, camposFiltrables, camposConsulta, ORDER_BY_COLUMN);

                using var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                var totales = await _databaseService.EjecutarConsultaMultipleAsync(connection, sqlInfo);

                var items = await _databaseService.EjecutarConsultaDatosAsync(connection, sqlInfo);

                return new PaginatedResult<Dictionary<string, object>>
                {
                    Items = items,
                    Pagination = new PaginationInfo
                    {
                        Totales = totales,
                        PageSize = request.PageSize,
                        CurrentPage = request.Page,
                        TotalPages = (int)Math.Ceiling((double)Convert.ToInt32(totales.First()["total"]) / request.PageSize),
                        HasMore = Convert.ToInt32(totales.First()["total"]) > request.Page * request.PageSize
                    }
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en BuscarAsync: {ex.Message}", ex);
            }
        }

        public async Task<object> UpdateProveedorStatusAsync(int id, UpdateStatusRequest request)
        {
            return await _databaseService.UpdateStatusAsync(TABLE_NAME, id, request, "Proveedor");
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(BusquedaProveedorRequest request)
        {
            return await BuscarProveedorAsync(request);
        }

        public async Task<object> UpdateStatusAsync(int id, UpdateStatusRequest request)
        {
            return await UpdateProveedorStatusAsync(id, request);
        }
    
    }
}
