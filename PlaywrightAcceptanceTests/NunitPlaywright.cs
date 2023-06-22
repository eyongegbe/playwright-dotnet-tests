using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlaywrightAcceptanceTests;

public class NunitPlaywright : PageTest
{
    [SetUp]
    public async Task Setup()
    {
        await Page.GotoAsync("https://coinmarketcap.com/");
    }

    [Test]
    public async Task Test1()
    {
        await Expect(Page.Locator("text='Today's Cryptocurrency Prices by Market Cap'")).ToBeVisibleAsync();

    }
}