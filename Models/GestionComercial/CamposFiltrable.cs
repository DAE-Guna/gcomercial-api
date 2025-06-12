using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class CamposFiltrable
{
    public int Id { get; set; }

    public string Modulo { get; set; } = null!;

    public string Campo { get; set; } = null!;

    public bool Activo { get; set; }

    public virtual ICollection<CamposFiltrablesValore> CamposFiltrablesValores { get; set; } = new List<CamposFiltrablesValore>();
}
