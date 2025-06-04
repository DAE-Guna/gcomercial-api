using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmVistasTabla
{
    public int Cidautoincsql { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public int Cidmodulo { get; set; }

    public string Cnombrenativotabla { get; set; } = null!;

    public string Cnombreamigabletabla { get; set; } = null!;

    public int Corden { get; set; }

    public string Cindices { get; set; } = null!;
}
