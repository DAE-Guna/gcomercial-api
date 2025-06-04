using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class OrdenesCompraLegacy
{
    public int IdDocumento { get; set; }

    public string Serie { get; set; } = null!;

    public double Folio { get; set; }

    public DateTime Fecha { get; set; }

    public string Proveedor { get; set; } = null!;

    public string CodigoProveedor { get; set; } = null!;

    public string RfcProveedor { get; set; } = null!;

    public string Concepto { get; set; } = null!;

    public DateTime FechaEntregaRecepcion { get; set; }

    public double TotalDocumento { get; set; }

    public double TotalUnidadesDocumento { get; set; }

    public double UnidadesPendientesDocumento { get; set; }

    public double UnidadesSurtidasDocumento { get; set; }

    public decimal? PorcentajeSurtido { get; set; }

    public string EstadoDocumento { get; set; } = null!;

    public double NumeroMovimiento { get; set; }

    public string CodigoProducto { get; set; } = null!;

    public string NombreProducto { get; set; } = null!;

    public double Cantidad { get; set; }

    public double CantidadPendiente { get; set; }

    public double CantidadSurtida { get; set; }

    public string? UnidadMedida { get; set; }

    public double PrecioUnitario { get; set; }

    public double ImporteNeto { get; set; }

    public double ImporteTotal { get; set; }

    public string? CodigoAlmacen { get; set; }

    public string? Almacen { get; set; }
}
