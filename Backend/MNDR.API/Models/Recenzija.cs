using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    public class Recenzija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecenzijaId { get; set; }

        [Required]
        [ForeignKey("Ugovor")]
        public int UgovorId { get; set; }
        public Ugovor? Ugovor { get; set; }

        [Required]
        [Range(1, 5)]
        public int Ocjena { get; set; }

        [StringLength(1000)]
        public string? Komentar { get; set; }

        public DateTime DatumRecenzije { get; set; } = DateTime.Now;
    }
}