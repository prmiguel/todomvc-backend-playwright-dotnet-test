using Microsoft.Extensions.Configuration;

namespace TodoMvc.Backend.Playwright.Test.Support;

public static class StaticConfigurationManager
{
    private const string FileName = "appsettings.json";

    static StaticConfigurationManager()
    {
        AppSettings = new ConfigurationBuilder()
            .AddJsonFile(FileName)
            .AddEnvironmentVariables("TEST_")
            .Build();
    }

    private static IConfiguration AppSettings { get; }
    public static string BaseUrl => AppSettings["api:baseUrl"] ?? string.Empty;
    
    public static string BaseUri => AppSettings["api:baseUri"] ?? string.Empty;
}
