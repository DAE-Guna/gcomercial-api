using System.Collections.Generic;
using System.Threading.Tasks;
using gcomercial_api.Models.Shared;

namespace gcomercial_api.Services
{
    public interface IAlmacenService
    {
        Task<object> BuscarAlmacenesAsync(int page, int pageSize, string search, string filters);
        Task<object> UpdateAlmacenStatusAsync(int id, UpdateStatusRequest request);
    }
}