using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using System.Text.Json;
using gcomercial_api.Services;
using gcomercial_api.Models.GestionComercial.DTO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace gcomercial_api.Controllers.Catalogos
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacenController : ControllerBase
    {

        private readonly GestionComercialDbContext _gestionComercialContext;
        private readonly IAlmacenService _almacenService;

        public AlmacenController(GestionComercialDbContext gestionComercialContext, IAlmacenService almacenService)
        {
            _gestionComercialContext = gestionComercialContext;
            _almacenService = almacenService;
        }

        // GET: api/Almacen/buscar
        [HttpPost("buscar")]
        public async Task<IActionResult> BuscarAlmacenes(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 15,
            [FromQuery] string search = "",
            [FromBody] BuscarAlmacenesRequestDto request = null)
        {
            try
            {
                if (page < 1) page = 1;
                if (pageSize < 1 || pageSize > 100) pageSize = 15;
                var filters = request?.Filters ?? new Dictionary<string, string[]>();
                var result = await _almacenService.BuscarAlmacenesAsync(
                    page,
                    pageSize,
                    search ?? "",
                    filters
                );
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "Error al buscar almacenes" });
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
