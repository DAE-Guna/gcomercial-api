using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmProducto
{
    public int Cidproducto { get; set; }

    public string Ccodigoproducto { get; set; } = null!;

    public string Cnombreproducto { get; set; } = null!;

    public int Ctipoproducto { get; set; }

    public DateTime Cfechaaltaproducto { get; set; }

    public int Ccontrolexistencia { get; set; }

    public int Cidfotoproducto { get; set; }

    public string? Cdescripcionproducto { get; set; }

    public int Cmetodocosteo { get; set; }

    public double Cpesoproducto { get; set; }

    public double Ccomventaexcepproducto { get; set; }

    public double Ccomcobroexcepproducto { get; set; }

    public double Ccostoestandar { get; set; }

    public double Cmargenutilidad { get; set; }

    public int Cstatusproducto { get; set; }

    public int Cidunidadbase { get; set; }

    public int Cidunidadnoconvertible { get; set; }

    public DateTime Cfechabaja { get; set; }

    public double Cimpuesto1 { get; set; }

    public double Cimpuesto2 { get; set; }

    public double Cimpuesto3 { get; set; }

    public double Cretencion1 { get; set; }

    public double Cretencion2 { get; set; }

    public int Cidpadrecaracteristica1 { get; set; }

    public int Cidpadrecaracteristica2 { get; set; }

    public int Cidpadrecaracteristica3 { get; set; }

    public int Cidvalorclasificacion1 { get; set; }

    public int Cidvalorclasificacion2 { get; set; }

    public int Cidvalorclasificacion3 { get; set; }

    public int Cidvalorclasificacion4 { get; set; }

    public int Cidvalorclasificacion5 { get; set; }

    public int Cidvalorclasificacion6 { get; set; }

    public string Csegcontproducto1 { get; set; } = null!;

    public string Csegcontproducto2 { get; set; } = null!;

    public string Csegcontproducto3 { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public double Cprecio1 { get; set; }

    public double Cprecio2 { get; set; }

    public double Cprecio3 { get; set; }

    public double Cprecio4 { get; set; }

    public double Cprecio5 { get; set; }

    public double Cprecio6 { get; set; }

    public double Cprecio7 { get; set; }

    public double Cprecio8 { get; set; }

    public double Cprecio9 { get; set; }

    public double Cprecio10 { get; set; }

    public int Cbanunidades { get; set; }

    public int Cbancaracteristicas { get; set; }

    public int Cbanmetodocosteo { get; set; }

    public int Cbanmaxmin { get; set; }

    public int Cbanprecio { get; set; }

    public int Cbanimpuesto { get; set; }

    public int Cbancodigobarra { get; set; }

    public int Cbancomponente { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Cerrorcosto { get; set; }

    public DateTime Cfechaerrorcosto { get; set; }

    public double Cpreciocalculado { get; set; }

    public int Cestadoprecio { get; set; }

    public int Cbanubicacion { get; set; }

    public int Cesexento { get; set; }

    public int Cexistencianegativa { get; set; }

    public double Ccostoext1 { get; set; }

    public double Ccostoext2 { get; set; }

    public double Ccostoext3 { get; set; }

    public double Ccostoext4 { get; set; }

    public double Ccostoext5 { get; set; }

    public DateTime Cfeccosex1 { get; set; }

    public DateTime Cfeccosex2 { get; set; }

    public DateTime Cfeccosex3 { get; set; }

    public DateTime Cfeccosex4 { get; set; }

    public DateTime Cfeccosex5 { get; set; }

    public int Cmoncosex1 { get; set; }

    public int Cmoncosex2 { get; set; }

    public int Cmoncosex3 { get; set; }

    public int Cmoncosex4 { get; set; }

    public int Cmoncosex5 { get; set; }

    public int Cbancosex { get; set; }

    public int Cescuotai2 { get; set; }

    public int Cescuotai3 { get; set; }

    public int Cidunidadcompra { get; set; }

    public int Cidunidadventa { get; set; }

    public int Csubtipo { get; set; }

    public string Ccodaltern { get; set; } = null!;

    public string Cnomaltern { get; set; } = null!;

    public string Cdesccorta { get; set; } = null!;

    public int Cidmoneda { get; set; }

    public int Cusabascu { get; set; }

    public int Ctipopaque { get; set; }

    public int Cprecselec { get; set; }

    public int Cdesglosai2 { get; set; }

    public string Csegcontproducto4 { get; set; } = null!;

    public string Csegcontproducto5 { get; set; } = null!;

    public string Csegcontproducto6 { get; set; } = null!;

    public string Csegcontproducto7 { get; set; } = null!;

    public string Cctapred { get; set; } = null!;

    public int Cnodescomp { get; set; }

    public int Cidunixml { get; set; }

    public string Cclavesat { get; set; } = null!;

    public double Ccantidadfiscal { get; set; }
}
