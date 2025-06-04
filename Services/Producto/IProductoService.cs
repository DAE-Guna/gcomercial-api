using gcomercial_api.Models.Shared;

namespace gcomercial_api.Services
{
    public interface IProductoService
    {
        Task<object> BuscarProductosAsync(int page, int pageSize, string search, string filters);
        Task<object> UpdateProductoStatusAsync(int id, UpdateStatusRequest request);

    }
}