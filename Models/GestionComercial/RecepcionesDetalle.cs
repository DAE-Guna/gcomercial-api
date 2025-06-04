using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class RecepcionesDetalle
{
    public int IdDetalle { get; set; }

    public int? IdCabecera { get; set; }

    public string? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? ImporteNeto { get; set; }

    public decimal? ImporteTotal { get; set; }

    public int? MovimientoId { get; set; }

    public int? MovimientoNumero { get; set; }

    public int? MovimientoOrigenId { get; set; }

    public virtual RecepcionesCabecera? IdCabeceraNavigation { get; set; }
}
