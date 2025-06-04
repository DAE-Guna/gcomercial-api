using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class LmcViewVentasClienteAgenteProductoAnioMesDia
{
    public int Cidagente { get; set; }

    public int Cidclienteproveedor { get; set; }

    public int Cidproducto { get; set; }

    public int? Dia { get; set; }

    public int? Anio { get; set; }

    public int? Mes { get; set; }

    public double? Cantidad { get; set; }

    public double? Costo { get; set; }

    public double? Neto { get; set; }

    public double? Total { get; set; }

    public int Ciddocumentode { get; set; }
}
