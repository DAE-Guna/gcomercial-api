using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Services;
using gcomercial_api.Models.Shared;
using gcomercial_api.Models.GestionComercial.DTO;
using gcomercial_api.Services.Almacen;

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
        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarProductos([FromQuery] int page = 1,[FromQuery] int pageSize = 15,[FromQuery] string search = "",[FromBody] BuscarProductosRequestDto request = null)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize < 1 || pageSize > 100) pageSize = 15;

                var filters = request?.Filters ?? new Dictionary<string, string[]>();

                var ProductosRequest = new BusquedaProductoRequest
                {
                   Page = page,
                   PageSize = pageSize,
                   Search = search,
                   Filters = filters
                };

                var result = await _productoService.BuscarProductosAsync(ProductosRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }

        // POST: api/Almacen/estatus
        [HttpPost("estatus")]
        public async Task<IActionResult> UpdateProductoStatus(int id, [FromBody] UpdateStatusRequest request)
        {
            try
            {
                var result = await _productoService.UpdateProductoStatusAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al actualizar el estatus del almacén" });
            }
        }
    }
}