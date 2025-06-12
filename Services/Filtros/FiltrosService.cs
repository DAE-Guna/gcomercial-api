using gcomercial_api.Context;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.EntityFrameworkCore;

namespace gcomercial_api.Services.Filtros
{
    public class FilterOptionsResponse
    {
        public string[] FilterableFields { get; set; } = Array.Empty<string>();
        public Dictionary<string, FilterOption[]> FilterOptions { get; set; } = new();
    }

    public class FilterOption
    {
        public string Value { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
    }


    public class FiltrosService : IFiltrosService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IMemoryCache _cache;
        private readonly ILogger<FiltrosService> _logger;

        public FiltrosService(
            GestionComercialDbContext context,
            IMemoryCache cache,
            ILogger<FiltrosService> logger)
        {
            _context = context;
            _cache = cache;
            _logger = logger;
        }

        public async Task<FilterOptionsResponse> ObtenerFiltrosAsync(string modulo)
        {
            try
            {
                var cacheKey = $"filtros_{modulo}";

                // Intentar obtener del caché primero
                if (_cache.TryGetValue(cacheKey, out FilterOptionsResponse? cachedResult))
                {
                    return cachedResult!;
                }

                // Obtener filtros desde la base de datos
                var filtros = await _context.CamposFiltrablesValores
                    .Include(v => v.IdCampoNavigation)
                    .Where(v => v.IdCampoNavigation.Modulo == modulo &&
                               v.IdCampoNavigation.Activo)
                    .Select(v => new
                    {
                        Field = v.IdCampoNavigation.Campo,
                        Valor = v.Valor,
                        Texto = v.Texto
                    })
                    .ToListAsync();

                // Agrupar los filtros por campo (igual que en tu Node.js)
                var filtrosPorCampo = filtros
                    .Where(f => !string.IsNullOrEmpty(f.Field) && !string.IsNullOrEmpty(f.Valor))
                    .GroupBy(f => f.Field)
                    .ToDictionary(
                        g => g.Key,
                        g => g.Select(f => new FilterOption
                        {
                            Value = f.Valor,
                            Label = f.Texto
                        }).ToArray()
                    );

                // Obtener campos filtrables activos
                var camposFiltrables = await _context.CamposFiltrables
                    .Where(c => c.Modulo == modulo && c.Activo)
                    .Select(c => c.Campo)
                    .ToArrayAsync();

                // Crear el response
                var result = new FilterOptionsResponse
                {
                    FilterableFields = camposFiltrables,
                    FilterOptions = filtrosPorCampo
                };

                // Guardar en caché por 30 minutos
                _cache.Set(cacheKey, result, TimeSpan.FromMinutes(30));

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener filtros para módulo: {Modulo}", modulo);
                throw new Exception($"Error al obtener filtros para módulo {modulo}: {ex.Message}", ex);
            }
        }
    }
}
