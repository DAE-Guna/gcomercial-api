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

        public async Task<BuscarAlmacenesResponseDto> BuscarAlmacenesAsync(
            int page,
            int pageSize,
            string search,
            Dictionary<string, string[]> filters)
        {
            try
            {
                var offset = (page - 1) * pageSize;

                var whereConditions = new List<string>();
                var parameters = new List<SqlParameter>();

                parameters.Add(new SqlParameter("@offset", offset));
                parameters.Add(new SqlParameter("@pageSize", pageSize));

                if (!string.IsNullOrEmpty(search))
                {
                    whereConditions.Add(@"(
                        codigo LIKE @search + '%' OR 
                        descripcion LIKE '%' + @search + '%' OR
                        proveedor LIKE '%' + @search + '%' OR
                        departamento LIKE '%' + @search + '%' OR
                        categoria LIKE '%' + @search + '%' OR
                        subcategoria LIKE '%' + @search + '%' OR
                        portafolio LIKE '%' + @search + '%' OR
                        division LIKE '%' + @search + '%' OR
                        marca LIKE '%' + @search + '%'
                    )");
                    parameters.Add(new SqlParameter("@search", search));
                }

                if (filters != null && filters.Count > 0)
                {
                    foreach (var filter in filters)
                    {
                        var column = filter.Key;
                        var values = filter.Value;

                        if (values != null && values.Length > 0)
                        {
                            var parameterNames = new List<string>();
                            for (int i = 0; i < values.Length; i++)
                            {
                                var paramName = $"@{column}{i}";
                                parameterNames.Add(paramName);
                                parameters.Add(new SqlParameter(paramName, values[i]));
                            }

                            whereConditions.Add($"{column} IN ({string.Join(", ", parameterNames)})");
                        }
                    }
                }

                var whereClause = whereConditions.Count > 0
                    ? "WHERE " + string.Join(" AND ", whereConditions)
                    : "";

                var countQuery = $@"
                    SELECT COUNT(*) as total
                    FROM [dbGestionComercial].[dbo].[Vw_Productos]
                    {whereClause}";

                var totalResult = await _gestionComercialContext.Database
                    .SqlQueryRaw<int>(countQuery, parameters.ToArray())
                    .FirstOrDefaultAsync();

                var itemsQuery = $@"
                    SELECT [id_producto]
                          ,[codigo]
                          ,[id_proveedor]
                          ,[proveedor]
                          ,[id_departamento]
                          ,[departamento]
                          ,[id_categoria]
                          ,[categoria]
                          ,[id_subcategoria]
                          ,[subcategoria]
                          ,[id_portafolio]
                          ,[portafolio]
                          ,[id_division]
                          ,[division]
                          ,[id_marca]
                          ,[marca]
                          ,[descripcion]
                          ,[unidad_x_caja]
                          ,[ieps]
                          ,[iva]
                          ,[costo_sin_impuestos]
                          ,[costo_con_impuestos]
                          ,[precio_sin_impuestos]
                          ,[precio_con_impuestos]
                          ,[id_estatus]
                    FROM [dbGestionComercial].[dbo].[Vw_Productos]
                    {whereClause}
                    ORDER BY codigo
                    OFFSET @offset ROWS
                    FETCH NEXT @pageSize ROWS ONLY";

                var itemsParameters = new List<SqlParameter>();
                foreach (var param in parameters)
                {
                    itemsParameters.Add(new SqlParameter(param.ParameterName, param.Value));
                }

                var items = await _gestionComercialContext.Set<ProductoDto>()
                    .FromSqlRaw(itemsQuery, itemsParameters.ToArray())
                    .ToListAsync();

                return new BuscarAlmacenesResponseDto
                {
                    Items = items,
                    Pagination = new PaginationDto
                    {
                        Total = totalResult,
                        PageSize = pageSize,
                        CurrentPage = page,
                        TotalPages = (int)Math.Ceiling((double)totalResult / pageSize),
                        HasMore = totalResult > page * pageSize
                    }
                };
            }
            catch (Exception ex)
            {
                // Log the exception
                throw new ApplicationException("Error al buscar productos", ex);
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