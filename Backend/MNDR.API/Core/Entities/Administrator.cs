using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Core.Entities
{
    public class Administrator
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdministratorId { get; set; }

        [Required]
        [StringLength(50)]
        public string NivoPristupa { get; set; } = "Osnovni";

        [Required]
        [ForeignKey("Korisnik")]
        public int KorisnikId { get; set; }
        public Korisnik? Korisnik { get; set; }

        public DateTime DatumDodavanja { get; set; } = DateTime.Now;

        public bool Aktivan { get; set; } = true;

    }
}