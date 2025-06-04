using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmVistasConsulta
{
    public int Cidconsulta { get; set; }

    public int Cidsistema { get; set; }

    public int Cididioma { get; set; }

    public int Cidmodulo { get; set; }

    public int Ctipo { get; set; }

    public int Ccolumnasocultar { get; set; }

    public string Cnombreconsulta { get; set; } = null!;

    public string? Csentenciasql { get; set; }

    public int Cidempresa { get; set; }

    public string Cindice { get; set; } = null!;

    public int Cesdesis01 { get; set; }

    public string Cfiltros { get; set; } = null!;

    public int Cinicioarg { get; set; }

    public int Climitearg { get; set; }

    public int Corden { get; set; }
}
