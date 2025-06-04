using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmCostosHistorico
{
    public int Cidcostoh { get; set; }

    public int Cidproducto { get; set; }

    public int Cidalmacen { get; set; }

    public DateTime Cfechacostoh { get; set; }

    public double Ccostoh { get; set; }

    public double Cultimocostoh { get; set; }

    public int Cidmovimiento { get; set; }

    public string Ctimestamp { get; set; } = null!;
}
