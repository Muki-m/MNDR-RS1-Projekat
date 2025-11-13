using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    [Table("Majstori")]
    public class Majstor : Korisnik
    {
        [StringLength(500)]
        public string? DetaljanOpisProfila { get; set; }

        public int GodineIskustva { get; set; } = 0;

        [Column(TypeName = "decimal(3,2)")]
        public decimal ProsjecnaOcjena { get; set; } = 0.0m;

        public int BrojZavrsenihPoslova { get; set; } = 0;

        [Required]
        [StringLength(100)]
        public string Specijalizacija { get; set; } = string.Empty;

        public int UkupanBrojKredita { get; set; } = 0;

        public void DodajOcjenu(decimal novaOcjena)
        {
            if (BrojZavrsenihPoslova == 0)
            {
                ProsjecnaOcjena = novaOcjena;
                BrojZavrsenihPoslova = 1;
            }
            else
            {
                decimal ukupno = ProsjecnaOcjena * BrojZavrsenihPoslova + novaOcjena;
                BrojZavrsenihPoslova++;
                ProsjecnaOcjena = ukupno / BrojZavrsenihPoslova;
            }
        }
        public virtual ICollection<BadgeNagrada>? BadgeNagrade { get; set; }
        public virtual ICollection<Oglas>? Oglasi { get; set; }
        public virtual ICollection<Kredit>? Krediti { get; set; }
    }
}