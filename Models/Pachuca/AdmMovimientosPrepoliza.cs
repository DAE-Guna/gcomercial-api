using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmMovimientosPrepoliza
{
    public int Cidmovimientoprepoliza { get; set; }

    public int Cidprepoliza { get; set; }

    public int Eje { get; set; }

    public int Periodo { get; set; }

    public int Tipopol { get; set; }

    public int Numpol { get; set; }

    public int Movto { get; set; }

    public string Cuenta { get; set; } = null!;

    public int Tipomov { get; set; }

    public string Referencia { get; set; } = null!;

    public double Importe { get; set; }

    public string Diario { get; set; } = null!;

    public double Moneda { get; set; }

    public string Concepto { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Segneg { get; set; } = null!;
}
