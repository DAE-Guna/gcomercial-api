using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Estatus
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Almacene> Almacenes { get; set; } = new List<Almacene>();
}
