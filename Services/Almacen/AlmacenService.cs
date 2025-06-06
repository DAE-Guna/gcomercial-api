using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using Microsoft.Data.SqlClient;
using gcomercial_api.Models.GestionComercial.DTO;

namespace gcomercial_api.Services
{
    public class AlmacenService : IAlmacenService
    {
        private readonly GestionComercialDbContext _gestionComercialContext;

        public AlmacenService(GestionComercialDbContext gestionComercialContext)
        {
            _gestionComercialContext = gestionComercialContext;
        }

        public async Task<object> BuscarAlmacenesAsync(int page,int pageSize,string search,Dictionary<string, string[]> filters)
        {
            try
            {
                var offset = (page - 1) * pageSize;

                var parameters = new List<SqlParameter>();
                var whereConditions = new List<string>();

                parameters.Add(new SqlParameter("@offset", offset));
                parameters.Add(new SqlParameter("@pageSize", pageSize));

                if (!string.IsNullOrEmpty(search))
                {
                    if (filters != null && filters.Count > 0)
                    {
                        var searchableColumns = filters.Keys.ToList();
                        var searchConditions = searchableColumns.Select(column =>
                            $"[{column}] LIKE '%' + @search + '%'"
                        );
                        whereConditions.Add($"({string.Join(" OR ", searchConditions)})");
                        parameters.Add(new SqlParameter("@search", search));
                    }
                }

                if (filters != null && filters.Count > 0)
                {
                    foreach (var filter in filters)
                    {
                        var column = filter.Key;
                        var values = filter.Value;

                        if (values != null && values.Length > 0)
                        {
                            var paramNames = new List<string>();
                            for (int i = 0; i < values.Length; i++)
                            {
                                var paramName = $"@{column}{i}";
                                paramNames.Add(paramName);
                                parameters.Add(new SqlParameter(paramName, values[i]));
                            }

                            whereConditions.Add($"[{column}] IN ({string.Join(", ", paramNames)})");
                        }
                    }
                }

                var whereClause = whereConditions.Count > 0
                    ? "WHERE " + string.Join(" AND ", whereConditions)
                    : "";

                var countQuery = $@"
                    SELECT 
                        COUNT(*) 
                    FROM dbo.Almacenes a
                    JOIN Bases b ON a.base_id = b.id
                    JOIN dbo.Regiones r ON a.id_region = r.id
                    {whereClause}
                ";

                 var dataQuery = $@"
                    SELECT 
                        a.id,
                        a.codigo,
                        a.nombre,
                        a.sucursal,
                        a.base_id,
                        a.id_region,
                        b.nombre as base_nombre,
                        r.nombre as region_nombre,
                        a.id_estatus
                    FROM dbo.Almacenes a
                    JOIN Bases b ON a.base_id = b.id
                    JOIN dbo.Regiones r ON a.id_region = r.id
                    {whereClause}
                    ORDER BY a.codigo
                    OFFSET @offset ROWS
                    FETCH NEXT @pageSize ROWS ONLY
                 ";

                var countParams = parameters.Where(p => p.ParameterName != "@offset" && p.ParameterName != "@pageSize").ToArray();
                var total = 0;

                using (var connection = _gestionComercialContext.Database.GetDbConnection())
                {
                    await connection.OpenAsync();

                    using (var countCommand = connection.CreateCommand())
                    {
                        countCommand.CommandText = countQuery;
                        foreach (var param in countParams)
                        {
                            var dbParam = countCommand.CreateParameter();
                            dbParam.ParameterName = param.ParameterName;
                            dbParam.Value = param.Value ?? DBNull.Value;
                            countCommand.Parameters.Add(dbParam);
                        }

                        var result = await countCommand.ExecuteScalarAsync();
                        total = Convert.ToInt32(result);
                    }

                    var items = new List<Dictionary<string, object>>();
                    using (var dataCommand = connection.CreateCommand())
                    {
                        dataCommand.CommandText = dataQuery;
                        foreach (var param in parameters)
                        {
                            var dbParam = dataCommand.CreateParameter();
                            dbParam.ParameterName = param.ParameterName;
                            dbParam.Value = param.Value ?? DBNull.Value;
                            dataCommand.Parameters.Add(dbParam);
                        }

                        using (var reader = await dataCommand.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                var item = new Dictionary<string, object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    var columnName = reader.GetName(i);
                                    var value = reader.IsDBNull(i) ? null : reader.GetValue(i);
                                    item[columnName] = value;
                                }
                                items.Add(item);
                            }
                        }
                    }

                    return new
                    {
                        items,
                        pagination = new
                        {
                            total,
                            pageSize,
                            currentPage = page,
                            totalPages = (int)Math.Ceiling((double)total / pageSize),
                            hasMore = total > page * pageSize
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en BuscarProductosAsync: {ex.Message}", ex);
            }
        }

        public async Task<object> UpdateAlmacenStatusAsync(int id, UpdateStatusRequest request)
        {
            try
            {
                if (request.IdEstatus == null)
                {
                    throw new ArgumentException("El valor de id_estatus es requerido y debe ser true (activo) o false (inactivo)");
                }

                var rowsAffected = await _gestionComercialContext.Database.ExecuteSqlRawAsync(
                    "UPDATE dbo.Almacenes SET id_estatus = {0} WHERE id = {1}",
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