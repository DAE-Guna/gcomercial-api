using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class ComprasCabecera
{
    public int IdCabecera { get; set; }

    public int? IdDocumento { get; set; }

    public string? Serie { get; set; }

    public int? Folio { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Concepto { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? Proveedor { get; set; }

    public decimal? ImporteTotal { get; set; }

    public decimal? TotalUnidades { get; set; }

    public decimal? UnidadesPendientes { get; set; }

    public decimal? UnidadesSurtidas { get; set; }

    public decimal? PorcentajeSurtido { get; set; }

    public string? Estado { get; set; }

    public string? CodigoAlmacen { get; set; }

    public string? Almacen { get; set; }

    public string? Base { get; set; }

    public virtual ICollection<ComprasDetalle> ComprasDetalles { get; set; } = new List<ComprasDetalle>();
}
