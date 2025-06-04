using gcomercial_api.Models.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Services;

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorService _productoService;

        public ProveedorController(IProveedorService proveedorService)
        {
            _productoService = proveedorService;
        }
        // POST: api/Almacen/estatus
        [HttpPost("estatus")]
        public async Task<IActionResult> UpdateProveedores(int id, [FromBody] UpdateStatusRequest request)
        {
            try
            {
                var result = await _productoService.UpdateProveedoresStatusAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al actualizar el estatus del almacén" });
            }
        }
    }
}
