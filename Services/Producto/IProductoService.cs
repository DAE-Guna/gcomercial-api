namespace gcomercial_api.Services
{
    public interface IProductoService
    {
        Task<object> BuscarProductosAsync(int page, int pageSize, string search, string filters);
    }
}