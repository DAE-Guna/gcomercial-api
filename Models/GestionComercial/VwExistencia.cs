using System;
using System.Collections.Generic;

namespace gcomercial_api.Models.GestionComercial;

public partial class VwExistencia
{
    public string? Almacen { get; set; }

    public string? Sucursal { get; set; }

    public string? Codigo { get; set; }

    public string? Producto { get; set; }

    public int? Cantidad { get; set; }

    public string Region { get; set; } = null!;

    public string? UnidadDeNegocio { get; set; }

    public string? Proveedor { get; set; }

    public string? Departamento { get; set; }

    public string? Categoria { get; set; }

    public string? Subcategoria { get; set; }

    public string? Portafolio { get; set; }

    public string? Division { get; set; }

    public string? Marca { get; set; }

    public int? Cajas { get; set; }

    public decimal? Ieps { get; set; }

    public decimal? Iva { get; set; }

    public decimal? CostoSinImpuestos { get; set; }

    public decimal? Costo { get; set; }

    public decimal? ImporteSinImpuestos { get; set; }

    public decimal? Importe { get; set; }

    public decimal? Utilidad { get; set; }

    public decimal? Margen { get; set; }
}
