using Microsoft.Extensions.Hosting;

namespace DMR.NET.Extensions;

public static class HostBuilderExtensions
{
    /// <summary>
    /// Configures the services required for the DMR functionality in the host builder.
    /// This method is used to set up DMR-specific services during application startup.
    /// </summary>
    /// <param name="hostBuilder">The IHostBuilder to configure.</param>
    /// <returns>The updated IHostBuilder with the added DMR services.</returns>
    public static IHostBuilder UseDmrDotNet(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((_, services) => services.AddDmrDotNetServices());
        
        return hostBuilder;
    }
}