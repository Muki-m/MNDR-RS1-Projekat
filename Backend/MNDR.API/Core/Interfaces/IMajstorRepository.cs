using System.Collections.Generic;
using System.Threading.Tasks;
using MNDR.API.Core.Entities;

namespace MNDR.API.Core.Interfaces
{
    public interface IMajstorRepository : IRepository<Majstor>
    {
        Task<Majstor> GetByIdWithOglasiAsync(int id);
        Task<IEnumerable<Majstor>> GetBySpecijalizacijaAsync(string specijalizacija);
        Task<Majstor> GetByEmailAsync(string email);
    }
}
