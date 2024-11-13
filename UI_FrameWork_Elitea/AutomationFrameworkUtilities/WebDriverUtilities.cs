using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFrameworkUtilities
{
    public static class WebDriverUtilities
    {
        public static IWebDriver InitializeDriver(string browserType)
        {
            // Initialize WebDriver based on browser type
            switch (browserType)
{
    case "Chrome":
        driver = new ChromeDriver();
        break;
    case "Firefox":
        driver = new FirefoxDriver();
        break;
    default:
        throw new ArgumentException("Browser type not supported");
}
            return null;
        }

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void TeardownDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}