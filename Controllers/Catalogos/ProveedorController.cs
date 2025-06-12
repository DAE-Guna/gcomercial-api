using gcomercial_api.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Services;
using gcomercial_api.Models.GestionComercial.DTO;
using static gcomercial_api.Services.ProveedorService;

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _proveedorService;

        public ProveedorController(IProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        // GET: api/Producto/buscar
        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarProveedor([FromQuery] int page = 1, [FromQuery] int pageSize = 15, [FromQuery] string search = "", [FromBody] BuscarProductosRequestDto request = null)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize < 1 || pageSize > 100) pageSize = 15;

                var filters = request?.Filters ?? new Dictionary<string, string[]>();

                var ProveedorRequest = new BusquedaProveedorRequest
                {
                    Page = page,
                    PageSize = pageSize,
                    Search = search,
                    Filters = filters
                };

                var result = await _proveedorService.BuscarProveedorAsync(ProveedorRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar Proveedor" });
            }
        }

        // POST: api/Proveedor/estatus
        [HttpPost("estatus")]
        public async Task<IActionResult> UpdateProveedorStatus(int id, [FromBody] UpdateStatusRequest request)
        {
            try
            {
                var result = await _proveedorService.UpdateProveedorStatusAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al actualizar el estatus del Proveedor" });
            }
        }
    }
}
