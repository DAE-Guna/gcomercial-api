using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmAgente
{
    public int Cidagente { get; set; }

    public string Ccodigoagente { get; set; } = null!;

    public string Cnombreagente { get; set; } = null!;

    public DateTime Cfechaaltaagente { get; set; }

    public int Ctipoagente { get; set; }

    public double Ccomisionventaagente { get; set; }

    public double Ccomisioncobroagente { get; set; }

    public int Cidcliente { get; set; }

    public int Cidproveedor { get; set; }

    public int Cidvalorclasificacion1 { get; set; }

    public int Cidvalorclasificacion2 { get; set; }

    public int Cidvalorclasificacion3 { get; set; }

    public int Cidvalorclasificacion4 { get; set; }

    public int Cidvalorclasificacion5 { get; set; }

    public int Cidvalorclasificacion6 { get; set; }

    public string Csegcontagente { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public string Cscagente2 { get; set; } = null!;

    public string Cscagente3 { get; set; } = null!;
}
