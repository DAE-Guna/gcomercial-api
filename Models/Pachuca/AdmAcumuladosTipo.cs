using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmAcumuladosTipo
{
    public int Cidtipoacumulado { get; set; }

    public string Cnombre { get; set; } = null!;

    public int Ctipoowner1 { get; set; }

    public int Ctipoowner2 { get; set; }

    public int Ctipoactualizacion { get; set; }

    public int Ctipomoneda { get; set; }
}
