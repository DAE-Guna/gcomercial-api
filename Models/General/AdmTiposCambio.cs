using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmTiposCambio
{
    public int Cidtipocambio { get; set; }

    public int Cidmoneda { get; set; }

    public DateTime Cfecha { get; set; }

    public double Cimporte { get; set; }

    public string Ctimestamp { get; set; } = null!;
}
