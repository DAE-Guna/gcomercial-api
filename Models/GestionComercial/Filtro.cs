using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Filtro
{
    public int Id { get; set; }

    public string? Modulo { get; set; }

    public string? Field { get; set; }

    public string? Valor { get; set; }

    public string? Texto { get; set; }
}
