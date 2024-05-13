using Dapper.Application.Interfaces;
using Dapper.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Dapper.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IMarriageRepository, MarriageRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
