namespace Api.Configurations
{
    public static class ConfigureWebServices
    {
        public static IServiceCollection ConfigureWebApi(this IServiceCollection services)
        {
            services.AddCors();

            return services;
        }
    }
}