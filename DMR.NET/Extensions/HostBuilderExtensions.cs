using Microsoft.Extensions.Hosting;

namespace DMR.NET.Extensions;

public static class HostBuilderExtensions
{
    public static IHostBuilder UseDmrDotNet(this IHostBuilder hostBuilder)
    {
        hostBuilder.ConfigureServices((_, services) => services.AddDmrDotNetServices());
        
        return hostBuilder;
    }
}