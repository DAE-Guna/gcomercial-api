using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmCaracteristicasValore
{
    public int Cidvalorcaracteristica { get; set; }

    public int Cidpadrecaracteristica { get; set; }

    public string Cvalorcaracteristica { get; set; } = null!;

    public string Cnemocaracteristica { get; set; } = null!;
}
