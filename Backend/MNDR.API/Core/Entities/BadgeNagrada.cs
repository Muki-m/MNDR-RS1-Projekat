using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class BadgeNagrada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BadgeNagradaId { get; set; }

        [Required]
        [ForeignKey("Badge")]
        public int BadgeId { get; set; }
        public Badge? Badge { get; set; }

        [Required]
        [ForeignKey("Majstor")]
        public int MajstorId { get; set; }
        public Majstor? Majstor { get; set; }

        public DateTime DatumDodjele { get; set; } = DateTime.Now;
    }
}