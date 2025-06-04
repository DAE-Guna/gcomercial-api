using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmBitacora
{
    public int Idbitacora { get; set; }

    public DateTime Fecha { get; set; }

    public string Hora { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Usuario2 { get; set; } = null!;

    public string Nombre2 { get; set; } = null!;

    public string Proceso { get; set; } = null!;

    public string Datos { get; set; } = null!;

    public int Idsistema { get; set; }

    public string Ctextoex01 { get; set; } = null!;

    public string Ctextoex02 { get; set; } = null!;

    public string Ctextoex03 { get; set; } = null!;

    public DateTime Cfechaex01 { get; set; }

    public double Cimporte01 { get; set; }

    public double Cimporte02 { get; set; }

    public double Cimporte03 { get; set; }

    public string Equipo { get; set; } = null!;
}
