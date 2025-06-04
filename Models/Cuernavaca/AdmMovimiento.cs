using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmMovimiento
{
    public int Cidmovimiento { get; set; }

    public int Ciddocumento { get; set; }

    public double Cnumeromovimiento { get; set; }

    public int Ciddocumentode { get; set; }

    public int Cidproducto { get; set; }

    public int Cidalmacen { get; set; }

    public double Cunidades { get; set; }

    public double Cunidadesnc { get; set; }

    public double Cunidadescapturadas { get; set; }

    public int Cidunidad { get; set; }

    public int Cidunidadnc { get; set; }

    public double Cprecio { get; set; }

    public double Cpreciocapturado { get; set; }

    public double Ccostocapturado { get; set; }

    public double Ccostoespecifico { get; set; }

    public double Cneto { get; set; }

    public double Cimpuesto1 { get; set; }

    public double Cporcentajeimpuesto1 { get; set; }

    public double Cimpuesto2 { get; set; }

    public double Cporcentajeimpuesto2 { get; set; }

    public double Cimpuesto3 { get; set; }

    public double Cporcentajeimpuesto3 { get; set; }

    public double Cretencion1 { get; set; }

    public double Cporcentajeretencion1 { get; set; }

    public double Cretencion2 { get; set; }

    public double Cporcentajeretencion2 { get; set; }

    public double Cdescuento1 { get; set; }

    public double Cporcentajedescuento1 { get; set; }

    public double Cdescuento2 { get; set; }

    public double Cporcentajedescuento2 { get; set; }

    public double Cdescuento3 { get; set; }

    public double Cporcentajedescuento3 { get; set; }

    public double Cdescuento4 { get; set; }

    public double Cporcentajedescuento4 { get; set; }

    public double Cdescuento5 { get; set; }

    public double Cporcentajedescuento5 { get; set; }

    public double Ctotal { get; set; }

    public double Cporcentajecomision { get; set; }

    public string Creferencia { get; set; } = null!;

    public string? Cobservamov { get; set; }

    public int Cafectaexistencia { get; set; }

    public int Cafectadosaldos { get; set; }

    public int Cafectadoinventario { get; set; }

    public DateTime Cfecha { get; set; }

    public int Cmovtooculto { get; set; }

    public int Cidmovtoowner { get; set; }

    public int Cidmovtoorigen { get; set; }

    public double Cunidadespendientes { get; set; }

    public double Cunidadesncpendientes { get; set; }

    public double Cunidadesorigen { get; set; }

    public double Cunidadesncorigen { get; set; }

    public int Ctipotraspaso { get; set; }

    public int Cidvalorclasificacion { get; set; }

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public double Cgtomovto { get; set; }

    public string Cscmovto { get; set; } = null!;

    public double Ccomventa { get; set; }

    public int Cidmovtodestino { get; set; }

    public int Cnumeroconsolidaciones { get; set; }

    public string Cobjimpu01 { get; set; } = null!;
}
