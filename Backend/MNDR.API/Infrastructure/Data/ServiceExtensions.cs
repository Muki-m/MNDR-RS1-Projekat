using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MNDR.API.Core.Interfaces;
using MNDR.API.Infrastructure.Data.Repositories;

namespace MNDR.API.Infrastructure.Data
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Registriraj sve repozitorije
            services.AddScoped<INotifikacijaRepository, NotifikacijaRepository>();
            
            return services;
        }
    }
}
