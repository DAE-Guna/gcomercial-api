using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmConversionesUnidad
{
    public int Cidautoincsql { get; set; }

    public int Cidunidad1 { get; set; }

    public int Cidunidad2 { get; set; }

    public double Cfactorconversion { get; set; }

    public string Cexpresionfactor { get; set; } = null!;
}
