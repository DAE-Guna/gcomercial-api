using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class PreciosProducto
{
    public int? Id { get; set; }

    public string? CodigoProducto { get; set; }

    public string? Producto { get; set; }

    public string? UnidadBase { get; set; }

    public string? Clasificacion1 { get; set; }

    public decimal? PorcentajeImpuesto { get; set; }

    public decimal? PorcentajeImpuesto2 { get; set; }

    public decimal? PrecioVenta { get; set; }

    public decimal? PrecioCompra { get; set; }

    public DateTime? FechaUltimaCompra { get; set; }

    public DateTime? FechaAlta { get; set; }

    public string? Base { get; set; }
}
