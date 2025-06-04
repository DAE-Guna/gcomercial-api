using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmDatosAddendum
{
    public int Cidautoincsql { get; set; }

    public int Idaddenda { get; set; }

    public int Tipocat { get; set; }

    public int Idcat { get; set; }

    public int Numcampo { get; set; }

    public string Valor { get; set; } = null!;
}
