using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmMovtosCep
{
    public int Cidmovtocep { get; set; }

    public int Ciddocumento { get; set; }

    public DateTime Cfecha { get; set; }

    public string Chora { get; set; } = null!;

    public string Cclave { get; set; } = null!;

    public string Csello { get; set; } = null!;

    public string Ccertificado { get; set; } = null!;

    public string? Ccadena { get; set; }

    public int Cestado { get; set; }

    public string Cconcepto { get; set; } = null!;

    public double Civa { get; set; }

    public double Cimporte { get; set; }

    public string Crbanco { get; set; } = null!;

    public string Crnombre { get; set; } = null!;

    public string Crrfc { get; set; } = null!;

    public string Crcuenta { get; set; } = null!;

    public string Crtipocta { get; set; } = null!;

    public string Cebanco { get; set; } = null!;

    public string Cenombre { get; set; } = null!;

    public string Cerfc { get; set; } = null!;

    public string Cecuenta { get; set; } = null!;

    public string Cetipocta { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Carchivo { get; set; } = null!;

    public string Ctimestamp { get; set; } = null!;
}
