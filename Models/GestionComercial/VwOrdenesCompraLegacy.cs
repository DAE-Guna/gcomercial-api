using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwOrdenesCompraLegacy
{
    public int? Anio { get; set; }

    public string? Mes { get; set; }

    public int? Semana { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Serie { get; set; }

    public int? Folio { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Iva { get; set; }

    public decimal? Total { get; set; }

    public decimal? CostoUnitario { get; set; }

    public string Region { get; set; } = null!;

    public string? Sucursal { get; set; }

    public string? Proveedor { get; set; }

    public string? Marca { get; set; }

    public decimal? Cajas { get; set; }

    public string? UnidadDeNegocio { get; set; }

    public decimal? CostoUnitario2 { get; set; }

    public decimal? ImporteNeto2 { get; set; }

    public decimal? Total2 { get; set; }
}
