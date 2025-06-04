using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmVistasRelacione
{
    public int Cidrelacion { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public string Cnombrenativotabla1 { get; set; } = null!;

    public string Cnombrenativotabla2 { get; set; } = null!;

    public string Cnombrerelacion { get; set; } = null!;

    public string Csentenciaenlace { get; set; } = null!;

    public string Ccampona01 { get; set; } = null!;

    public string Cfiltro { get; set; } = null!;

    public string Ctablarel1 { get; set; } = null!;

    public string Ctablarel2 { get; set; } = null!;

    public string Cfiltroaux { get; set; } = null!;
}
