using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Kredit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransakcijaKreditaId { get; set; }

        [Required]
        [ForeignKey("Majstor")] 
        public int MajstorId { get; set; }
        public Majstor? Majstor { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Iznos { get; set; }

        [Required]
        public int BrojKupljenihKredita { get; set; }

        public DateTime DatumTransakcije { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        public string NacinPlacanja { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        public string StatusTransakcije { get; set; } = "U obradi";
    }
}
