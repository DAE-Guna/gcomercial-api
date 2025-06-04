using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class OrdenCompraEstatus
{
    public int Id { get; set; }

    public int IdDocumento { get; set; }

    public int IdEstatus { get; set; }

    public DateTime FechaCreacion { get; set; }

    public DateTime FechaActualizacion { get; set; }
}
