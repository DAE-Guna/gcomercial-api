using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class NubeDiario
{
    public string Ccodigo { get; set; } = null!;

    public string Cnombre { get; set; } = null!;

    public int Ctipo { get; set; }
}
