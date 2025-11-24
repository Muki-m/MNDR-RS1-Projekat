using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    public class Ugovor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UgovorId { get; set; }

        [Required]
        [ForeignKey("Oglas")]
        public int OglasId { get; set; }
        public Oglas? Oglas { get; set; }

        [Required]
        [ForeignKey("Kupac")]
        public int KupacId { get; set; }
        public Kupac? Kupac { get; set; }

        public DateTime DatumSklapanja { get; set; } = DateTime.Now;

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Aktivan";

        [StringLength(1000)]
        public string? OpisPosla { get; set; }

        public virtual ICollection<Recenzija>? Recenzije { get; set; }
    }
}