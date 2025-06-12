using gcomercial_api.Models.GestionComercial.DTO;
using gcomercial_api.Services.Existencias;
using Microsoft.AspNetCore.Mvc;
using gcomercial_api.Services.OrdenCompra;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gcomercial_api.Controllers.OrdenCompra
{
    [Route("api/OrdenDeCompra")]
    [ApiController]
    public class OrdenCompraController : ControllerBase
    {
        private readonly IOrdenCompraService _ordenCompraService;

        public OrdenCompraController(IOrdenCompraService ordenCompraService)
        {
            _ordenCompraService = ordenCompraService;
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

                var OrdenCompraRequest = new BusquedaOrdenCompraRequest
                {
                    Page = page,
                    PageSize = pageSize,
                    Search = search,
                    Filters = filters
                };

                var result = await _ordenCompraService.BuscarOrdenCompraAsync(OrdenCompraRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }
    }
}
