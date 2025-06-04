using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmMovimientosContable
{
    public int Cidmovimientocontable { get; set; }

    public int Cidasientocontable { get; set; }

    public string Ccuenta { get; set; } = null!;

    public int Ctipomovimiento { get; set; }

    public double Cimportebase { get; set; }

    public double Cporcentaje { get; set; }

    public int Corigenreferencia { get; set; }

    public string Creferencia { get; set; } = null!;

    public int Corigendiario { get; set; }

    public string Cdiario { get; set; } = null!;

    public int Corigenconcepto { get; set; }

    public string Cconcepto { get; set; } = null!;

    public string Ctimestamp { get; set; } = null!;

    public int Csumariz { get; set; }

    public int Csupmovs0 { get; set; }

    public int Corisegneg { get; set; }

    public string Csegneg { get; set; } = null!;

    public int Cimpmonext { get; set; }

    public int Cimpmondoc { get; set; }

    public int Ccomplemen { get; set; }
}
