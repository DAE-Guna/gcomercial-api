using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using gcomercial_api.Services.Almacen;
using gcomercial_api.Services.Common;
using Microsoft.EntityFrameworkCore;

namespace gcomercial_api.Services.Existencias
{
    public class BusquedaExistenciaRequest : GenericSearchRequest
    {
        // Propiedades específicas para almacenes si se necesitan
    }

    public interface IExistenciaService : IGenericService<BusquedaExistenciaRequest>
    {
        Task<PaginatedResult<Dictionary<string, object>>> BuscarExistenciasAsync(BusquedaExistenciaRequest request);
    }
    public class ExistenciasService : IExistenciaService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IQueryBuilderService _queryBuilder;
        private readonly IDatabaseService _databaseService;
        private const string MODULO = "existencias";
        private const string VIEW_NAME = "Vw_Existencias";
        private const string TABLE_NAME = "Existencias";
        private const string ORDER_BY_COLUMN = "codigo";

        public ExistenciasService(
            GestionComercialDbContext context,
            IQueryBuilderService queryBuilder,
            IDatabaseService databaseService)
        {
            _context = context;
            _queryBuilder = queryBuilder;
            _databaseService = databaseService;
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarExistenciasAsync(BusquedaExistenciaRequest request)
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
        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(BusquedaExistenciaRequest request)
        {
            return await BuscarExistenciasAsync(request);
        }

        Task<object> IGenericService<BusquedaExistenciaRequest>.UpdateStatusAsync(int id, UpdateStatusRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
