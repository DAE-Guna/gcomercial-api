using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class CamposConsultum
{
    public int Id { get; set; }

    public string? Modulo { get; set; }

    public string? Campo { get; set; }

    public int? Activo { get; set; }
}
