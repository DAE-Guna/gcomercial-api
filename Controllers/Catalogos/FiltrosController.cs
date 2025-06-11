using gcomercial_api.Services.Filtros;
using Microsoft.AspNetCore.Mvc;

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/filtros")]
    [ApiController]
    public class FiltrosController : ControllerBase
    {
        private readonly IFiltrosService _filtrosService;
        private readonly ILogger<FiltrosController> _logger;

        public FiltrosController(IFiltrosService filtrosService, ILogger<FiltrosController> logger)
        {
            _filtrosService = filtrosService;
            _logger = logger;
        }

        [HttpGet("{modulo}")]
        public async Task<ActionResult<FilterOptionsResponse>> GetFiltros(string modulo)
        {
            try
            {
                var result = await _filtrosService.ObtenerFiltrosAsync(modulo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener opciones de filtro para módulo: {Modulo}", modulo);
                return StatusCode(500, new { error = "Error al obtener opciones de filtro" });
            }
        }
    }
}
