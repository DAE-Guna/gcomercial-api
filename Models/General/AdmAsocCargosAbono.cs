using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmAsocCargosAbono
{
    public int Cidautoincsql { get; set; }

    public int Ciddocumentoabono { get; set; }

    public int Ciddocumentocargo { get; set; }

    public double Cimporteabono { get; set; }

    public double Cimportecargo { get; set; }

    public DateTime Cfechaabonocargo { get; set; }

    public int Ciddescuentoprontopago { get; set; }

    public int Cidutilidadperdidacamb { get; set; }

    public int Cidajusiva { get; set; }
}
