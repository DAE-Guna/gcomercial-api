using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmUnidadesMedidaPeso
{
    public int Cidunidad { get; set; }

    public string Cnombreunidad { get; set; } = null!;

    public string Cabreviatura { get; set; } = null!;

    public string Cdespliegue { get; set; } = null!;

    public string Cclaveint { get; set; } = null!;

    public string Cclavesat { get; set; } = null!;
}
