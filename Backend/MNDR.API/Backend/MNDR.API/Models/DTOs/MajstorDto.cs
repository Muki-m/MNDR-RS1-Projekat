namespace MNDR.API.Models.DTOs
{
    public class MajstorDto
    {
        public int MajstorId { get; set; }
        public string ImePrezime { get; set; } = string.Empty;
        public string Specijalizacija { get; set; } = string.Empty;
        public decimal ProsjecnaOcjena { get; set; }
        public int BrojZavrsenihPoslova { get; set; }
    }
}
