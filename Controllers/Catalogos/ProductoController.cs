using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Services;

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        // GET: api/Producto/buscar
        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarProductos(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 15,
            [FromQuery] string search = "",
            [FromQuery] string filters = "")
        {
            try
            {
                var result = await _productoService.BuscarProductosAsync(page, pageSize, search, filters);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }
    }
}