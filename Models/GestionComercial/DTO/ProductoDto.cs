namespace gcomercial_api.Models.GestionComercial.DTO
{
    public class ProductoDto
    {
        public int id_producto { get; set; }
        public string codigo { get; set; } = string.Empty;
        public int id_proveedor { get; set; }
        public string proveedor { get; set; } = string.Empty;
        public int id_departamento { get; set; }
        public string departamento { get; set; } = string.Empty;
        public int id_categoria { get; set; }
        public string categoria { get; set; } = string.Empty;
        public int id_subcategoria { get; set; }
        public string subcategoria { get; set; } = string.Empty;
        public int id_portafolio { get; set; }
        public string portafolio { get; set; } = string.Empty;
        public int id_division { get; set; }
        public string division { get; set; } = string.Empty;
        public int id_marca { get; set; }
        public string marca { get; set; } = string.Empty;
        public string descripcion { get; set; } = string.Empty;
        public int unidad_x_caja { get; set; }
        public decimal ieps { get; set; }
        public decimal iva { get; set; }
        public decimal costo_sin_impuestos { get; set; }
        public decimal costo_con_impuestos { get; set; }
        public decimal precio_sin_impuestos { get; set; }
        public decimal precio_con_impuestos { get; set; }
        public int id_estatus { get; set; }
    }
}
