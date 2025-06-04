using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmCapasProducto
{
    public int Cidcapa { get; set; }

    public int Cidalmacen { get; set; }

    public int Cidproducto { get; set; }

    public DateTime Cfecha { get; set; }

    public int Ctipocapa { get; set; }

    public string Cnumerolote { get; set; } = null!;

    public DateTime Cfechacaducidad { get; set; }

    public DateTime Cfechafabricacion { get; set; }

    public string Cpedimento { get; set; } = null!;

    public string Caduana { get; set; } = null!;

    public DateTime Cfechapedimento { get; set; }

    public double Ctipocambio { get; set; }

    public double Cexistencia { get; set; }

    public double Ccosto { get; set; }

    public int Cidcapaorigen { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Cnumaduana { get; set; }

    public string Cclavesat { get; set; } = null!;
}
