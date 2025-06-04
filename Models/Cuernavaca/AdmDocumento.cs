using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmDocumento
{
    public int Ciddocumento { get; set; }

    public int Ciddocumentode { get; set; }

    public int Cidconceptodocumento { get; set; }

    public string Cseriedocumento { get; set; } = null!;

    public double Cfolio { get; set; }

    public DateTime Cfecha { get; set; }

    public int Cidclienteproveedor { get; set; }

    public string Crazonsocial { get; set; } = null!;

    public string Crfc { get; set; } = null!;

    public int Cidagente { get; set; }

    public DateTime Cfechavencimiento { get; set; }

    public DateTime Cfechaprontopago { get; set; }

    public DateTime Cfechaentregarecepcion { get; set; }

    public DateTime Cfechaultimointeres { get; set; }

    public int Cidmoneda { get; set; }

    public double Ctipocambio { get; set; }

    public string Creferencia { get; set; } = null!;

    public string? Cobservaciones { get; set; }

    public int Cnaturaleza { get; set; }

    public int Ciddocumentoorigen { get; set; }

    public int Cplantilla { get; set; }

    public int Cusacliente { get; set; }

    public int Cusaproveedor { get; set; }

    public int Cafectado { get; set; }

    public int Cimpreso { get; set; }

    public int Ccancelado { get; set; }

    public int Cdevuelto { get; set; }

    public int Cidprepoliza { get; set; }

    public int Cidprepolizacancelacion { get; set; }

    public int Cestadocontable { get; set; }

    public double Cneto { get; set; }

    public double Cimpuesto1 { get; set; }

    public double Cimpuesto2 { get; set; }

    public double Cimpuesto3 { get; set; }

    public double Cretencion1 { get; set; }

    public double Cretencion2 { get; set; }

    public double Cdescuentomov { get; set; }

    public double Cdescuentodoc1 { get; set; }

    public double Cdescuentodoc2 { get; set; }

    public double Cgasto1 { get; set; }

    public double Cgasto2 { get; set; }

    public double Cgasto3 { get; set; }

    public double Ctotal { get; set; }

    public double Cpendiente { get; set; }

    public double Ctotalunidades { get; set; }

    public double Cdescuentoprontopago { get; set; }

    public double Cporcentajeimpuesto1 { get; set; }

    public double Cporcentajeimpuesto2 { get; set; }

    public double Cporcentajeimpuesto3 { get; set; }

    public double Cporcentajeretencion1 { get; set; }

    public double Cporcentajeretencion2 { get; set; }

    public double Cporcentajeinteres { get; set; }

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Cdestinatario { get; set; } = null!;

    public string Cnumeroguia { get; set; } = null!;

    public string Cmensajeria { get; set; } = null!;

    public string Ccuentamensajeria { get; set; } = null!;

    public double Cnumerocajas { get; set; }

    public double Cpeso { get; set; }

    public int Cbanobservaciones { get; set; }

    public int Cbandatosenvio { get; set; }

    public int Cbancondicionescredito { get; set; }

    public int Cbangastos { get; set; }

    public double Cunidadespendientes { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public double Cimpcheqpaq { get; set; }

    public int Csistorig { get; set; }

    public int Cidmonedca { get; set; }

    public double Ctipocamca { get; set; }

    public int Cescfd { get; set; }

    public int Ctienecfd { get; set; }

    public string Clugarexpe { get; set; } = null!;

    public string Cmetodopag { get; set; } = null!;

    public int Cnumparcia { get; set; }

    public int Ccantparci { get; set; }

    public string Ccondipago { get; set; } = null!;

    public string Cnumctapag { get; set; } = null!;

    public string Cguiddocumento { get; set; } = null!;

    public string Cusuario { get; set; } = null!;

    public int Cidproyecto { get; set; }

    public int Cidcuenta { get; set; }

    public string Ctransactionid { get; set; } = null!;

    public int Cidcopiade { get; set; }

    public string Cveresque { get; set; } = null!;
}
