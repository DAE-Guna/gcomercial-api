using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class NubeCuenta
{
    public string Ccuenta { get; set; } = null!;

    public string Cnombre { get; set; } = null!;

    public int Cestatus { get; set; }

    public int Cflujoefectivo { get; set; }

    public string Ctipo { get; set; } = null!;

    public string Cmoneda { get; set; } = null!;

    public int Cafectable { get; set; }

    public string Csegmento { get; set; } = null!;
}
