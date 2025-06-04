using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Proveedore
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombre { get; set; }

    public int? IdUnidadNegocio { get; set; }

    public int? DiasEntrega { get; set; }

    public bool? IdEstatus { get; set; }

    public virtual UnidadesNegocio? IdUnidadNegocioNavigation { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
