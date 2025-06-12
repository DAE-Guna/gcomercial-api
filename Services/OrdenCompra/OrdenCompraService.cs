using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using gcomercial_api.Services.Common;
using gcomercial_api.Services.Existencias;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;

namespace gcomercial_api.Services.OrdenCompra
{
    public class BusquedaOrdenCompraRequest : GenericSearchRequest
    {
        // Propiedades específicas para almacenes si se necesitan
    }

    public interface IOrdenCompraService : IGenericService<BusquedaOrdenCompraRequest>
    {
        Task<PaginatedResult<Dictionary<string, object>>> BuscarOrdenCompraAsync(BusquedaOrdenCompraRequest request);
    }
    public class OrdenCompraService : IOrdenCompraService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IQueryBuilderService _queryBuilder;
        private readonly IDatabaseService _databaseService;
        private const string MODULO = "odrenCompras";
        private const string VIEW_NAME = "Vw_Productos";
        private const string TABLE_NAME = "Productos";
        private const string ORDER_BY_COLUMN = "codigo";

        public OrdenCompraService(
            GestionComercialDbContext context,
            IQueryBuilderService queryBuilder,
            IDatabaseService databaseService)
        {
            _context = context;
            _queryBuilder = queryBuilder;
            _databaseService = databaseService;
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarOrdenCompraAsync(BusquedaOrdenCompraRequest request)
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
                        TotalPages = (int)Math.Ceiling((double)Convert.ToInt32(totales.First().Values.First()) / request.PageSize),
                        HasMore = Convert.ToInt32(totales.First().Values.First()) > request.Page * request.PageSize
                    }
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en BuscarAsync: {ex.Message}", ex);
            }
        }
        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(BusquedaOrdenCompraRequest request)
        {
            return await BuscarOrdenCompraAsync(request);
        }

        Task<object> IGenericService<BusquedaOrdenCompraRequest>.UpdateStatusAsync(int id, UpdateStatusRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
