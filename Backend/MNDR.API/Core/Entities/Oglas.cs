using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Oglas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OglasId { get; set; }

        [Required]
        [ForeignKey("Majstor")]
        public int MajstorId { get; set; }
        public Majstor? Majstor { get; set; }

        [Required]
        [StringLength(200)]
        public string Naslov { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public string Opis { get; set; } = string.Empty;

        public DateTime DatumObjave { get; set; } = DateTime.Now;

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Aktivan";

        public virtual ICollection<Razgovor>? Razgovori { get; set; }
        public virtual ICollection<Ugovor>? Ugovori { get; set; }
        public virtual ICollection<OglasKategorija>? OglasKategorije { get; set; }
    }
}
