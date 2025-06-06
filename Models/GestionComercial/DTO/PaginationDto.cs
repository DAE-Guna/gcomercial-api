namespace gcomercial_api.Models.GestionComercial.DTO
{
    public class PaginationDto
    {
        public int Total { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public bool HasMore { get; set; }
    }
}
