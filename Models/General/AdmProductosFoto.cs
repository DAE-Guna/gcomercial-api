using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmProductosFoto
{
    public int Cidfotoproducto { get; set; }

    public string Cnombrefotoproducto { get; set; } = null!;

    public string? Cfotoproducto { get; set; }
}
