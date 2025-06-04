using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwProducto
{
    public int IdProducto { get; set; }

    public string Codigo { get; set; } = null!;

    public int IdProveedor { get; set; }

    public string? Proveedor { get; set; }

    public int IdDepartamento { get; set; }

    public string Departamento { get; set; } = null!;

    public int IdCategoria { get; set; }

    public string Categoria { get; set; } = null!;

    public int IdSubcategoria { get; set; }

    public string Subcategoria { get; set; } = null!;

    public int IdPortafolio { get; set; }

    public string Portafolio { get; set; } = null!;

    public int IdDivision { get; set; }

    public string Division { get; set; } = null!;

    public int IdMarca { get; set; }

    public string Marca { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int UnidadXCaja { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Iva { get; set; }

    public decimal? CostoSinImpuestos { get; set; }

    public decimal CostoConImpuestos { get; set; }

    public decimal? PrecioSinImpuestos { get; set; }

    public decimal PrecioConImpuestos { get; set; }

    public bool? IdEstatus { get; set; }
}
