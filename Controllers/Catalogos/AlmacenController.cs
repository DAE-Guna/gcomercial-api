using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using System.Text.Json;
using gcomercial_api.Services.Almacen;
using gcomercial_api.Models.GestionComercial.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/almacenes")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {
        private readonly IAlmacenService _almacenService;

        public AlmacenController(IAlmacenService almacenService)
        {
            _almacenService = almacenService;
        }

        // GET: api/Almacen/buscar
        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarAlmacenes([FromQuery] int page = 1,[FromQuery] int pageSize = 15,[FromQuery] string search = "",[FromBody] BuscarProductosRequestDto request = null)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize < 1 || pageSize > 100) pageSize = 15;

                var filters = request?.Filters ?? new Dictionary<string, string[]>();

                var almacenesRequest = new BusquedaAlmacenesRequest
                {
                   Page = page,
                   PageSize = pageSize,
                   Search = search,
                   Filters = filters
                };

                var result = await _almacenService.BuscarAlmacenesAsync(almacenesRequest);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar productos" });
            }
        }

        // POST: api/Almacen/estatus
        [HttpPost("estatus")]
        public async Task<IActionResult> UpdateAlmacenStatus(int id, [FromBody] UpdateStatusRequest request)
        {
            try
            {
                var result = await _almacenService.UpdateAlmacenStatusAsync(id, request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al actualizar el estatus del almacén" });
            }
        }


    }
}
