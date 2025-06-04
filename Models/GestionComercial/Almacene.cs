using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Almacene
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? BaseId { get; set; }

    public string? Sucursal { get; set; }

    public int? IdRegion { get; set; }

    public bool? IdEstatus { get; set; }
}
