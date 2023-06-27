using System.Xml.XPath;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using PlaywrightAcceptanceTests.Pages;

namespace PlaywrightAcceptanceTests;

public class NunitPlaywright : PageTest
{
    private IPage page;
    
    [SetUp]
    public async Task Setup()
    {
        page = await Browser.NewPageAsync();
        await Page.GotoAsync("https://coinmarketcap.com/");
    }

    [Test]
    public async Task SearchForAnAssetPage()
    {
        var hp = new HomePage(page);
        hp.EnterSearchText("Bitcoin");
    }
}