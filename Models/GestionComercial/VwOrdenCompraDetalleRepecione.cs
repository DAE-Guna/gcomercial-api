using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwOrdenCompraDetalleRepecione
{
    public int IdOrdenCabecera { get; set; }

    public int? IdOrden { get; set; }

    public string? SerieOrden { get; set; }

    public int? FolioOrden { get; set; }

    public DateTime? FechaOrden { get; set; }

    public string? ConceptoOrden { get; set; }

    public string? CodigoProveedor { get; set; }

    public string? Proveedor { get; set; }

    public int? DiasEntregaProveedor { get; set; }

    public string? EstadoOrden { get; set; }

    public decimal? PorcentajeSurtido { get; set; }

    public decimal? UnidadesOrdenadas { get; set; }

    public decimal? UnidadesPendientes { get; set; }

    public decimal? UnidadesSurtidas { get; set; }

    public int IdOrdenDetalle { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? CantidadOrdenada { get; set; }

    public decimal? CantidadPendiente { get; set; }

    public decimal? CantidadSurtida { get; set; }

    public decimal? CajasOrdenadas { get; set; }

    public decimal? CajasPendientes { get; set; }

    public decimal? CajasSurtidas { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? ImporteTotal { get; set; }

    public int? MovimientoOrdenId { get; set; }

    public int? NumMovimientoOrden { get; set; }

    public int? IdRecepcionCabecera { get; set; }

    public int? IdRecepcion { get; set; }

    public string? SerieRecepcion { get; set; }

    public int? FolioRecepcion { get; set; }

    public DateTime? FechaRecepcion { get; set; }

    public string? ConceptoRecepcion { get; set; }

    public string? EstadoRecepcion { get; set; }

    public int? DiasEntreOrdenYRecepcion { get; set; }

    public int? IdRecepcionDetalle { get; set; }

    public decimal? CantidadRecibida { get; set; }

    public decimal? CostoUnitario { get; set; }

    public int? MovimientoId { get; set; }

    public int? MovimientoOrigenId { get; set; }

    public string? CodigoAlmacen { get; set; }

    public string? Almacen { get; set; }

    public string? Base { get; set; }
}
