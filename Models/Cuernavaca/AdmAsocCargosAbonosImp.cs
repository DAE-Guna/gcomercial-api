using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmAsocCargosAbonosImp
{
    public int Cidautoincsql { get; set; }

    public int Ciddocumentoabono { get; set; }

    public int Ciddocumentocargo { get; set; }

    public string Ctextotasa { get; set; } = null!;

    public double Cneto { get; set; }

    public double Ctasa { get; set; }

    public int Cesdetalle { get; set; }

    public int Ctipoimp01 { get; set; }

    public int Ctipofac01 { get; set; }

    public double Ctasacuota { get; set; }

    public int Cesreten01 { get; set; }

    public double Cproporc01 { get; set; }

    public string Cmetodopag { get; set; } = null!;

    public string Cobjimpu01 { get; set; } = null!;

    public int Ccomputa01 { get; set; }

    public string Cnomimploc { get; set; } = null!;
}
