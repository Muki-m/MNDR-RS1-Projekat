using Microsoft.EntityFrameworkCore;
using MNDR.API.Models;

namespace MNDR.API.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Badge> Badges { get; set; }
        public DbSet<Oglas> Oglasi { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Kupac> Kupci { get; set; }
        public DbSet<Majstor> Majstori { get; set; }
        public DbSet<OglasKategorija> OglasKategorije { get; set; }
        public DbSet<Kategorija> Kategorije { get; set; }
        public DbSet<Recenzija> Recenzije { get; set; }
        public DbSet<Razgovor> Razgovori { get; set; }
        public DbSet<RazgovorPoruka> RazgovorPoruke { get; set; }
        public DbSet<Ugovor> Ugovori { get; set; }
        public DbSet<BadgeNagrada> BadgeNagrade { get; set; }
        public DbSet<Kredit> Krediti { get; set; }
        public DbSet<Administrator> Administratori { get; set; }

       
    }
}
