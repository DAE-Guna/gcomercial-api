using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmProductosFoto
{
    public int Cidfotoproducto { get; set; }

    public string Cnombrefotoproducto { get; set; } = null!;

    public string? Cfotoproducto { get; set; }
}
