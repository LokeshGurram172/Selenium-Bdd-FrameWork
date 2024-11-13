using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationFrameworkUtilities
{
    public static class WebDriverUtilities
    {
        public static IWebDriver InitializeDriver()
        {
            // Initialize WebDriver
            return new ChromeDriver();
        }

        public static void NavigateToUrl(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void Teardown(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}