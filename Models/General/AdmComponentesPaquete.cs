using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmComponentesPaquete
{
    public int Cidcomponente { get; set; }

    public int Cidpaquete { get; set; }

    public int Cidproducto { get; set; }

    public double Ccantidadproducto { get; set; }

    public int Cidvalorcaracteristica1 { get; set; }

    public int Cidvalorcaracteristica2 { get; set; }

    public int Cidvalorcaracteristica3 { get; set; }

    public int Ctipoproducto { get; set; }

    public int Cidunidadventa { get; set; }
}
