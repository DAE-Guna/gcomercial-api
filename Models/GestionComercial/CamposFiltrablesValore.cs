using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class CamposFiltrablesValore
{
    public int Id { get; set; }

    public int IdCampo { get; set; }

    public string? Valor { get; set; }

    public string? Texto { get; set; }

    public virtual CamposFiltrable IdCampoNavigation { get; set; } = null!;
}
