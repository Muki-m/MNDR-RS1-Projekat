using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Korisnik
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikId { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(255)]
        public string Lozinka { get; set; } = string.Empty;

        [StringLength(20)]
        public string? Telefon { get; set; }

        [Required]
        [StringLength(20)]
        public string Uloga { get; set; } = "Kupac";

        public DateTime DatumRegistracije { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string? Grad { get; set; }

        [StringLength(50)]
        public string? Opcina { get; set; }

        [StringLength(500)]
        public string? OpisProfila { get; set; }

        [StringLength(255)]
        public string? SlikaProfila { get; set; }

        public virtual Administrator? Administrator { get; set; }

    }
}