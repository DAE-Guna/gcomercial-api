using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.General;

public partial class AdmPromocione
{
    public int Cidpromocion { get; set; }

    public string Ccodigopromocion { get; set; } = null!;

    public string Cnombrepromocion { get; set; } = null!;

    public DateTime Cfechainicio { get; set; }

    public DateTime Cfechafin { get; set; }

    public double Cvolumenminimo { get; set; }

    public double Cvolumenmaximo { get; set; }

    public double Cporcentajedescuento { get; set; }

    public int Cidvalorclasifcliente1 { get; set; }

    public int Cidvalorclasifcliente2 { get; set; }

    public int Cidvalorclasifcliente3 { get; set; }

    public int Cidvalorclasifcliente4 { get; set; }

    public int Cidvalorclasifcliente5 { get; set; }

    public int Cidvalorclasifcliente6 { get; set; }

    public int Cidvalorclasifproducto1 { get; set; }

    public int Cidvalorclasifproducto2 { get; set; }

    public int Cidvalorclasifproducto3 { get; set; }

    public int Cidvalorclasifproducto4 { get; set; }

    public int Cidvalorclasifproducto5 { get; set; }

    public int Cidvalorclasifproducto6 { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Ctipopromo { get; set; }

    public int Cidcptodoc { get; set; }

    public int Csubtipo { get; set; }

    public string Choraini { get; set; } = null!;

    public string Chorafin { get; set; } = null!;

    public int Ctipopro { get; set; }

    public int Cvala { get; set; }

    public int Cvalb { get; set; }

    public int Cdias { get; set; }

    public DateTime Cfechaalta { get; set; }

    public int Cstatus { get; set; }
}
