using Microsoft.EntityFrameworkCore;
using MNDR.API.Core.Entities;
using MNDR.API.Core.Interfaces;
using MNDR.API.Infrastructure.Data;

namespace MNDR.API.Infrastructure.Data.Repositories
{
    public class NotifikacijaRepository : INotifikacijaRepository
    {
        private readonly ApplicationDbContext _context;

        public NotifikacijaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Notifikacija?> GetByIdAsync(int id)
        {
            return await _context.Notifikacije.FindAsync(id);
        }

        public async Task<IEnumerable<Notifikacija>> GetAllAsync()
        {
            return await _context.Notifikacije.ToListAsync();
        }

        public async Task<IEnumerable<Notifikacija>> GetByKorisnikIdAsync(int korisnikId)
        {
            return await _context.Notifikacije
                .Where(n => n.KorisnikID == korisnikId)
                .OrderByDescending(n => n.DatumSlanja)
                .ToListAsync();
        }

        public async Task<IEnumerable<Notifikacija>> GetNeprocitaneByKorisnikIdAsync(int korisnikId)
        {
            return await _context.Notifikacije
                .Where(n => n.KorisnikID == korisnikId && !n.Procitano)
                .OrderByDescending(n => n.DatumSlanja)
                .ToListAsync();
        }

        public async Task<Notifikacija> AddAsync(Notifikacija entity)
        {
            _context.Notifikacije.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateAsync(Notifikacija entity)
        {
            _context.Notifikacije.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Notifikacija entity)
        {
            _context.Notifikacije.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task MarkAsReadAsync(int notifikacijaId)
        {
            var notifikacija = await _context.Notifikacije.FindAsync(notifikacijaId);
            if (notifikacija != null)
            {
                notifikacija.Procitano = true;
                await _context.SaveChangesAsync();
            }
        }
    }
}
