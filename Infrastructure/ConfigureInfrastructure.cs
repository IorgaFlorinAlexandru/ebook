using Domain.Repositories;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureInfrastructure
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped<IRepositoryWrapper,RepositoryWrapper>();

        return services;
    }
}