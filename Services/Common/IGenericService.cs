using gcomercial_api.Models.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gcomercial_api.Services.Common
{
    public interface IGenericService<TSearchRequest> where TSearchRequest : GenericSearchRequest
    {
        Task<PaginatedResult<Dictionary<string, object>>> BuscarAsync(TSearchRequest request);
        Task<object> UpdateStatusAsync(int id, UpdateStatusRequest request);
    }
}
