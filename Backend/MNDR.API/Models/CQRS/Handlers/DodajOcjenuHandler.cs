using MediatR;
using Microsoft.EntityFrameworkCore;
using MNDR.API.Models;
using MNDR.API.Models.CQRS.Commands;

namespace MNDR.API.Models.CQRS.Handlers
{
    public class DodajOcjenuHandler : IRequestHandler<DodajOcjenuCommand>
    {
        private readonly ApplicationDbContext _context;

        public DodajOcjenuHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DodajOcjenuCommand request, CancellationToken cancellationToken)
        {
            var majstor = await _context.Majstori.FindAsync(request.MajstorId);
            if (majstor != null)
            {
                majstor.DodajOcjenu(request.Ocjena);
                await _context.SaveChangesAsync();
            }
        }
    }
}
