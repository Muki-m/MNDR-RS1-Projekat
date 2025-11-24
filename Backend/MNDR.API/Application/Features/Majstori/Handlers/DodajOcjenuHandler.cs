using MediatR;
using Microsoft.EntityFrameworkCore;
using MNDR.API.Core.Entities;
using MNDR.API.Application.Features.Majstori.Commands;
using MNDR.API.Infrastructure.Data;

namespace MNDR.API.Application.Features.Majstori.Handlers
{
    public class DodajOcjenuHandler : IRequestHandler<DodajOcjenuCommand>
    {
        private readonly ApplicationDbContext _context;

        public DodajOcjenuHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(DodajOcjenuCommand request, System.Threading.CancellationToken cancellationToken)
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
