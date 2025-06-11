using gcomercial_api.Context;
using gcomercial_api.Models.GestionComercial.DTO;
using gcomercial_api.Models.Shared;
using gcomercial_api.Services.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System.Data.Common;

namespace gcomercial_api.Services.Almacen
{
    // DTOs específicos para búsqueda de almacenes
    public class BusquedaAlmacenesRequest : GenericSearchRequest
    {
        // Propiedades específicas para almacenes si se necesitan
    }

    public interface IAlmacenService : IGenericService<BusquedaAlmacenesRequest>
    {
        // Métodos específicos para almacenes si se necesitan
        Task<PaginatedResult<Dictionary<string, object>>> BuscarAlmacenesAsync(BusquedaAlmacenesRequest request);
        Task<object> UpdateAlmacenStatusAsync(int id, UpdateStatusRequest request);
    }

    // Servicio para almacenes que usa los componentes genéricos
    public class AlmacenService : IAlmacenService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IQueryBuilderService _queryBuilder;
        private readonly IDatabaseService _databaseService;
        private readonly ILogger<AlmacenService> _logger;
        private const string MODULO = "almacenes";
        private const string VIEW_NAME = "VwAlmacenes";
        private const string TABLE_NAME = "Almacenes";
        private const string ORDER_BY_COLUMN = "codigo";

        public AlmacenService(
            GestionComercialDbContext context,
            IQueryBuilderService queryBuilder,
            IDatabaseService databaseService,
            ILogger<AlmacenService> logger)
        {
            _context = context;
            _queryBuilder = queryBuilder;
            _databaseService = databaseService;
            _logger = logger;
        }

        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAlmacenesAsync(BusquedaAlmacenesRequest request)
        {
            try
            {
                // Validar parámetros
                if (request.Page < 1) request.Page = 1;
                if (request.PageSize < 1 || request.PageSize > 100) request.PageSize = 10;

                // Obtener campos filtrables usando el servicio genérico
                var camposFiltrables = await _databaseService.ObtenerCamposFiltrablesAsync(MODULO);

                // Construir query dinámico usando el servicio genérico
                var sqlInfo = _queryBuilder.BuildQuery(request, VIEW_NAME, camposFiltrables, ORDER_BY_COLUMN);

                // Ejecutar usando la conexión del contexto
                using var connection = _context.Database.GetDbConnection();
                await connection.OpenAsync();

                // Contar total con query dinámico
                var total = await _databaseService.EjecutarConteoAsync(connection, sqlInfo);

                // Obtener datos con query dinámico
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
                _logger.LogError(ex, "Error al buscar almacenes: {@Request}", request);
                throw new Exception($"Error en BuscarAsync: {ex.Message}", ex);
            }
        }

        public async Task<object> UpdateAlmacenStatusAsync(int id, UpdateStatusRequest request)
        {
            return await _databaseService.UpdateStatusAsync(TABLE_NAME, id, request, "Almacén");
        }
        
        public async Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(BusquedaAlmacenesRequest request)
        {
            return await BuscarAlmacenesAsync(request);
        }
        
        public async Task<object> UpdateStatusAsync(int id, UpdateStatusRequest request)
        {
            return await UpdateAlmacenStatusAsync(id, request);
        }
    }

    // Clases de apoyo específicas para almacenes
    public class OpcionFiltro
    {
        public string Valor { get; set; } = string.Empty;
        public string Texto { get; set; } = string.Empty;
    }
}