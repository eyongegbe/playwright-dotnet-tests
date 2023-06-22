using Microsoft.Playwright;

namespace PlaywrightAcceptanceTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        Assert.Pass();
        using var playwright = await Playwright.CreateAsync();
        await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions{
            Headless = false
        });

        var page = await browser.NewPageAsync();

        await page.GotoAsync("http://www.eapp.somee.com");
        await page.ClickAsync("text=Login");
        await page.ScreenshotAsync(new PageScreenshotOptions
        {
            Path = "demo.jpg"
        });
    }
}