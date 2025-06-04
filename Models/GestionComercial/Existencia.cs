using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Existencia
{
    public string? CodigoAlmacen { get; set; }

    public string? Almacen { get; set; }

    public string? CodigoProducto { get; set; }

    public string? Producto { get; set; }

    public int? InventarioActual { get; set; }

    public DateOnly? FechaUltimoMovimiento { get; set; }

    public string? Base { get; set; }
}
