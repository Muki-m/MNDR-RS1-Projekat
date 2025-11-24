using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MNDR.API.Models
{
    [Table("Kupci")]
    public class Kupac : Korisnik
    {
        public int BrojNarudzbi { get; set; } = 0;

        [Column(TypeName = "decimal(3,2)")]
        public decimal OcjenaPouzdanosti { get; set; } = 5.0m;

        public void PovecajBrojNarudzbi()
        {
            BrojNarudzbi++;
        }

        public void AzurirajOcjenuPouzdanosti(decimal novaOcjena)
        {
            OcjenaPouzdanosti = novaOcjena;
        }
        public virtual ICollection<Ugovor>? Ugovori { get; set; }
        public virtual ICollection<Razgovor>? Razgovori { get; set; }
    }
}