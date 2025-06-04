using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmVistasPorModulo
{
    public int Cidautoincsql { get; set; }

    public int Cidmodulo { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public string Cnombremodulo { get; set; } = null!;

    public int Caspecto { get; set; }

    public int Cactualiza { get; set; }
}
