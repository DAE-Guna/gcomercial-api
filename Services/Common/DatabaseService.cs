using gcomercial_api.Context;
using gcomercial_api.Models.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace gcomercial_api.Services.Common
{
    public interface IDatabaseService
    {
        Task<List<string>> ObtenerCamposFiltrablesAsync(string modulo);
        Task<int> EjecutarConteoAsync(DbConnection connection, SqlQueryInfo sqlInfo);
        Task<List<Dictionary<string, object>>> EjecutarConsultaDatosAsync(DbConnection connection, SqlQueryInfo sqlInfo);
        Task<object> UpdateStatusAsync(string tableName, int id, UpdateStatusRequest request, string statusMessage);
    }

    public class DatabaseService : IDatabaseService
    {
        private readonly GestionComercialDbContext _context;
        private readonly IMemoryCache _cache;
        private readonly ILogger<DatabaseService> _logger;

        public DatabaseService(
            GestionComercialDbContext context,
            IMemoryCache cache,
            ILogger<DatabaseService> logger)
        {
            _context = context;
            _cache = cache;
            _logger = logger;
        }

        public async Task<List<string>> ObtenerCamposFiltrablesAsync(string modulo)
        {
            var cacheKey = $"campos_filtrables_{modulo}";

            if (!_cache.TryGetValue(cacheKey, out List<string>? campos))
            {
                campos = await _context.CamposFiltrables
                    .Where(c => c.Modulo == modulo && c.Activo)
                    .Select(c => c.Campo)
                    .ToListAsync();

                _cache.Set(cacheKey, campos, TimeSpan.FromMinutes(30));
            }

            return campos ?? new List<string>();
        }

        public async Task<int> EjecutarConteoAsync(DbConnection connection, SqlQueryInfo sqlInfo)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sqlInfo.CountQuery;

            // Agregar parámetros sin SqlParameter - construir en query
            foreach (var param in sqlInfo.Parameters)
            {
                command.CommandText = command.CommandText.Replace($"@{param.Key}",
                    param.Value?.ToString()?.Replace("'", "''") ?? "NULL");
            }

            var result = await command.ExecuteScalarAsync();
            return Convert.ToInt32(result);
        }

        public async Task<List<Dictionary<string, object>>> EjecutarConsultaDatosAsync(
            DbConnection connection, SqlQueryInfo sqlInfo)
        {
            using var command = connection.CreateCommand();
            command.CommandText = sqlInfo.DataQuery;

            // Agregar parámetros sin SqlParameter - construir en query
            foreach (var param in sqlInfo.Parameters)
            {
                command.CommandText = command.CommandText.Replace($"@{param.Key}",
                    param.Value?.ToString()?.Replace("'", "''") ?? "NULL");
            }

            var items = new List<Dictionary<string, object>>();
            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var item = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    var columnName = reader.GetName(i);
                    var value = reader.IsDBNull(i) ? null! : reader.GetValue(i);
                    item[columnName] = value;
                }
                items.Add(item);
            }

            return items;
        }

        public async Task<object> UpdateStatusAsync(string tableName, int id, UpdateStatusRequest request, string entityName)
        {
            try
            {
                if (request.IdEstatus == null)
                {
                    throw new ArgumentException("El valor de id_estatus es requerido");
                }

                // Usar EF Core para el update - usando parámetros para evitar SQL injection
                var rowsAffected = await _context.Database.ExecuteSqlRawAsync(
                    "UPDATE dbo." + tableName + " SET id_estatus = {0} WHERE id = {1}",
                    request.IdEstatus, id
                );

                if (rowsAffected == 0)
                {
                    throw new KeyNotFoundException($"{entityName} no encontrado");
                }

                return new
                {
                    message = $"Estatus del {entityName.ToLower()} actualizado correctamente a {(request.IdEstatus == true ? "activo" : "inactivo")}"
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al actualizar el estatus del {entityName.ToLower()}: {ex.Message}", ex);
            }
        }
    }
}
