namespace DMR.NET.Options;

/// <summary>
/// The FTP values can be found here if they changed:
/// https://motorst.dk/erhverv/motorregistret-for-virksomheder/faa-adgang-til-motorregistret/andre-adgange
/// below "Statistikudtræk"
/// </summary>
public class DmrFtpOptions
{
    public static readonly string DmrFtp = nameof(DmrFtp);
    
    public string Host { get; set; } = "5.44.137.84";

    public string Username { get; set; } = "dmr-ftp-user";

    public string Password { get; set; } = "dmrpassword";

    public string SourcePath { get; set; } = "/ESStatistikListeModtag/";

    public string DestinationPath { get; set; } = "/";

    public string InternalXmlFileName { get; set; } = "ESStatistikListeModtag.xml";
}