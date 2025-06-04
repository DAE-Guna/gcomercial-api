using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmPreciosCompra
{
    public int Cidautoincsql { get; set; }

    public int Cidproducto { get; set; }

    public int Cidproveedor { get; set; }

    public double Cpreciocompra { get; set; }

    public int Cidmoneda { get; set; }

    public string Ccodigoproductoproveedor { get; set; } = null!;

    public int Cidunidad { get; set; }

    public string Ctimestamp { get; set; } = null!;
}
