using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmBandera
{
    public int Cidbandera { get; set; }

    public string Cnombrebandera { get; set; } = null!;

    public string? Cbandera { get; set; }

    public string Cclaveiso { get; set; } = null!;
}
