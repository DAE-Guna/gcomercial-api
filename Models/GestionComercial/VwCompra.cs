using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwCompra
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

    public decimal? ImporteNeto { get; set; }

    public decimal? ImporteTotal { get; set; }

    public decimal? TotalCajas { get; set; }

    public decimal? TotalPendientes { get; set; }

    public decimal? TotalSurtidas { get; set; }

    public decimal? TotalPorcentajeSurtido { get; set; }

    public string? Estado { get; set; }

    public int? IdEstatus { get; set; }

    public decimal? ImporteNetoNota { get; set; }

    public decimal? ImporteTotalNota { get; set; }
}
