using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class OrdenesCompraDetalle
{
    public int IdDetalle { get; set; }

    public int? IdCabecera { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CantidadPendiente { get; set; }

    public decimal? CantidadSurtida { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? ImporteTotal { get; set; }

    public int? MovimientoId { get; set; }

    public int? NumMovimiento { get; set; }

    public virtual OrdenesCompraCabecera? IdCabeceraNavigation { get; set; }
}
