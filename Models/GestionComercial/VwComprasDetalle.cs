using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwComprasDetalle
{
    public int? IdDocumento { get; set; }

    public int? Anio { get; set; }

    public string? Mes { get; set; }

    public int? Semana { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Serie { get; set; }

    public int? Folio { get; set; }

    public string? Concepto { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? Proveedor { get; set; }

    public decimal? TotalUnidades { get; set; }

    public decimal? TotalPendientes { get; set; }

    public decimal? TotalSurtidas { get; set; }

    public decimal? TotalPorcentajeSurtido { get; set; }

    public string? Estado { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Iva { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string Region { get; set; } = null!;

    public string? Sucursal { get; set; }

    public string? ProveedorAlias { get; set; }

    public string? Marca { get; set; }

    public decimal? Cajas { get; set; }

    public string? UnidadDeNegocio { get; set; }

    public int EsNotaCredito { get; set; }

    public decimal? ImporteNetoNota { get; set; }

    public decimal? ImporteTotalNota { get; set; }
}
