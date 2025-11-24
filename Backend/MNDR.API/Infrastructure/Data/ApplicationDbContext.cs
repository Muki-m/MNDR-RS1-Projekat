using Microsoft.EntityFrameworkCore;
using MNDR.API.Core.Entities;

namespace MNDR.API.Infrastructure.Data
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
        public DbSet<Notifikacija> Notifikacije { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracija za Razgovor - riješi cascade problem
            modelBuilder.Entity<Razgovor>(entity =>
            {
                entity.HasOne(r => r.Kupac)
                    .WithMany(k => k.Razgovori)
                    .HasForeignKey(r => r.KupacId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(r => r.Majstor)
                    .WithMany(m => m.Razgovori)
                    .HasForeignKey(r => r.MajstorId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(r => r.Oglas)
                    .WithMany(o => o.Razgovori)
                    .HasForeignKey(r => r.OglasId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // Konfiguracija za RazgovorPoruka
            modelBuilder.Entity<RazgovorPoruka>(entity =>
            {
                entity.HasOne(rp => rp.Razgovor)
                    .WithMany(r => r.Poruke)
                    .HasForeignKey(rp => rp.RazgovorId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(rp => rp.Posiljaoc)
                    .WithMany()
                    .HasForeignKey(rp => rp.PosiljaocId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // Konfiguracija za Ugovor
            modelBuilder.Entity<Ugovor>(entity =>
            {
                entity.HasOne(u => u.Oglas)
                    .WithMany(o => o.Ugovori)
                    .HasForeignKey(u => u.OglasId)
                    .OnDelete(DeleteBehavior.NoAction);

                entity.HasOne(u => u.Kupac)
                    .WithMany(k => k.Ugovori)
                    .HasForeignKey(u => u.KupacId)
                    .OnDelete(DeleteBehavior.NoAction);
            });

            // Konfiguracija za Recenzija
            modelBuilder.Entity<Recenzija>(entity =>
            {
                entity.HasOne(r => r.Ugovor)
                    .WithMany(u => u.Recenzije)
                    .HasForeignKey(r => r.UgovorId)
                    .OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
