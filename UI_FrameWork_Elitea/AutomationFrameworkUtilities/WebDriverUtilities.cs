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
            // Placeholder for WebDriver initialization logic
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