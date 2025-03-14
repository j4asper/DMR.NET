using DMR.NET.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DMR.NET.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDmrDotNetServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IDmrFtpService, DmrFtpService>()
            .AddSingleton<IDmrDeserializerService, DmrDeserializerService>();
        
        return services;
    }
}