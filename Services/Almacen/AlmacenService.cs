using Microsoft.EntityFrameworkCore;
using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using System.Text.Json;

namespace gcomercial_api.Services
{
    public class AlmacenService : IAlmacenService
    {
        private readonly GestionComercialDbContext _gestionComercialContext;

        public AlmacenService(GestionComercialDbContext gestionComercialContext)
        {
            _gestionComercialContext = gestionComercialContext;
        }

        public async Task<object> BuscarAlmacenesAsync(int page, int pageSize, string search, string filters)
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

                var query = _gestionComercialContext.Almacenes
                    .Join(_gestionComercialContext.Bases,
                          a => a.BaseId,
                          b => b.Id,
                          (a, b) => new { Almacen = a, Base = b })
                    .Join(_gestionComercialContext.Regiones,
                          ab => ab.Almacen.IdRegion,
                          r => r.Id,
                          (ab, r) => new { ab.Almacen, ab.Base, Region = r });

                if (!string.IsNullOrEmpty(search))
                {
                    query = query.Where(x =>
                        x.Almacen.Codigo.StartsWith(search) ||
                        x.Almacen.Nombre.Contains(search) ||
                        x.Almacen.Sucursal.Contains(search) ||
                        x.Base.Nombre.Contains(search) ||
                        x.Region.Nombre.Contains(search)
                    );
                }

                foreach (var filter in filterDict)
                {
                    if (filter.Value != null && filter.Value.Length > 0)
                    {
                        switch (filter.Key)
                        {
                            case "codigo":
                                query = query.Where(x => filter.Value.Contains(x.Almacen.Codigo));
                                break;
                            case "nombre":
                                query = query.Where(x => filter.Value.Contains(x.Almacen.Nombre));
                                break;
                            case "sucursal":
                                query = query.Where(x => filter.Value.Contains(x.Almacen.Sucursal));
                                break;
                            case "base_nombre":
                                query = query.Where(x => filter.Value.Contains(x.Base.Nombre));
                                break;
                            case "region_nombre":
                                query = query.Where(x => filter.Value.Contains(x.Region.Nombre));
                                break;
                        }
                    }
                }

                var total = await query.CountAsync();

                var items = await query
                    .OrderBy(x => x.Almacen.Codigo)
                    .Skip(offset)
                    .Take(pageSize)
                    .Select(x => new
                    {
                        id = x.Almacen.Id,
                        codigo = x.Almacen.Codigo,
                        nombre = x.Almacen.Nombre,
                        sucursal = x.Almacen.Sucursal,
                        base_id = x.Almacen.BaseId,
                        id_region = x.Almacen.IdRegion,
                        base_nombre = x.Base.Nombre,
                        region_nombre = x.Region.Nombre,
                        id_estatus = x.Almacen.IdEstatus
                    })
                    .ToListAsync();

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
                throw new Exception($"Error al buscar almacenes: {ex.Message}", ex);
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