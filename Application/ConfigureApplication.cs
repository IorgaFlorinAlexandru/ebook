using Application.Interfaces;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class ConfigureApplication
{
    public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
    {
        // services.AddAutoMapper(typeof(Program));
        services.AddScoped<IProductService,ProductService>();

        return services;
    }
}