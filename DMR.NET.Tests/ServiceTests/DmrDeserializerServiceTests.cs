using System.Text.Json;
using DMR.NET.Options;
using DMR.NET.Services;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace DMR.NET.Tests.ServiceTests;

public class DmrDeserializerServiceTests
{
    private readonly ITestOutputHelper output;

    public DmrDeserializerServiceTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact(Skip = "Used for local testing")]
    public async Task DeserializeDmrEntriesAsync()
    {
        var ftpService = Substitute.For<IDmrFtpService>();
        ftpService.GetLatestDmrDatabaseAsync(TestContext.Current.CancellationToken).ReturnsForAnyArgs("ESStatistikListeModtag-20260830-172841.zip");
        
        var logger = Substitute.For<ILogger<DmrDeserializerService>>();
        var options = Microsoft.Extensions.Options.Options.Create(new DmrFtpOptions
        {
            Host = "test",
            Username = "test",
            Password = "test",
            SourcePath = "",
            DestinationPath = "/home/jasper/Desktop/Dmr/"
        });
        
        var service = new DmrDeserializerService(ftpService, options, logger);
        
        var i = 0;
        await foreach (var dmrEntry in service.DeserializeDmrEntriesAsync(TestContext.Current.CancellationToken))
        {
            i++;
        
            if (i % 50_000 == 0)
                output.WriteLine($"Processed {i} entries");
        }
    }
}