using AutomationFrameworkUtilities;
using OpenQA.Selenium;

namespace Framework.Core
{
    public class LoginPage
    {
        private IWebDriver driver;
        private readonly string usernameLocator = "#user-name";
        private readonly string passwordLocator = "#password";
        private readonly string loginButtonLocator = "#login-button";

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUsername(string username)
        {
            driver.FindElement(By.CssSelector(usernameLocator)).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            driver.FindElement(By.CssSelector(passwordLocator)).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(By.CssSelector(loginButtonLocator)).Click();
        }
    }
}