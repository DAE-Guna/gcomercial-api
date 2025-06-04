using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using System.Text.Json;
using gcomercial_api.Models.Shared;

namespace gcomercial_api.Services
{
    public class ProductoService : IProductoService
    {
        private readonly GestionComercialDbContext _gestionComercialContext;

        public ProductoService(GestionComercialDbContext gestionComercialContext)
        {
            _gestionComercialContext = gestionComercialContext;
        }

        public async Task<object> BuscarProductosAsync(int page, int pageSize, string search, string filters)
        {
            try
            {
                var offset = (page - 1) * pageSize;

                Dictionary<string, string[]> filterDict = new Dictionary<string, string[]>();
                if (!string.IsNullOrEmpty(filters))
                {
                    try
                    {
                        filterDict = JsonSerializer.Deserialize<Dictionary<string, string[]>>(filters)
                                   ?? new Dictionary<string, string[]>();
                    }
                    catch
                    {
                        filterDict = new Dictionary<string, string[]>();
                    }
                }

                var query = _gestionComercialContext.VwProductos.AsQueryable();

                // Aplicar filtro de búsqueda general
                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(p =>
                        p.Codigo.StartsWith(search) ||
                        p.Descripcion.Contains(search) ||
                        p.Proveedor.Contains(search) ||
                        p.Departamento.Contains(search) ||
                        p.Categoria.Contains(search) ||
                        p.Subcategoria.Contains(search) ||
                        p.Portafolio.Contains(search) ||
                        p.Division.Contains(search) ||
                        p.Marca.Contains(search));
                }

                // Aplicar filtros específicos por columna
                foreach (var filter in filterDict)
                {
                    if (filter.Value != null && filter.Value.Length > 0)
                    {
                        switch (filter.Key.ToLower())
                        {
                            case "codigo":
                                query = query.Where(p => filter.Value.Contains(p.Codigo));
                                break;
                            case "descripcion":
                                query = query.Where(p => filter.Value.Contains(p.Descripcion));
                                break;
                            case "proveedor":
                                query = query.Where(p => filter.Value.Contains(p.Proveedor));
                                break;
                            case "departamento":
                                query = query.Where(p => filter.Value.Contains(p.Departamento));
                                break;
                            case "categoria":
                                query = query.Where(p => filter.Value.Contains(p.Categoria));
                                break;
                            case "subcategoria":
                                query = query.Where(p => filter.Value.Contains(p.Subcategoria));
                                break;
                            case "portafolio":
                                query = query.Where(p => filter.Value.Contains(p.Portafolio));
                                break;
                            case "division":
                                query = query.Where(p => filter.Value.Contains(p.Division));
                                break;
                            case "marca":
                                query = query.Where(p => filter.Value.Contains(p.Marca));
                                break;
                        }
                    }
                }

                // Obtener total de registros
                var total = await query.CountAsync();

                // Obtener datos paginados
                var items = await query
                    .OrderBy(p => p.Codigo)
                    .Skip(offset)
                    .Take(pageSize)
                    .Select(p => new
                    {
                        id_producto = p.IdProducto,
                        codigo = p.Codigo,
                        id_proveedor = p.IdProveedor,
                        proveedor = p.Proveedor,
                        id_departamento = p.IdDepartamento,
                        departamento = p.Departamento,
                        id_categoria = p.IdCategoria,
                        categoria = p.Categoria,
                        id_subcategoria = p.IdSubcategoria,
                        subcategoria = p.Subcategoria,
                        id_portafolio = p.IdPortafolio,
                        portafolio = p.Portafolio,
                        id_division = p.IdDivision,
                        division = p.Division,
                        id_marca = p.IdMarca,
                        marca = p.Marca,
                        descripcion = p.Descripcion,
                        unidad_x_caja = p.UnidadXCaja,
                        ieps = p.Ieps,
                        iva = p.Iva,
                        costo_sin_impuestos = p.CostoSinImpuestos,
                        costo_con_impuestos = p.CostoConImpuestos,
                        precio_sin_impuestos = p.PrecioSinImpuestos,
                        precio_con_impuestos = p.PrecioConImpuestos,
                        id_estatus = p.IdEstatus
                    })
                    .ToListAsync();

                // Construir resultado
                return new
                {
                    items = items,
                    pagination = new
                    {
                        total = total,
                        pageSize = pageSize,
                        currentPage = page,
                        totalPages = (int)Math.Ceiling((double)total / pageSize),
                        hasMore = total > page * pageSize
                    }
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al buscar productos: {ex.Message}", ex);
            }
        }

        public async Task<object> UpdateProductoStatusAsync(int id, UpdateStatusRequest request)
        {
            try
            {
                if (request.IdEstatus == null)
                {
                    throw new ArgumentException("El valor de id_estatus es requerido y debe ser true (activo) o false (inactivo)");
                }

                var rowsAffected = await _gestionComercialContext.Database.ExecuteSqlRawAsync(
                    "UPDATE dbo.Productos SET id_estatus = {0} WHERE id = {1}",
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