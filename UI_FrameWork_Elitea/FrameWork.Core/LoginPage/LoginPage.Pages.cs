using OpenQA.Selenium;
using AutomationFrameWorkUtilities;

namespace FrameWork.Core.LoginPage
{
    public partial class LoginPage
    {
        private IWebDriver driver;
        private static readonly LoginPageLocators Locators = new LoginPageLocators();

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterCredentials(string username, string password)
        {
            driver.FindElement(Locators.UsernameField).SendKeys(username);
            driver.FindElement(Locators.PasswordField).SendKeys(password);
        }

        public void ClickLoginButton()
        {
            driver.FindElement(Locators.LoginButton).Click();
        }

        public string GetErrorMessage()
        {
            return driver.FindElement(Locators.ErrorMessage).Text;
        }
    }
}
