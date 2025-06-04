using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmProyecto
{
    public int Cidproyecto { get; set; }

    public string Ccodigoproyecto { get; set; } = null!;

    public string Cnombreproyecto { get; set; } = null!;

    public DateTime Cfechaalta { get; set; }

    public DateTime Cfechabaja { get; set; }

    public int Cestatus { get; set; }

    public int Cidvalorclasificacion1 { get; set; }

    public int Cidvalorclasificacion2 { get; set; }

    public int Cidvalorclasificacion3 { get; set; }

    public int Cidvalorclasificacion4 { get; set; }

    public int Cidvalorclasificacion5 { get; set; }

    public int Cidvalorclasificacion6 { get; set; }

    public double Cimporte1 { get; set; }

    public double Cimporte2 { get; set; }

    public string Csegcont1 { get; set; } = null!;

    public string Csegcont2 { get; set; } = null!;

    public string Csegcont3 { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Ctipocatalogo { get; set; }

    public int Cidcatalogo { get; set; }
}
