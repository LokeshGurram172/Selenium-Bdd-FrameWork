using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFrameworkUtilities
{
    public static class WebDriverUtility
    {
        public static IWebDriver InitializeDriver(string browserType)
        {
            IWebDriver driver;
            switch (browserType.ToLower())
            {
                case "chrome":
                    driver = new OpenQA.Selenium.Chrome.ChromeDriver();
                    break;
                case "firefox":
                    driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
                    break;
                case "edge":
                    driver = new OpenQA.Selenium.Edge.EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser type not supported");
            }
            driver.Manage().Window.Maximize();
            return driver;
        }

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}