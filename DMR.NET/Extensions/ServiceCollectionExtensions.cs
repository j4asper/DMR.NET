using DMR.NET.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DMR.NET.Extensions;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Registers the services required for the DMR functionality in the dependency injection container.
    /// </summary>
    /// <param name="services">The IServiceCollection to add the services to.</param>
    /// <returns>The updated IServiceCollection with the added services.</returns>
    public static IServiceCollection AddDmrDotNetServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IDmrFtpService, DmrFtpService>()
            .AddSingleton<IDmrDeserializerService, DmrDeserializerService>();
        
        return services;
    }
}