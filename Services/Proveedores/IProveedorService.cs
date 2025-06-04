using gcomercial_api.Models.Shared;
using gcomercial_api.Services;

namespace gcomercial_api.Services
{
    public interface IProveedorService
    {
        Task<object> UpdateProveedoresStatusAsync(int id, UpdateStatusRequest request);

    }
}
