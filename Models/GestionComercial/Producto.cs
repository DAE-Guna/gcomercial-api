using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class Producto
{
    public int Id { get; set; }

    public int IdProveedor { get; set; }

    public int IdDepartamento { get; set; }

    public int IdCategoria { get; set; }

    public int IdSubcategoria { get; set; }

    public int IdPortafolio { get; set; }

    public int IdDivision { get; set; }

    public int IdMarca { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int UnidadXCaja { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Iva { get; set; }

    public decimal? CostoSinImpuestos { get; set; }

    public decimal CostoFinalXPieza { get; set; }

    public decimal? PrecioSinImpuestos { get; set; }

    public decimal PrecioFinal { get; set; }

    public bool? IdEstatus { get; set; }

    public virtual Categoria IdCategoriaNavigation { get; set; } = null!;

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;

    public virtual Divisione IdDivisionNavigation { get; set; } = null!;

    public virtual Marca IdMarcaNavigation { get; set; } = null!;

    public virtual Portafolio IdPortafolioNavigation { get; set; } = null!;

    public virtual Proveedore IdProveedorNavigation { get; set; } = null!;

    public virtual Subcategoria IdSubcategoriaNavigation { get; set; } = null!;
}
