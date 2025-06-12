using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwProveedore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? IdUnidadNegocio { get; set; }

    public string UnidadNegocio { get; set; } = null!;

    public int? DiasEntrega { get; set; }

    public bool? IdEstatus { get; set; }

    public string? Estatus { get; set; }
}
