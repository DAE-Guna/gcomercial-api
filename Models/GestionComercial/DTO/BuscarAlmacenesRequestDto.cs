namespace gcomercial_api.Models.GestionComercial.DTO
{
    public class BuscarAlmacenesRequestDto
    {
        public Dictionary<string, string[]> Filters { get; set; } = new Dictionary<string, string[]>();
    }
}
