using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    public class Razgovor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RazgovorId { get; set; }

        [Required]
        [ForeignKey("Kupac")] 
        public int KupacId { get; set; }
        public Kupac? Kupac { get; set; }

        [Required]
        [ForeignKey("Majstor")] 
        public int MajstorId { get; set; }
        public Majstor? Majstor { get; set; }

        [Required]
        [ForeignKey("Oglas")] 
        public int OglasId { get; set; }
        public Oglas? Oglas { get; set; }

        public DateTime DatumKreiranja { get; set; } = DateTime.Now;
        public DateTime DatumUpdate { get; set; } = DateTime.Now;
        public DateTime? DatumZavrsetka { get; set; }

        public virtual ICollection<RazgovorPoruka>? Poruke { get; set; }
    }
}