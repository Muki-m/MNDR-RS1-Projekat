using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Kategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KategorijaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Opis { get; set; }

        public int? NadKategorijaId { get; set; }
        public Kategorija? NadKategorija { get; set; }

        public virtual ICollection<Kategorija>? Podkategorije { get; set; }
        public virtual ICollection<OglasKategorija>? OglasKategorije { get; set; }
    }
}