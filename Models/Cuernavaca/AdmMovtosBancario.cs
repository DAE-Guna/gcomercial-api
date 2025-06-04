using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmMovtosBancario
{
    public string Ctransactionid { get; set; } = null!;

    public string Caccountid { get; set; } = null!;

    public int Cidcuenta { get; set; }

    public int Ciddocumento { get; set; }

    public DateTime Cfecha { get; set; }

    public string Cdescripcion { get; set; } = null!;

    public string Creferencia { get; set; } = null!;

    public double Cimporte { get; set; }

    public int Cestado { get; set; }

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Ctimestamp { get; set; } = null!;
}
