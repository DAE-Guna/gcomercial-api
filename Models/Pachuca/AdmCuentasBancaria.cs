using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmCuentasBancaria
{
    public int Cidcuenta { get; set; }

    public string Cnumerocuenta { get; set; } = null!;

    public string Cnombrecuenta { get; set; } = null!;

    public DateTime Cfechaalta { get; set; }

    public DateTime Cfechabaja { get; set; }

    public int Cestatus { get; set; }

    public string Cclabe { get; set; } = null!;

    public string Cclave { get; set; } = null!;

    public string Csegcont01 { get; set; } = null!;

    public string Csegcont02 { get; set; } = null!;

    public string Csegcont03 { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public string Caccountid { get; set; } = null!;

    public int Cidmoneda { get; set; }

    public int Cidcatalogo { get; set; }

    public int Ctipocatalogo { get; set; }

    public string Cnombanext { get; set; } = null!;

    public string Crfcbanco { get; set; } = null!;
}
