using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmMovtosInvFisicoSerieCa
{
    public int Cidseriecapa { get; set; }

    public int Cidmovtoinventariofisico { get; set; }

    public int Cidproducto { get; set; }

    public string Cnumeroserie { get; set; } = null!;

    public int Cidalmacen { get; set; }

    public int Ctipo { get; set; }

    public string Cnumerolote { get; set; } = null!;

    public DateTime Cfechacaducidad { get; set; }

    public DateTime Cfechafabricacion { get; set; }

    public string Cpedimento { get; set; } = null!;

    public string Caduana { get; set; } = null!;

    public DateTime Cfechapedimento { get; set; }

    public double Ctipocambio { get; set; }

    public double Ccantidad { get; set; }

    public int Cidcapa { get; set; }
}
