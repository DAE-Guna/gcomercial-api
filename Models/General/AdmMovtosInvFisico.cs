using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmMovtosInvFisico
{
    public int Cidmovimiento { get; set; }

    public int Cidproducto { get; set; }

    public int Cidalmacen { get; set; }

    public int Cidunidad { get; set; }

    public double Cunidades { get; set; }

    public double Cunidadesnc { get; set; }

    public double Cunidadescapturadas { get; set; }

    public int Cmovtooculto { get; set; }

    public int Cidmovtoowner { get; set; }
}
