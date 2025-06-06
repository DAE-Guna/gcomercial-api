namespace gcomercial_api.Models.GestionComercial.DTO
{
    public class BuscarAlmacenesResponseDto
    {
        public List<ProductoDto> Items { get; set; } = new List<ProductoDto>();
        public PaginationDto Pagination { get; set; } = new PaginationDto();
    }
}
