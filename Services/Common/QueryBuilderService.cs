using gcomercial_api.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace gcomercial_api.Services.Common
{
    public class SqlQueryInfo
    {
        public string CountQuery { get; set; } = string.Empty;
        public string DataQuery { get; set; } = string.Empty;
        public Dictionary<string, object> Parameters { get; set; } = new();
    }

    public interface IQueryBuilderService
    {
        SqlQueryInfo BuildQuery(GenericSearchRequest request, string viewName, List<string> camposFiltrables, string orderByColumn = "id");
    }

    public class QueryBuilderService : IQueryBuilderService
    {
        public SqlQueryInfo BuildQuery(GenericSearchRequest request, string viewName, List<string> camposFiltrables, string orderByColumn = "id")
        {
            var whereConditions = new List<string>();
            var parameters = new Dictionary<string, object>
            {
                ["offset"] = (request.Page - 1) * request.PageSize,
                ["pageSize"] = request.PageSize
            };

            // Construir búsqueda de texto dinámicamente
            if (!string.IsNullOrWhiteSpace(request.Search) && camposFiltrables?.Any() == true)
            {
                var searchConditions = camposFiltrables
                    .Select(campo => $"[{campo}] LIKE '%' + '{request.Search.Replace("'", "''")}' + '%'")
                    .ToList();

                if (searchConditions.Any())
                {
                    whereConditions.Add($"({string.Join(" OR ", searchConditions)})");
                }
            }

            // Construir filtros específicos dinámicamente
            if (request.Filters?.Any() == true && camposFiltrables?.Any() == true)
            {
                var camposPermitidos = camposFiltrables.ToHashSet(StringComparer.OrdinalIgnoreCase);

                foreach (var filter in request.Filters)
                {
                    var column = filter.Key;
                    var values = filter.Value;

                    // Validar que la columna esté permitida
                    if (!camposPermitidos.Contains(column) || values?.Length == 0)
                        continue;

                    // Construir IN clause directamente
                    var escapedValues = values
                        ?.Select(v => $"'{v.Replace("'", "''")}'") 
                        ?.ToList() ?? new List<string>();

                    whereConditions.Add($"[{column}] IN ({string.Join(", ", escapedValues)})");
                }
            }

            var whereClause = whereConditions.Any()
                ? "WHERE " + string.Join(" AND ", whereConditions)
                : "";

            var countQuery = $@"
            SELECT COUNT(*) 
            FROM {viewName}
            {whereClause}";

            var dataQuery = $@"
            SELECT *
            FROM {viewName}
            {whereClause}
            ORDER BY {orderByColumn}
            OFFSET {parameters["offset"]} ROWS
            FETCH NEXT {parameters["pageSize"]} ROWS ONLY";

            return new SqlQueryInfo
            {
                CountQuery = countQuery,
                DataQuery = dataQuery,
                Parameters = parameters
            };
        }
    }
}
