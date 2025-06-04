using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmFoliosDigitale
{
    public int Cidfoldig { get; set; }

    public int Ciddoctode { get; set; }

    public int Cidcptodoc { get; set; }

    public int Ciddocto { get; set; }

    public int Ciddocaldi { get; set; }

    public int Cidfirmarl { get; set; }

    public int Cnoorden { get; set; }

    public string Cserie { get; set; } = null!;

    public double Cfolio { get; set; }

    public int Cnoaprob { get; set; }

    public DateTime Cfecaprob { get; set; }

    public int Cestado { get; set; }

    public int Centregado { get; set; }

    public DateTime Cfechaemi { get; set; }

    public string Choraemi { get; set; } = null!;

    public string Cemail { get; set; } = null!;

    public string Carchdidis { get; set; } = null!;

    public int Cidcptoori { get; set; }

    public DateTime Cfechacanc { get; set; }

    public string Choracanc { get; set; } = null!;

    public int Cestrad { get; set; }

    public string? Ccadpedi { get; set; }

    public string Carchcbb { get; set; } = null!;

    public DateTime Cinivig { get; set; }

    public DateTime Cfinvig { get; set; }

    public string Ctipo { get; set; } = null!;

    public string Cserierec { get; set; } = null!;

    public double? Cfoliorec { get; set; }

    public string Crfc { get; set; } = null!;

    public string Crazon { get; set; } = null!;

    public int Csisorigen { get; set; }

    public int Cejerpol { get; set; }

    public int Cperpol { get; set; }

    public int Ctipopol { get; set; }

    public int Cnumpol { get; set; }

    public string Ctipoldesc { get; set; } = null!;

    public double Ctotal { get; set; }

    public string Caliasbdct { get; set; } = null!;

    public int Ccfdprueba { get; set; }

    public string Cdesestado { get; set; } = null!;

    public int Cpagadoban { get; set; }

    public string Cdespagban { get; set; } = null!;

    public string Creferen01 { get; set; } = null!;

    public string Cobserva01 { get; set; } = null!;

    public string Ccodconcba { get; set; } = null!;

    public string Cdesconcba { get; set; } = null!;

    public string Cnumctaban { get; set; } = null!;

    public string Cfolioban { get; set; } = null!;

    public int Ciddocdeba { get; set; }

    public string Cusuautban { get; set; } = null!;

    public string Cuuid { get; set; } = null!;

    public string Cusuban01 { get; set; } = null!;

    public int Cautusba01 { get; set; }

    public string Cusuban02 { get; set; } = null!;

    public int Cautusba02 { get; set; }

    public string Cusuban03 { get; set; } = null!;

    public int Cautusba03 { get; set; }

    public string Cdescaut01 { get; set; } = null!;

    public string Cdescaut02 { get; set; } = null!;

    public string Cdescaut03 { get; set; } = null!;

    public int Cerrorval { get; set; }

    public string Cacusecan { get; set; } = null!;

    public string Ciddoctodsl { get; set; } = null!;
}
