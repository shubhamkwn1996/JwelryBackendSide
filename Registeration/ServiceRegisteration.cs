using JwelryBackendSide.Abstraction.BusinessLayer;
using JwelryBackendSide.Abstraction.RepositoryLayer;
using JwelryBackendSide.BusinessLayer;
using JwelryBackendSide.DatabaseLayer.RepositoryLayer;
using Microsoft.Extensions.DependencyInjection;

namespace JwelryBackendSide.Registeration
{
    public static class ServiceRegisteration
    {
        public static IServiceCollection RegisterDependency(this IServiceCollection services)
        {
            services.AddScoped<IJwelryBusinessLogic, JwelryBusinessLogic>();
            services.AddScoped<IJwelryRepository, JwelryRepository>();
            return services;
        }
    }
}
