using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmDocumentosModelo
{
    public int Ciddocumentode { get; set; }

    public string Cdescripcion { get; set; } = null!;

    public int Cnaturaleza { get; set; }

    public int Cafectaexistencia { get; set; }

    public int Cmodulo { get; set; }

    public double Cnofolio { get; set; }

    public int Cidconceptodoctoasumido { get; set; }

    public int Cusacliente { get; set; }

    public int Cusaproveedor { get; set; }

    public int Cidasientocontable { get; set; }
}
