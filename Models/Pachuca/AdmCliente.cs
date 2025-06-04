using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.Pachuca;

public partial class AdmCliente
{
    public int Cidclienteproveedor { get; set; }

    public string Ccodigocliente { get; set; } = null!;

    public string Crazonsocial { get; set; } = null!;

    public DateTime Cfechaalta { get; set; }

    public string Crfc { get; set; } = null!;

    public string Ccurp { get; set; } = null!;

    public string Cdencomercial { get; set; } = null!;

    public string Creplegal { get; set; } = null!;

    public int Cidmoneda { get; set; }

    public int Clistapreciocliente { get; set; }

    public double Cdescuentodocto { get; set; }

    public double Cdescuentomovto { get; set; }

    public int Cbanventacredito { get; set; }

    public int Cidvalorclasifcliente1 { get; set; }

    public int Cidvalorclasifcliente2 { get; set; }

    public int Cidvalorclasifcliente3 { get; set; }

    public int Cidvalorclasifcliente4 { get; set; }

    public int Cidvalorclasifcliente5 { get; set; }

    public int Cidvalorclasifcliente6 { get; set; }

    public int Ctipocliente { get; set; }

    public int Cestatus { get; set; }

    public DateTime Cfechabaja { get; set; }

    public DateTime Cfechaultimarevision { get; set; }

    public double Climitecreditocliente { get; set; }

    public int Cdiascreditocliente { get; set; }

    public int Cbanexcedercredito { get; set; }

    public double Cdescuentoprontopago { get; set; }

    public int Cdiasprontopago { get; set; }

    public double Cinteresmoratorio { get; set; }

    public int Cdiapago { get; set; }

    public int Cdiasrevision { get; set; }

    public string Cmensajeria { get; set; } = null!;

    public string Ccuentamensajeria { get; set; } = null!;

    public int Cdiasembarquecliente { get; set; }

    public int Cidalmacen { get; set; }

    public int Cidagenteventa { get; set; }

    public int Cidagentecobro { get; set; }

    public int Crestriccionagente { get; set; }

    public double Cimpuesto1 { get; set; }

    public double Cimpuesto2 { get; set; }

    public double Cimpuesto3 { get; set; }

    public double Cretencioncliente1 { get; set; }

    public double Cretencioncliente2 { get; set; }

    public int Cidvalorclasifproveedor1 { get; set; }

    public int Cidvalorclasifproveedor2 { get; set; }

    public int Cidvalorclasifproveedor3 { get; set; }

    public int Cidvalorclasifproveedor4 { get; set; }

    public int Cidvalorclasifproveedor5 { get; set; }

    public int Cidvalorclasifproveedor6 { get; set; }

    public double Climitecreditoproveedor { get; set; }

    public int Cdiascreditoproveedor { get; set; }

    public int Ctiempoentrega { get; set; }

    public int Cdiasembarqueproveedor { get; set; }

    public double Cimpuestoproveedor1 { get; set; }

    public double Cimpuestoproveedor2 { get; set; }

    public double Cimpuestoproveedor3 { get; set; }

    public double Cretencionproveedor1 { get; set; }

    public double Cretencionproveedor2 { get; set; }

    public int Cbaninteresmoratorio { get; set; }

    public double Ccomventaexcepcliente { get; set; }

    public double Ccomcobroexcepcliente { get; set; }

    public int Cbanproductoconsignacion { get; set; }

    public string Csegcontcliente1 { get; set; } = null!;

    public string Csegcontcliente2 { get; set; } = null!;

    public string Csegcontcliente3 { get; set; } = null!;

    public string Csegcontcliente4 { get; set; } = null!;

    public string Csegcontcliente5 { get; set; } = null!;

    public string Csegcontcliente6 { get; set; } = null!;

    public string Csegcontcliente7 { get; set; } = null!;

    public string Csegcontproveedor1 { get; set; } = null!;

    public string Csegcontproveedor2 { get; set; } = null!;

    public string Csegcontproveedor3 { get; set; } = null!;

    public string Csegcontproveedor4 { get; set; } = null!;

    public string Csegcontproveedor5 { get; set; } = null!;

    public string Csegcontproveedor6 { get; set; } = null!;

    public string Csegcontproveedor7 { get; set; } = null!;

    public string Ctextoextra1 { get; set; } = null!;

    public string Ctextoextra2 { get; set; } = null!;

    public string Ctextoextra3 { get; set; } = null!;

    public DateTime Cfechaextra { get; set; }

    public double Cimporteextra1 { get; set; }

    public double Cimporteextra2 { get; set; }

    public double Cimporteextra3 { get; set; }

    public double Cimporteextra4 { get; set; }

    public int Cbandomicilio { get; set; }

    public int Cbancreditoycobranza { get; set; }

    public int Cbanenvio { get; set; }

    public int Cbanagente { get; set; }

    public int Cbanimpuesto { get; set; }

    public int Cbanprecio { get; set; }

    public string Ctimestamp { get; set; } = null!;

    public int Cfacterc01 { get; set; }

    public double Ccomventa { get; set; }

    public double Ccomcobro { get; set; }

    public int Cidmoneda2 { get; set; }

    public string Cemail1 { get; set; } = null!;

    public string Cemail2 { get; set; } = null!;

    public string Cemail3 { get; set; } = null!;

    public int Ctipoentre { get; set; }

    public int Cconcteema { get; set; }

    public int Cftoaddend { get; set; }

    public int Cidcertcte { get; set; }

    public int Cencripent { get; set; }

    public int Cbancfd { get; set; }

    public string Ctextoextra4 { get; set; } = null!;

    public string Ctextoextra5 { get; set; } = null!;

    public double Cimporteextra5 { get; set; }

    public int Cidaddenda { get; set; }

    public string Ccodprovco { get; set; } = null!;

    public int Cenvacuse { get; set; }

    public string Ccon1nom { get; set; } = null!;

    public string Ccon1tel { get; set; } = null!;

    public int Cquitablan { get; set; }

    public int Cfmtoentre { get; set; }

    public int Cidcomplem { get; set; }

    public int Cdesglosai2 { get; set; }

    public int Climdoctos { get; set; }

    public string Csitioftp { get; set; } = null!;

    public string Cusrftp { get; set; } = null!;

    public string Cmetodopag { get; set; } = null!;

    public string Cnumctapag { get; set; } = null!;

    public int Cidcuenta { get; set; }

    public string Cusocfdi { get; set; } = null!;

    public string Cregimfisc { get; set; } = null!;

    public string Cwhatsapp { get; set; } = null!;
}
