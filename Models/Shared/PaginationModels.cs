using System.Collections.Generic;

namespace gcomercial_api.Models.Shared
{
    public class GenericSearchRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string? Search { get; set; }
        public Dictionary<string, string[]>? Filters { get; set; }
    }

    public class PaginatedResult<T>
    {
        public IEnumerable<T> Items { get; set; } = new List<T>();
        public PaginationInfo Pagination { get; set; } = new();
    }

    public class PaginationInfo
    {
        public List<Dictionary<string, object>>? Totales { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasMore { get; set; }
    }

    public class CampoFiltrable
    {
        public int Id { get; set; }
        public string Modulo { get; set; } = string.Empty;
        public string Campo { get; set; } = string.Empty;
        public bool Activo { get; set; }
    }


}
