using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Models.Shared;
using gcomercial_api.Services;

namespace gcomercial_api.Services
{
    public class ProveedorService : IProveedorService
    {
        
        private readonly GestionComercialDbContext _gestionComercialContext;

        public ProveedorService(GestionComercialDbContext gestionComercialContext)
        {
            _gestionComercialContext = gestionComercialContext;
        }

        public async Task<object> UpdateProveedoresStatusAsync(int id, UpdateStatusRequest request)
        {

            try
            {
                if (request.IdEstatus == null)
                {
                    throw new ArgumentException("El valor de id_estatus es requerido y debe ser true (activo) o false (inactivo)");
                }

                var rowsAffected = await _gestionComercialContext.Database.ExecuteSqlRawAsync(
                    "UPDATE dbo.Productos SET id_estatus = {0} WHERE id = {1}",
                    request.IdEstatus, id
                );

                if (rowsAffected == 0)
                {
                    throw new KeyNotFoundException("Almacén no encontrado");
                }

                return new
                {
                    message = $"Estatus del almacén actualizado correctamente a {(request.IdEstatus == true ? "activo" : "inactivo")}"
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el estatus del almacén: {ex.Message}", ex);
            }
        }
    }
}
