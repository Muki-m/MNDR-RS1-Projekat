using System.Collections.Generic;
using System.Threading.Tasks;
using MNDR.API.Core.Entities;

namespace MNDR.API.Core.Interfaces
{
    public interface INotifikacijaRepository : IRepository<Notifikacija>
    {
        Task<IEnumerable<Notifikacija>> GetByKorisnikIdAsync(int korisnikId);
        Task<IEnumerable<Notifikacija>> GetNeprocitaneByKorisnikIdAsync(int korisnikId);
        Task MarkAsReadAsync(int notifikacijaId);
    }
}
