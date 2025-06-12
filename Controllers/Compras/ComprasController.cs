using gcomercial_api.Models.GestionComercial.DTO;
using gcomercial_api.Services.Compras;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gcomercial_api.Controllers.Compras
{
    [Route("api/Compras")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        private readonly ICompraService _compraService;

        public ComprasController(ICompraService compraService)
        {
            _compraService = compraService;
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

                var almacenesRequest = new BusquedaCompraRequest
                {
                    Page = page,
                    PageSize = pageSize,
                    Search = search,
                    Filters = filters
                };

                var result = await _compraService.BuscarCompraAsync(almacenesRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }
    }
}
