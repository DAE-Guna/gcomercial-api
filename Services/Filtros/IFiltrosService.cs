namespace gcomercial_api.Services.Filtros
{
    public interface IFiltrosService
    {
        Task<FilterOptionsResponse> ObtenerFiltrosAsync(string modulo);
    }
}
