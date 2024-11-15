using OpenQA.Selenium;

namespace Framework.Core.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        private readonly By _usernameField = By.Id("user-name");
        private readonly By _passwordField = By.Id("password");
        private readonly By _loginButton = By.Id("login-button");
        private readonly By _errorMessage = By.CssSelector(".error-message-container");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void EnterUsername(string username)
        {
            _driver.FindElement(_usernameField).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(_passwordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            _driver.FindElement(_loginButton).Click();
        }

        public string GetErrorMessage()
        {
            return _driver.FindElement(_errorMessage).Text;
        }
    }
}