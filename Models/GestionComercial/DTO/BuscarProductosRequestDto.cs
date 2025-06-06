namespace gcomercial_api.Models.GestionComercial.DTO
{
    public class BuscarProductosRequestDto
    {
        public Dictionary<string, string[]> Filters { get; set; } = new Dictionary<string, string[]>();

    }
}
