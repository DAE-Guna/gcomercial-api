using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmVistasCampo
{
    public int Cidautoincsql { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public int Cidmodulo { get; set; }

    public string Cnombrenativotabla { get; set; } = null!;

    public string Cnombrenativocampo { get; set; } = null!;

    public string Cnombreamigablecampo { get; set; } = null!;

    public int Canchoca01 { get; set; }

    public int Ccampooc01 { get; set; }

    public int Ccampoor01 { get; set; }

    public int Ctipocampo { get; set; }

    public int Ccalculado { get; set; }

    public int Cdecimales { get; set; }

    public int Calinear { get; set; }

    public int Cformatear { get; set; }
}
