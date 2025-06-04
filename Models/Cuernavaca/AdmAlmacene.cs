using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmAlmacene
{
    public int Cidalmacen { get; set; }

    public string Ccodigoalmacen { get; set; } = null!;

    public string Cnombrealmacen { get; set; } = null!;

    public DateTime Cfechaaltaalmacen { get; set; }

    public int Cidvalorclasificacion1 { get; set; }

    public int Cidvalorclasificacion2 { get; set; }

    public int Cidvalorclasificacion3 { get; set; }

    public int Cidvalorclasificacion4 { get; set; }

    public int Cidvalorclasificacion5 { get; set; }

    public int Cidvalorclasificacion6 { get; set; }

    public string Csegcontalmacen { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public int Cbandomicilio { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public string Cscalmac2 { get; set; } = null!;

    public string Cscalmac3 { get; set; } = null!;

    public int Csistorig { get; set; }
}
