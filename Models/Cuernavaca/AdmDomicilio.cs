using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Cuernavaca;

public partial class AdmDomicilio
{
    public int Ciddireccion { get; set; }

    public int Cidcatalogo { get; set; }

    public int Ctipocatalogo { get; set; }

    public int Ctipodireccion { get; set; }

    public string Cnombrecalle { get; set; } = null!;

    public string Cnumeroexterior { get; set; } = null!;

    public string Cnumerointerior { get; set; } = null!;

    public string Ccolonia { get; set; } = null!;

    public string Ccodigopostal { get; set; } = null!;

    public string Ctelefono1 { get; set; } = null!;

    public string Ctelefono2 { get; set; } = null!;

    public string Ctelefono3 { get; set; } = null!;

    public string Ctelefono4 { get; set; } = null!;

    public string Cemail { get; set; } = null!;

    public string Cdireccionweb { get; set; } = null!;

    public string Cpais { get; set; } = null!;

    public string Cestado { get; set; } = null!;

    public string Cciudad { get; set; } = null!;

    public string Ctextoextra { get; set; } = null!;

    public string Ctimestamp { get; set; } = null!;

    public string Cmunicipio { get; set; } = null!;

    public string Csucursal { get; set; } = null!;
}
