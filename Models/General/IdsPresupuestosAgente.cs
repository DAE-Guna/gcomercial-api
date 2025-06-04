using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class IdsPresupuestosAgente
{
    public int Id { get; set; }

    public int Cidagente { get; set; }

    public string Codigoagente { get; set; } = null!;

    public int Anio { get; set; }

    public int Mes { get; set; }

    public double Importe { get; set; }
}
