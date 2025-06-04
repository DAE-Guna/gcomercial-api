using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmVistasRecurso
{
    public int Cidautoincsql { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public int Cidmodulo { get; set; }

    public string Ctablabase { get; set; } = null!;

    public string Ctablarela { get; set; } = null!;

    public string Ccampobase { get; set; } = null!;

    public string Ccampoid { get; set; } = null!;

    public string Ctitulo0 { get; set; } = null!;

    public string Ccampo0 { get; set; } = null!;

    public string Cindice0 { get; set; } = null!;

    public int Cancho0 { get; set; }

    public string Ctitulo1 { get; set; } = null!;

    public string Ccampo1 { get; set; } = null!;

    public string Cindice1 { get; set; } = null!;

    public int Cancho1 { get; set; }

    public string Crango { get; set; } = null!;
}
