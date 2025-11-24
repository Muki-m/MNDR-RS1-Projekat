using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Notifikacija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NotifikacijaID { get; set; }

        [Required]
        [ForeignKey("Korisnik")]
        public int KorisnikID { get; set; }
        public Korisnik? Korisnik { get; set; }

        [Required]
        [StringLength(50)]
        public string TipNotifikacije { get; set; } = "Sistem";

        [Required]
        [StringLength(1000)]
        public string Sadrzaj { get; set; } = string.Empty;

        public DateTime DatumSlanja { get; set; } = DateTime.Now;

        public bool Procitano { get; set; } = false;
    }
}
