using Microsoft.Playwright;

namespace PlaywrightAcceptanceTests.Pages;

public class HomePage
{
    private readonly IPage _page; 
    public HomePage(IPage page) => _page = page; 
    

    private ILocator SearchBox => _page.GetByText("Search", new() { Exact = true });
    private ILocator  SearchField => _page.GetByPlaceholder("Search coin, pair, contract address or exchange"); 
    private ILocator  GoBtn => _page.GetByRole(AriaRole.Button, new() { Name = "Go", Exact = true }); 




    public void  EnterSearchText(string text)
    {
        SearchBox.ClickAsync();
        SearchField.FillAsync(text);
        //SearchField.PressAsync("Enter");
        GoBtn.ClickAsync();
    }

    public Task<ILocator> GetSearchResult(string searchedCoin)
    {
        return Task.FromResult(_page.GetByText(searchedCoin));
    }
    
    //public Task<bool> SearchedCoinIsVisible => GetSearchResult(string searchedCoin).IsVisibleAsync();

}