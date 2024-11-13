[Binding]
public class Hooks
{
    private IWebDriver _driver;

    [BeforeScenario]
    public void BeforeScenario()
    {
        _driver = new ChromeDriver();
        _driver.Manage().Window.Maximize();
    }

    [AfterScenario]
    public void AfterScenario()
    {
        _driver.Quit();
    }
}