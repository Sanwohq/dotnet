using Microsoft.Extensions.DependencyInjection;

namespace SanwoHQ;

public static class SanwoServiceExtensions
{
    public static IServiceCollection AddSanwo(
        this IServiceCollection services,
        Action<SanwoOptions> configure)
    {
        services.Configure(configure);
        return services;
    }

    public static IServiceCollection AddSanwo(
        this IServiceCollection services,
        Microsoft.Extensions.Configuration.IConfigurationSection section)
    {
        services.Configure<SanwoOptions>(section);
        return services;
    }
}
