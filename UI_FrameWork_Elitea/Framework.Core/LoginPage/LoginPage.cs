using OpenQA.Selenium;
using AutomationFrameworkUtilities;

namespace Framework.Core.LoginPage
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private readonly string _usernameLocator = "#user-name";
        private readonly string _passwordLocator = "#password";
        private readonly string _loginButtonLocator = "#login-button";

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.CssSelector(_usernameLocator)).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.CssSelector(_passwordLocator)).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(By.CssSelector(_loginButtonLocator)).Click();
        }
    }
}