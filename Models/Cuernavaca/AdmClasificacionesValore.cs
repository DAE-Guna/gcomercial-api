using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmClasificacionesValore
{
    public int Cidvalorclasificacion { get; set; }

    public string Cvalorclasificacion { get; set; } = null!;

    public int Cidclasificacion { get; set; }

    public string Ccodigovalorclasificacion { get; set; } = null!;

    public string Csegcont1 { get; set; } = null!;

    public string Csegcont2 { get; set; } = null!;

    public string Csegcont3 { get; set; } = null!;
}
