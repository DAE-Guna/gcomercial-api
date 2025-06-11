using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwAlmacene
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public string? Sucursal { get; set; }

    public int? IdRegion { get; set; }

    public string Region { get; set; } = null!;

    public int? IdEstatus { get; set; }

    public string? Estatus { get; set; }
}
