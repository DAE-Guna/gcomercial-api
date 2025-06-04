using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Subcategoria
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
