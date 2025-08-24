using Microsoft.Playwright;

namespace TodoMvc.Backend.Playwright.Test.Support;

[TestClass]
public class TodoBaseTest : PlaywrightTest
{
    protected IAPIRequestContext Request { get; private set; }

    [TestInitialize]
    public async Task SetupTest()
    {
        Request = await Playwright.APIRequest.NewContextAsync(new APIRequestNewContextOptions
        {
            BaseURL = StaticConfigurationManager.BaseUrl
        });
    }
}
