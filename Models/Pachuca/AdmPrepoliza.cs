using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmPrepoliza
{
    public int Cidprepoliza { get; set; }

    public int Cestadocontable { get; set; }

    public int Eje { get; set; }

    public int Periodo { get; set; }

    public int Tipopol { get; set; }

    public int Numpol { get; set; }

    public int Clase { get; set; }

    public int Impresa { get; set; }

    public string Concepto { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public double Cargos { get; set; }

    public double Abonos { get; set; }

    public string Diario { get; set; } = null!;

    public int Sistorig { get; set; }

    public string Chora { get; set; } = null!;

    public string Cguidpoliza { get; set; } = null!;

    public string Cidtransaccion { get; set; } = null!;
}
