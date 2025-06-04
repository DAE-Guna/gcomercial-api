using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmAsientosContable
{
    public int Cidasientocontable { get; set; }

    public string Cnumeroasientocontable { get; set; } = null!;

    public string Cnombreasientocontable { get; set; } = null!;

    public int Cfrecuencia { get; set; }

    public int Corigenfecha { get; set; }

    public int Ctipopoliza { get; set; }

    public int Corigennumero { get; set; }

    public int Corigenconcepto { get; set; }

    public string Cconcepto { get; set; } = null!;

    public string Cdiario { get; set; } = null!;

    public string Ctimestamp { get; set; } = null!;
}
