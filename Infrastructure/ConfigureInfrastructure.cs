using Domain.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureInfrastructure
{
    public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseNpgsql(config.GetConnectionString("PostGreConnectionString")));

        services.AddScoped<IRepositoryWrapper,RepositoryWrapper>();

        return services;
    }
}