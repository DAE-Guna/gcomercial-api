using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmMovimientosCapa
{
    public int Cidautoincsql { get; set; }

    public int Cidmovimiento { get; set; }

    public int Cidcapa { get; set; }

    public DateTime Cfecha { get; set; }

    public double Cunidades { get; set; }

    public int Ctipocapa { get; set; }

    public int Cidunidad { get; set; }
}
