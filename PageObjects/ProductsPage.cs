public class ProductsPage
{
    private IWebDriver _driver;

    public ProductsPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void VerifyOnProductsPage()
    {
        Assert.IsTrue(_driver.Url.Contains("/inventory.html"));
    }
}