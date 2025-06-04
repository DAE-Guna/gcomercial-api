using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class UnidadesNegocio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Proveedore> Proveedores { get; set; } = new List<Proveedore>();
}
