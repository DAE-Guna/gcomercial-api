using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmMaximosMinimo
{
    public int Cidautoincsql { get; set; }

    public int Cidalmacen { get; set; }

    public int Cidproducto { get; set; }

    public int Cidproductopadre { get; set; }

    public double Cexistenciaminbase { get; set; }

    public double Cexistenciamaxbase { get; set; }

    public double Cexistminnoconvertible { get; set; }

    public double Cexistmaxnoconvertible { get; set; }

    public string Czona { get; set; } = null!;

    public string Cpasillo { get; set; } = null!;

    public string Canaquel { get; set; } = null!;

    public string Crepisa { get; set; } = null!;
}
