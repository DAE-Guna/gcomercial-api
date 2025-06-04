using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmProductosDetalle
{
    public int Cidproducto { get; set; }

    public int Ctipoproducto { get; set; }

    public int Cidproductopadre { get; set; }

    public int Cidvalorcaracteristica1 { get; set; }

    public int Cidvalorcaracteristica2 { get; set; }

    public int Cidvalorcaracteristica3 { get; set; }

    public string Ctimestamp { get; set; } = null!;
}
