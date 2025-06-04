using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmMoneda
{
    public int Cidmoneda { get; set; }

    public string Cnombremoneda { get; set; } = null!;

    public string Csimbolomoneda { get; set; } = null!;

    public int Cposicionsimbolo { get; set; }

    public string Cplural { get; set; } = null!;

    public string Csingular { get; set; } = null!;

    public string Cdescripcionprotegida { get; set; } = null!;

    public int Cidbandera { get; set; }

    public int Cdecimalesmoneda { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public string Cclavesat { get; set; } = null!;
}
