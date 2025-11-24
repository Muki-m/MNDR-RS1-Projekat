using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class OglasKategorija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OglasKategorijaId { get; set; }

        [Required]
        [ForeignKey("Oglas")]
        public int OglasId { get; set; }
        public Oglas? Oglas { get; set; }

        [Required]
        [ForeignKey("Kategorija")]
        public int KategorijaId { get; set; }
        public Kategorija? Kategorija { get; set; }
    }
}