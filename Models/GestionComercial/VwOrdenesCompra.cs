using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwOrdenesCompra
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

    public decimal? TotalCajasPendientes { get; set; }

    public decimal? TotalCajasSurtidas { get; set; }

    public decimal? TotalPendientes { get; set; }

    public decimal? TotalSurtidas { get; set; }

    public decimal? TotalPorcentajeSurtido { get; set; }

    public string? Estado { get; set; }

    public int? TotalRecepciones { get; set; }

    public DateTime? FechaUltimaRecepcion { get; set; }

    public decimal? DiasEntreOrdenYRecepcion { get; set; }

    public int? IdEstatus { get; set; }

    public int? DiasEntregaProveedor { get; set; }

    public decimal? FillRate { get; set; }

    public decimal? OnTime { get; set; }

    public decimal? Otif { get; set; }
}
