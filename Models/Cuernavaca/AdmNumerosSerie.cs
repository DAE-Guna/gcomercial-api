using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmNumerosSerie
{
    public int Cidserie { get; set; }

    public int Cidproducto { get; set; }

    public string Cnumeroserie { get; set; } = null!;

    public int Cidalmacen { get; set; }

    public int Cestado { get; set; }

    public int Cestadoanterior { get; set; }

    public string Cnumerolote { get; set; } = null!;

    public DateTime Cfechacaducidad { get; set; }

    public DateTime Cfechafabricacion { get; set; }

    public string Cpedimento { get; set; } = null!;

    public string Caduana { get; set; } = null!;

    public DateTime Cfechapedimento { get; set; }

    public double Ctipocambio { get; set; }

    public double Ccosto { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Cnumaduana { get; set; }

    public string Cclavesat { get; set; } = null!;
}
