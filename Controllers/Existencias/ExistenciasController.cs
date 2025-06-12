using gcomercial_api.Models.GestionComercial.DTO;
using gcomercial_api.Services.Almacen;
using gcomercial_api.Services.Existencias;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gcomercial_api.Controllers.Existencias
{
    [Route("api/existencias")]
    [ApiController]
    public class ExistenciasController : ControllerBase
    {
        private readonly IExistenciaService _existenciasService;

        public ExistenciasController(IExistenciaService existenciasService)
        {
            _existenciasService = existenciasService;
        }
        
        // GET: api/Existencias/buscar
        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarExistencias([FromQuery] int page = 1, [FromQuery] int pageSize = 15, [FromQuery] string search = "", [FromBody] BuscarProductosRequestDto request = null)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize < 1 || pageSize > 100) pageSize = 15;

                var filters = request?.Filters ?? new Dictionary<string, string[]>();

                var almacenesRequest = new BusquedaExistenciaRequest
                {
                    Page = page,
                    PageSize = pageSize,
                    Search = search,
                    Filters = filters
                };

                var result = await _existenciasService.BuscarExistenciasAsync(almacenesRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }
    }
}
