using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    public class Badge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BadgeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Opis { get; set; }

        [StringLength(100)]
        public string? Ikona { get; set; }

        public virtual ICollection<BadgeNagrada>? BadgeNagrade { get; set; }
    }
}