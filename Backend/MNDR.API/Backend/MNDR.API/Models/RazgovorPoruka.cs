using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    public class RazgovorPoruka
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RazgovorPorukaId { get; set; }

        [Required]
        [ForeignKey("Razgovor")]
        public int RazgovorId { get; set; }
        public Razgovor? Razgovor { get; set; }

        [Required]
        [ForeignKey("Korisnik")] 
        public int PosiljaocId { get; set; }
        public Korisnik? Posiljaoc { get; set; }

        [Required]
        [StringLength(2000)]
        public string Sadrzaj { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Poslano"; 

        public DateTime VrijemeSlanja { get; set; } = DateTime.Now;
    }
}