using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace AutomationFrameworkUtilities
{
    public static class WebDriverUtility
    {
        public static IWebDriver InitializeDriver(string browser)
        {
            IWebDriver driver;
            switch (browser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported");
            }
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void TearDown(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}