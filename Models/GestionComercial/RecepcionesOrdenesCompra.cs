using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class RecepcionesOrdenesCompra
{
    public int? IdDocumento { get; set; }

    public string? Serie { get; set; }

    public int? Folio { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Concepto { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? Proveedor { get; set; }

    public decimal? TotalSinImpuestos { get; set; }

    public decimal? TotalUnidades { get; set; }

    public string? Estado { get; set; }

    public int? DocumentoOrigenId { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string? CodigoAlmacen { get; set; }

    public string? Almacen { get; set; }

    public int? MovimientoId { get; set; }

    public int? MovimientoNumero { get; set; }

    public int? MovimientoOrigenId { get; set; }

    public string? Base { get; set; }
}
